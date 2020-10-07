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

namespace SlaughtoriaGamesP1.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly SGDB2Context _db;
        private IMemoryCache _cache;
        public List<Customers> customer;

        public CustomersController(ILogger<CustomersController> logger, SGDB2Context db, IMemoryCache cache)
        {
            _logger = logger;
            _db = db;
            _cache = cache;

            //If the memory cache doesn't have a customers list, create one 
            if(_db.Customers.ToList().Count == 0)
            {

            }
        }
        //Pogoo

        /// <summary>
        /// Returns the login page for users
        /// </summary>
        /// <returns>Login page</returns>
        public IActionResult _SignUpCustomer()
        {
            return View();
        }

        /// <summary>
        /// Allows customer to create an account with given information
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Returns a new customer to the DB</returns>
        [HttpPost]
        public IActionResult SignUpCustomer([Bind("FirstName,LastName,UserName,Pword, City, State, Street, Zip, AptNum, DefaultStore")] Customers customer)
        {
            foreach(var cust in _db.Customers)
            {
                if(customer.UserName == cust.UserName)
                {
                    ModelState.AddModelError("Username", "Username is taken");
                    return View("_SignUpCustomer");
                }
            }
            if(customer.FirstName == null)
            {
                ModelState.AddModelError("FirstName", "Entry can't be empty");
                return View("_SignUpCustomer");
            }
            else if (customer.LastName == null)
            {
                ModelState.AddModelError("LastName", "Entry can't be empty");
                return View("_SignUpCustomer");
            }
            else if (customer.UserName == null)
            {
                ModelState.AddModelError("UserName", "Entry can't be empty");
                return View("_SignUpCustomer");
            }
            else if (customer.Pword == null)
            {
                ModelState.AddModelError("Pword", "Entry can't be empty");
                return View("_SignUpCustomer");
            }
            else if (customer.City == null)
            {
                ModelState.AddModelError("City", "Entry can't be empty");
                return View("_SignUpCustomer");
            }
            else if (customer.State == null)
            {
                ModelState.AddModelError("State", "Entry can't be empty");
                return View("_SignUpCustomer");
            }
            else if (customer.Street == null)
            {
                ModelState.AddModelError("Street", "Entry can't be empty");
                return View("_SignUpCustomer");
            }
            else if (customer.Zip <= 0 || customer.Zip > 99999 )
            {
                ModelState.AddModelError("Zip", "Invalid entry");
                return View("_SignUpCustomer");
            }
            else
            {
                 _cache.Set("loggedInCustomer", customer); //Add as currentlylogged in for future use
                _db.Customers.Add(customer);    //Add the new customer to the db
                _db.SaveChanges();

                return View("_StoreMenu");
            }

            //var custId = StoreMethods.GetCustomerIDs(_db);
            //customer.CustomerId = StoreMethods.GetNewCustID(custId);

           
        }

        /// <summary>
        /// Displays the login page
        /// </summary>
        /// <returns>Customer login screen</returns>
        public IActionResult _Login()
        {
            return View();
        }

        /// <summary>
        /// Checks to make sure info entered for login is correct and directs to storefront
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Pword"></param>
        /// <returns>The logged in user</returns>
        [HttpPost]
        public IActionResult Login(string UserName, string Pword)
        {
            int passFound = 0;
            int userFound = 0;
            var custLoginInfo = StoreMethods.GetCustomers(_db);

            foreach(var customer in custLoginInfo) //Check to make sure valid login info
            {
                if(UserName == customer.UserName) //entered user name corresponds to existing username for logged in user
                {
                    userFound++;
                    if(Pword == customer.Pword) //entered password corresponds to existing pass for logged in user
                    {
                        passFound++;
                        _logger.LogInformation("User logged in");
                        _cache.Set("loggedInCustomer", customer); //Set the logged in customer to be the customer who just passed the login check
                        return View("_StoreMenu");
                    }
                }
            }
            if(userFound == 0) //Print out error messages according to what was entered incorrectly
            {
                _logger.LogInformation("Incorrect username");
                ModelState.AddModelError("Username", "Incorrect username");
                return View("_Login");
            }
            if(passFound == 0)
            {
                _logger.LogInformation("Correct user, incorrect pass");
                ModelState.AddModelError("Pword", "Incorrect password");
                return View("_Login");
            }
            return View("_Login");
        }

        /// <summary>
        /// Returns the results of the user search 
        /// </summary>
        /// <returns>List of search results ordered by last name</returns>
        public IActionResult _ListSearchResults(string name)
        {
            //TODO Add an alert if the search results are EMPTY (no matches)

            //Find all the matches, order by last name 
            var result = StoreMethods.GetSearchResults(name, _db);

            if(result.Count == 0)
            {
                _logger.LogInformation("No results were found");
                return View(result);
            }
            else
            {
                _logger.LogInformation("Results were found");
                return View(result);
            }
        }

        /// <summary>
        /// Empties the cache, removes logged in customer
        /// </summary>
        /// <returns></returns>
        public IActionResult Logout()
        {
            StoreMethods.LogoutCache(_cache);
            _logger.LogInformation("User logged out");
            return View("_Login");
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
