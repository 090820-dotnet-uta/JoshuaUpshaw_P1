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
using Microsoft.EntityFrameworkCore.Migrations;

namespace SlaughtoriaGamesP1
{
    public class StoreMethods
    {
        //Gets all customers for Login action in Customers Controller
        public static List<Customers> GetCustomers(SGDB2Context _db)
        {
            var custLoginInfo = (from Customers in _db.Customers
                                 select Customers).ToList();
            return custLoginInfo;
        }

        //Gets all customer IDs for the SignUp action in Customer Controller
        public static List<int> GetCustomerIDs(SGDB2Context _db)
        {
            var custId = (from Customers in _db.Customers
                          select Customers.CustomerId).ToList();
            return custId;
        }

        //Gets highest customer ID for SignUp action in Customer controller
        public static int GetNewCustID(List<int> custID)
        {
            int newId = 1;
            int newIdFound = 0;
            if (custID.Count == 0)
            {
                return newId;
            }
            foreach (var custId in custID)
            {
                do
                {
                    if (custID.Contains(newId))
                    {
                        newId++;
                    }
                    else
                    {
                        newIdFound++;
                        return newId;
                    }
                } while (newIdFound == 0);
            }
            return newId;
        }

        //Gets search results for _ListSearchResults in Customer controller
        public static List<Customers> GetSearchResults(string name, SGDB2Context _db)
        {
            if(name.Length == 0 || name == null)
            {
                name = "";
            }
            name = name.ToUpper();

            var result = (from Customers in _db.Customers
                          where Customers.LastName.ToUpper() == name || Customers.LastName.ToUpper().Contains(name)
                          orderby Customers.LastName ascending
                          select Customers).ToList();
            return result;
        }


        //Logs out (empties cache) for Logout in Customer Controller
        public static void LogoutCache(IMemoryCache _cache)
        {
            Customers emptyCustomer = new Customers();
            _cache.Remove("loggedInCustomer");
        }


        //Gets list of store for _SelectDefaultStore in Stores Controller
        public static List<Stores> SelectListOfStores(SGDB2Context _db)
        {
            var storeList = (from Stores in _db.Stores
                             select Stores).ToList();
            return storeList;
        }


        //Retrieves the loggedInCustomer's information for SelectDefaultStore in Stores Controller
        public static Customers SetDefaultStore(SGDB2Context _db, Customers loggedInCustomer)
        {
            var dbCust = (from Customers in _db.Customers
                          where loggedInCustomer.CustomerId == Customers.CustomerId
                          select Customers).ToList().FirstOrDefault();
            return dbCust;
        }

        //Retrieves an item from the cart in Stores Controller for AddItemToCart in Stores Controller
        public static OrderInformation SelectCartItem(OrderInformation newSku, List<OrderInformation> cart)
        {
            var existingItem = (from OrderInformation in cart
                                where OrderInformation.OrderedProduct == newSku.OrderedProduct
                                select OrderInformation).FirstOrDefault();
            return existingItem;
        }

        //Retrieves existing item for edit/delete in Stores Controller
        public static OrderInformation ManipulateCartItem(int itemId, List<OrderInformation> cart)
        {
            var item = (from OrderInformation in cart
                          where itemId == OrderInformation.OrderedProduct
                          select OrderInformation
                       ).FirstOrDefault();
            return item;
        }

        //Gets highest Order ID for the Checkout action in Stores controller 
        public static int GetNewOrderId (List<int> orderIDs)
        {
            //Create a new orderID to group all the ordered items together 
            int newOrderId = 1;
            int orderIdFound = 0;
            if (orderIDs.Count != 0) //If there is orders, create new orderID, if this is first order, OrderId=1
            {
                do
                {
                    if (orderIDs.Contains(newOrderId))
                    {
                        newOrderId++;
                    }
                    else
                    {
                        orderIdFound = 1;
                        return newOrderId;
                    }
                } while (orderIdFound != 1);
            }
            return newOrderId;
        }

        //Gets all orderIDs for checkout in Stores Controller
        public static List<int> GetAllOrderIds (SGDB2Context _db)
        {
            var orderList = (from Orders in _db.Orders
                             select Orders.OrderId).ToList();
            return orderList;
        }

        //Gets all products for checkout (set new quantity) in Stores Controller
        public static List<Products> GetAllProducts(SGDB2Context _db)
        {
            var allItemsInventory = (from Products in _db.Products
                                     select Products).ToList(); //Gets all the existing products
            return allItemsInventory;
        }


                    
        






    }
}
