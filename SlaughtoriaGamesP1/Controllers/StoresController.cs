using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlaughtoriaGamesP1.Models;
using SlaughtoriaGamesP1.Data;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Http;
using System.Media;
using System.IO.Compression;

namespace SlaughtoriaGamesP1.Controllers
{
    public class StoresController : Controller
    {
        //TODO make sure every screen gives option to return to previous screen
        private  ILogger<StoresController> _logger;
        private  SGDB2Context _db;
        private IMemoryCache _cache;
        public List<Stores> store;
        public Customers loggedInCustomer;
        public List<InventoryProductInfo> inventoryInfo;
        public List<OrderInformation> orderInfo;
        public List<OrderInformation> Cart = new List<OrderInformation>();

        public StoresController(ILogger<StoresController> logger, SGDB2Context db, IMemoryCache cache)
        {
            _logger = logger;
            _db = db;
            _cache = cache;

            if(!_cache.TryGetValue("Cart", out Cart))
            {
                _cache.Set("Cart", new List<OrderInformation>());
            }
        }
        public IActionResult _StoreMenu()
        {
            return View();
        }


        /// <summary>
        /// Fetches list of available stores for user to choose from
        /// </summary>
        /// <returns>Store list</returns>
        public IActionResult _SelectDefaultStore()
        {
            if (!_cache.TryGetValue("loggedInCustomer", out loggedInCustomer))
            {
                //If the user isn't logged in, return to login screen
                return View("_Login");
            }
            var storeList = StoreMethods.SelectListOfStores(_db);
           
            return View(storeList);
        }

        /// <summary>
        /// Takes the user input and updates the customers default store in db and cache 
        /// </summary>
        /// <param name="storeSelection"></param>
        /// <returns>Updated customer object</returns>
        public IActionResult SelectDefaultStore(Stores store)
        {
            int storeSelection = store.StoreId;
            //Update the default store in the cache 
            var loggedIn = _cache.Get("loggedInCustomer");
            loggedInCustomer = (Customers)loggedIn;
            loggedInCustomer.DefaultStore = storeSelection;
            _cache.Set("loggedInCustomer", loggedInCustomer);
            _logger.LogInformation("Logged in customer updated on cache");

            //Update the default store in the database 
            var dbCust = StoreMethods.SetDefaultStore(_db, loggedInCustomer);
            dbCust.DefaultStore = storeSelection;

            _db.SaveChanges();
            _logger.LogInformation("Logged in customer updated on database");

            return View("_StoreMenu");
        }

      

        /// <summary>
        /// Prints out all the stores and lets the user choose which inventory they want to view 
        /// </summary>
        /// <returns>List of stores</returns>
        public IActionResult _GetStoreInventory()
        {
            if (!_cache.TryGetValue("loggedInCustomer", out loggedInCustomer))
            {
                //If the user isn't logged in, return to login screen
                return View("_Login");
            }
            var storeList = StoreMethods.SelectListOfStores(_db);

            return View(storeList);
        }

        /// <summary>
        /// Where the user selects which store's inventory they want to see
        /// </summary>
        /// <param name="store"></param>
        public IActionResult GetStoreInventory(Stores store)
        {
            //Get inventory of selected store
            var storeInventory = (from Inventory in _db.Inventory
                                  where Inventory.StoreInventory == store.StoreId
                                  select new {Inventory.ItemInInventory, Inventory.ProductCurrentQuantity }).ToList();
            //Get all the product information 
            var productInfo = (from Products in _db.Products
                            where  Products.IsInBundle == false
                            select new { Products.ProductName, 
                                         Products.ProductDescrip, 
                                         Products.Skunum, 
                                         Products.UnitPrice}).ToList();
            //Get info on all the products in the inventory
            var inventoryProducts = (from Inventory in storeInventory
                                     from Products in productInfo
                                     where Inventory.ItemInInventory == Products.Skunum && Inventory.ProductCurrentQuantity > 0
                                     select new
                                     {
                                         Inventory.ProductCurrentQuantity,
                                         Products.ProductName,
                                         Products.ProductDescrip,
                                         Products.Skunum,
                                         Products.UnitPrice
                                     }).ToList();

            //Instantiate list here so it resets with every iteration of this method 
            inventoryInfo = new List<InventoryProductInfo>();

            //Store all the inventory's products into a list of our view model data type
            foreach (var product in inventoryProducts)
            {
                InventoryProductInfo item = new InventoryProductInfo();
                item.Skunum = product.Skunum;
                item.ProductName = product.ProductName;
                item.ProductDescrip = product.ProductDescrip;
                item.UnitPrice = product.UnitPrice;
                item.ProductCurrentQuantity = product.ProductCurrentQuantity;
                inventoryInfo.Add(item);
            }
            //TODO Add alert for if store inventory is empty (everything out of stock)
            //TODO (maybe) create a new table that gives each product the appropriate logo for their system
            return View("_ListStoreInventory", inventoryInfo);
        }


        /// <summary>
        /// Prints out the selected store's inventory based on user selection
        /// </summary>
        /// <returns></returns>
        public IActionResult _ListStoreInventory(List<InventoryProductInfo> inventoryInfo)
        {
            return View(inventoryInfo);
        }

        /// <summary>
        /// Displays view for user to select Order history type
        /// </summary>
        /// <returns>Order history selection view</returns>
        public IActionResult _GetOrderHistorySelection()
        {
            if (!_cache.TryGetValue("loggedInCustomer", out loggedInCustomer))
            {
                //If the user isn't logged in, return to login screen
                return View("_Login");
            }
            var storeList = StoreMethods.SelectListOfStores(_db);
            return View(storeList);
        }

        /// <summary>
        /// Processes user's history type selection input 
        /// </summary>
        /// <param name="orderHistoryType"></param>
        /// <param name="store"></param>
        /// <returns>Appropriate order history list view</returns>
        public IActionResult GetOrderHistorySelection(int orderHistoryType, Stores store = null)
        {
            if(orderHistoryType == 1) //User selects to see their order history 
            {
                //Return the customer order history view which always prints out the order history of the currently logged in customer
                var loggedIn = _cache.Get("loggedInCustomer");
                loggedInCustomer = (Customers)loggedIn;

                //Select all the orders associated with logged in customer
                var custOrders = (from Orders in _db.Orders
                                  where Orders.WhoOrdered == loggedInCustomer.CustomerId
                                  select new { Orders.OrderDate,
                                                Orders.OrderTotal,
                                                Orders.OrderId,
                                                Orders.OrderedProduct,
                                                Orders.OrderedProductAmount,
                                                Orders.StoreOrderedFrom,
                                                Orders.WhoOrdered}).ToList();

                //Select all the product info 
                var orderItems = (from Products in _db.Products
                                  where Products.IsInBundle == false
                                  select new {Products.Skunum,
                                                Products.ProductName,
                                                Products.UnitPrice,
                                                Products.ProductDiscount}).ToList();

                //Get product info on all items in the order 
                var custOrderInfo = (from Orders in custOrders
                                     from Products in orderItems
                                     where Orders.OrderedProduct == Products.Skunum
                                     orderby Orders.OrderDate descending
                                     select new {
                                         Orders.OrderId,
                                         Orders.OrderTotal,
                                         Orders.OrderedProduct,
                                         Products.ProductName,
                                         Orders.OrderedProductAmount,
                                         Products.UnitPrice,
                                         Products.ProductDiscount,
                                         Orders.StoreOrderedFrom,
                                         Orders.WhoOrdered,
                                         Orders.OrderDate,
                                     }).ToList();

                //Fresh instantiation of the OrderInfo list for populating 
                orderInfo = new List<OrderInformation>();
                foreach(var order in custOrderInfo)
                {
                    OrderInformation item = new OrderInformation();
                    item.OrderId = order.OrderId;
                    item.OrderedProduct = order.OrderedProduct;
                    item.ProductName = order.ProductName;
                    item.OrderedProductAmount = order.OrderedProductAmount;
                    item.UnitPrice = order.UnitPrice;
                    item.ProductDiscount = order.ProductDiscount;
                    item.StoreOrderedFrom = order.StoreOrderedFrom;
                    item.WhoOrdered = order.WhoOrdered;
                    item.OrderDate = order.OrderDate;
                    item.OrderTotal = order.OrderTotal;
                    orderInfo.Add(item);
                }
                return View("_CustomerOrderHistory", orderInfo);
            }
            return View("_GetOrderHistorySelection");
        }

        /// <summary>
        /// Displays list of user's orders
        /// </summary>
        /// <param name="custOrders"></param>
        /// <returns>customer order history view</returns>
        public IActionResult _CustomerOrderHistory(List<OrderInformation> custOrders)
        {
            //TODO Add alerts/errors for when order history list is EMPTY (no orders placed)
            return View(custOrders);
        }

        /// <summary>
        /// Displays list of store's order history
        /// </summary>
        /// <param name="storeOrders"></param>
        /// <returns>store order history view</returns>
        public IActionResult _StoreOrderHistory(Stores store)
        {
            //user selected to see store history, selected store now utilized
            int storeSelection = store.StoreId;

            //Select all the orders associated with logged in customer
            var storeOrders = (from Orders in _db.Orders
                               where Orders.StoreOrderedFrom == store.StoreId
                               select new
                               {
                                   Orders.OrderDate,
                                   Orders.OrderId,
                                   Orders.OrderedProduct,
                                   Orders.OrderedProductAmount,
                                   Orders.StoreOrderedFrom,
                                   Orders.WhoOrdered,
                                   Orders.OrderTotal
                               }).ToList();

            //Select all the product info 
            var orderItems = (from Products in _db.Products
                              where Products.IsInBundle == false
                              select new
                              {
                                  Products.Skunum,
                                  Products.ProductName,
                                  Products.UnitPrice,
                                  Products.ProductDiscount
                              }).ToList();

            //Get product info on all items in the order 
            var storeOrderInfo = (from Orders in storeOrders
                                  from Products in orderItems
                                  where Orders.OrderedProduct == Products.Skunum
                                  orderby Orders.OrderDate descending
                                  select new
                                  {
                                      Orders.OrderId,
                                      Orders.OrderedProduct,
                                      Products.ProductName,
                                      Orders.OrderedProductAmount,
                                      Products.UnitPrice,
                                      Products.ProductDiscount,
                                      Orders.StoreOrderedFrom,
                                      Orders.WhoOrdered,
                                      Orders.OrderDate,
                                      Orders.OrderTotal
                                  }).ToList();

            //Fresh instantiation of the OrderInfo list for populating 
            orderInfo = new List<OrderInformation>();
            foreach (var order in storeOrderInfo)
            {
                //Create and add a new order to the list of order information to be displayed
                OrderInformation item = new OrderInformation();
                item.OrderId = order.OrderId;
                item.OrderedProduct = order.OrderedProduct;
                item.ProductName = order.ProductName;
                item.OrderedProductAmount = order.OrderedProductAmount;
                item.UnitPrice = order.UnitPrice;
                item.ProductDiscount = order.ProductDiscount;
                item.StoreOrderedFrom = order.StoreOrderedFrom;
                item.WhoOrdered = order.WhoOrdered;
                item.OrderDate = order.OrderDate;
                item.OrderTotal = order.OrderTotal;
                orderInfo.Add(item);
            }
            return View(orderInfo);
        }

        /// <summary>
        /// Runs the GetInventory action and prints out the inventory of the customer's default store
        /// </summary>
        /// <returns></returns>
        public IActionResult GetCustomerStoreInventory()
        {
            if (!_cache.TryGetValue("loggedInCustomer", out loggedInCustomer))
            {
                //If the user isn't logged in, return to login screen
                return View("_Login");
            }
            //Get the logged in customer
            var loggedIn = _cache.Get("loggedInCustomer");
            loggedInCustomer = (Customers)loggedIn;

            //Get inventory of the customer's default store
            var storeInventory = (from Inventory in _db.Inventory
                                  where Inventory.StoreInventory == loggedInCustomer.DefaultStore
                                  select new { Inventory.ItemInInventory, Inventory.ProductCurrentQuantity }).ToList();
            //Get all the product information 
            var productInfo = (from Products in _db.Products
                               where Products.IsInBundle == false
                               select new
                               {
                                   Products.ProductName,
                                   Products.ProductDescrip,
                                   Products.Skunum,
                                   Products.UnitPrice,
                                   Products.ProductDiscount,
                                   Products.BundleId,
                                   Products.IsBundle,
                                   Products.IsInBundle
                               }).ToList();
            //Get info on all the products in the inventory
            var inventoryProducts = (from Inventory in storeInventory
                                     from Products in productInfo
                                     where Inventory.ItemInInventory == Products.Skunum && Inventory.ProductCurrentQuantity > 0
                                     select new
                                     {
                                         Inventory.ProductCurrentQuantity,
                                         Products.ProductName,
                                         Products.ProductDescrip,
                                         Products.Skunum,
                                         Products.ProductDiscount,
                                         Products.UnitPrice,
                                         Products.BundleId,
                                         Products.IsBundle,
                                         Products.IsInBundle
                                     }).ToList();

            //Instantiate list here so it resets with every iteration of this method 
            inventoryInfo = new List<InventoryProductInfo>();

            //Store all the inventory's products into a list of our view model data type
            foreach (var product in inventoryProducts)
            {
                InventoryProductInfo item = new InventoryProductInfo();
                item.Skunum = product.Skunum;
                item.ProductName = product.ProductName;
                item.ProductDescrip = product.ProductDescrip;
                item.UnitPrice = product.UnitPrice;
                item.ProductDiscount = product.ProductDiscount;
                item.ProductCurrentQuantity = product.ProductCurrentQuantity;
                item.IsBundle = product.IsBundle;
                item.IsInBundle = product.IsInBundle;
                item.BundleId = product.BundleId;
                inventoryInfo.Add(item);
            }
            //TODO Add alert for if store inventory is empty (everything out of stock)
            //TODO (maybe) create a new table that gives each product the appropriate logo for their system
            InventoryProductSelect select = new InventoryProductSelect();
            select.inventoryitem = inventoryInfo;
            return View("_SelectItem", inventoryInfo);
        }

        /// <summary>
        /// Displays the order screen where customers place items in their cart
        /// </summary>
        /// <returns></returns>
        public IActionResult _SelectItem (List<InventoryProductInfo> inventoryInfo)
        {
            return View(inventoryInfo);
        }

        /// <summary>
        /// Adds item to cart when user clicks button
        /// </summary>
        /// <returns></returns>
        public IActionResult AddItemToCart(InventoryProductInfo selectedItem, int numOrdered = 1)
        {
            //TODO Add a check to make sure quantity isnt more than whats available

            //Not returning anything, just altering the cart list 

            //Cart is a list of OrderInformation because that model contains all the relevant info on the ordered Product
            var loggedIn = _cache.Get("loggedInCustomer");
            loggedInCustomer = (Customers)loggedIn;

            var itemCart = _cache.Get("Cart");
            List<OrderInformation> cart = new List<OrderInformation>();
            cart = (List<OrderInformation>)itemCart;

            //Check to see if the product is already in the cart or a new cart item
            OrderInformation newSKU = new OrderInformation();
            newSKU.OrderedProduct = selectedItem.Skunum;
            newSKU.OrderedProductAmount = selectedItem.OrderedAmt;
            int matchWasFound = 0;
            foreach(var item in cart)
            {
                if(newSKU.OrderedProduct == item.OrderedProduct)
                {
                    matchWasFound++;
                }
            }
            if(matchWasFound != 0)
            {
                //Grab the item from the cart
                var existingItem = StoreMethods.SelectCartItem(newSKU, cart);

                //Update the existing item's ordered amount and the total price for the item
                existingItem.OrderedProductAmount += newSKU.OrderedProductAmount;
                existingItem.UnitPrice = existingItem.OrderedProductAmount * (existingItem.UnitPrice * (1 - existingItem.ProductDiscount));
                _cache.Set("Cart", cart);
                return RedirectToAction("GetCustomerStoreInventory");
            }
            else //If this is the first time this item has been added, create a new cart object
            {
                OrderInformation newCartItem = new OrderInformation();
                newCartItem.OrderedProduct = selectedItem.Skunum;
                newCartItem.OrderedProductAmount = numOrdered;
                newCartItem.ProductName = selectedItem.ProductName;
                newCartItem.UnitPrice = numOrdered * (selectedItem.UnitPrice*(1-selectedItem.ProductDiscount)); //Total price of that item given the discount and num ordered
                newCartItem.WhoOrdered = loggedInCustomer.CustomerId;
                newCartItem.StoreOrderedFrom = loggedInCustomer.DefaultStore;
                newCartItem.IsBundle = selectedItem.IsBundle;
                newCartItem.IsInBundle = selectedItem.IsInBundle;
                newCartItem.BundleId = selectedItem.BundleId;
                cart.Add(newCartItem); //Add new cart item to our cart
                _cache.Set("Cart", cart); //Set our cart to be the new cart
                return RedirectToAction("GetCustomerStoreInventory");
            }
        }

        /// <summary>
        /// Returns a view that lists the cart's current contents 
        /// </summary>
        /// <returns></returns>
        public IActionResult _CheckCart()
        {
            var itemCart = _cache.Get("Cart");
            List<OrderInformation> cart = new List<OrderInformation>();
            cart = (List<OrderInformation>)itemCart;
            if (cart.Count == 0)
            {
                //TODO Return alert for an empty cart 
                _logger.LogInformation("Cart was empty");
                return RedirectToAction("GetCustomerStoreInventory");
            }
            else
            {
                return View(cart);
            }
        }

        /// <summary>
        /// Edits item quantity
        /// </summary>
        /// <param name="cartItem"></param>
        /// <param name="newNum"></param>
        public IActionResult EditCartItem(OrderInformation cartItem)
        {
            //Void because we are just editing our cart list

            //TODO Add a check to make sure new quantity isnt more than whats available
            //TODO Finish the editting functionality 
            var itemCart = _cache.Get("Cart");
            List<OrderInformation> cart = new List<OrderInformation>();
            cart = (List<OrderInformation>)itemCart;
            //Select the item from our cart that needs to be edited and edit 
            var edit = StoreMethods.ManipulateCartItem(cartItem, cart);

            //Update the items ordered amount and total unit price 
            edit.OrderedProductAmount = cartItem.OrderedProductAmount;
            edit.UnitPrice = edit.OrderedProductAmount * (edit.UnitPrice * (1 - edit.ProductDiscount));
            _cache.Set("Cart", cart);
            return RedirectToAction("GetCustomerStoreInventory");
        }

        /// <summary>
        /// Deletes item from cart
        /// </summary>
        /// <param name="cartItem"></param>
        public IActionResult DeleteCartItem(OrderInformation cartItem)
        {
            var itemCart = _cache.Get("Cart");
            List<OrderInformation> cart = new List<OrderInformation>();
            cart = (List<OrderInformation>)itemCart;

            //Select item to be deleted
            var delete = StoreMethods.ManipulateCartItem(cartItem, cart);

            cart.Remove(delete);
            _cache.Set("Cart", cart);
            return RedirectToAction("GetCustomerStoreInventory");
        }

        /// <summary>
        /// Creates a new order item, calculates order total and updates inventory
        /// </summary>
        public IActionResult Checkout()
        {
            //Takes our Cart, creates a new order item, calculates orderTotal, and updates the inventory 

            //get the logged in customer
            var loggedIn = _cache.Get("loggedInCustomer");
            loggedInCustomer = (Customers)loggedIn;

            //Retrieve the cart contents 
            var itemCart = _cache.Get("Cart");
            List<OrderInformation> cart = new List<OrderInformation>();
            cart = (List<OrderInformation>)itemCart;

            //Get new order id 
            var orderList = StoreMethods.GetAllOrderIds(_db);
            int newOrderId = StoreMethods.GetNewOrderId(orderList);
            
            if (cart.Count == 0)
            {
                _logger.LogInformation("Cart was empty");
                return RedirectToAction("GetCustomerStoreInventory");
            }
            else //Begin checkout 
            {
                _logger.LogInformation("Cart had items, beginning checkout...");
                decimal orderTotal = 0;
                foreach(var product in cart)
                {
                    //Update the item quantities 
                    var allItemsInventory = StoreMethods.GetAllProducts(_db);

                    var storeInventory = (from Inventory in _db.Inventory
                                          where Inventory.StoreInventory == loggedInCustomer.DefaultStore
                                          select new { Inventory.InventoryId,
                                                        Inventory.ItemInInventory, 
                                                        Inventory.StoreInventory, 
                                                        Inventory.ProductCurrentQuantity }).ToList(); //Gets only the user's default store's inventory
                    //var allInventories = (from Inventory in _db.Inventory
                    //                      select new
                    //                      {
                    //                          Inventory.InventoryId,
                    //                          Inventory.ItemInInventory,
                    //                          Inventory.StoreInventory,
                    //                          Inventory.ProductCurrentQuantity
                    //                      }).ToList();
                    foreach (var Inventory in _db.Inventory) //Update the ordered product's quantity
                    {
                        foreach(var storeInv in storeInventory)
                        {
                            if (storeInv.StoreInventory == Inventory.StoreInventory && Inventory.ItemInInventory == product.OrderedProduct && Inventory.StoreInventory == loggedInCustomer.DefaultStore)
                            {
                                int newQuantity = storeInv.ProductCurrentQuantity - product.OrderedProductAmount;
                                Inventory.ProductCurrentQuantity = newQuantity; //New quantity set for ordered product
                                _logger.LogInformation($"Amount decremented");
                                
                            }
                            else
                            {
                                continue;
                            }
                        }
                        
                    }
                    if (product.IsBundle == true) //if the ordered product is a bundle, update associated items
                    {
                        foreach (var inventory in _db.Inventory)
                        {
                            foreach (var items in allItemsInventory)
                            {
                                if (items.BundleId == product.BundleId && inventory.ItemInInventory == items.Skunum && items.IsInBundle == true && inventory.StoreInventory == loggedInCustomer.DefaultStore) //if the item is InBundle, is part of the orderedProduct's bundle, and available at the same store
                                {
                                    inventory.ProductCurrentQuantity -= product.OrderedProductAmount; //Decrement items that are a part of the bundle as well
                                    _logger.LogInformation("Bundle included item decremented");
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                    _db.SaveChanges();
                    //Because the 'unit price' of each item is calculated with ordered# and discount, just add item totals
                    orderTotal += product.UnitPrice;
                    orderTotal = Math.Round(orderTotal, 2); //2 decimal points
                }
                //Need a uniform order total, so we need another foreach loop
                foreach(var product in cart)
                {
                    Orders newOrder = new Orders();
                    newOrder.OrderDate = DateTime.Now;
                    newOrder.OrderedProduct = product.OrderedProduct;
                    newOrder.OrderedProductAmount = product.OrderedProductAmount;
                    newOrder.OrderTotal = orderTotal;
                    newOrder.StoreOrderedFrom = loggedInCustomer.DefaultStore;
                    newOrder.WhoOrdered = loggedInCustomer.CustomerId;
                    newOrder.OrderId = newOrderId;
                    _db.Orders.Add(newOrder);
                    _db.SaveChanges();
                }
                //Empty out the cart, set the cache's cart to be the new empty cart, then return the checkout screen
                List<OrderInformation> emptyCart = new List<OrderInformation>();
                List<OrderInformation> checkoutCart = new List<OrderInformation>();
                foreach(var item in cart)
                {
                    OrderInformation purchased = new OrderInformation();
                    purchased = item;
                    purchased.OrderDate = DateTime.Now;
                    purchased.OrderTotal = orderTotal;
                    checkoutCart.Add(purchased);
                }
                _cache.Set("Cart", emptyCart);
                return View("_Checkout", checkoutCart );
            }
        }

        public IActionResult _Checkout(List<OrderInformation> cart)
        {
            return View(cart);
        }
    }

        
    
}
