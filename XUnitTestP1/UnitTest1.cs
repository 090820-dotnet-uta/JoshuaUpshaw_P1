using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Media;
using System.IO.Compression;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Mvc;
using SlaughtoriaGamesP1.Models;
using SlaughtoriaGamesP1.Data;
using Microsoft.EntityFrameworkCore;
using SlaughtoriaGamesP1;
using SlaughtoriaGamesP1.Controllers;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace XUnitTestP1
{
    public class UnitTest1
    {


        [Fact]
        public void GetCustomerReturnsListOfCustomers()
        {

            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                var result = StoreMethods.GetCustomers(context);
                Assert.IsType<List<Customers>>(result);
            }
            
        }//1

        [Fact]
        public void SearchCustomerReturnsEmptyListOfCustomers()
        {

            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                List<Customers> result = StoreMethods.GetSearchResults("", context);
                int isEmpty = result.Count;
                Assert.True(isEmpty == 0);
            }

        }//2

        [Fact]
        public void SearchCustomerReturnsPopulatedListOfCustomers()
        {

            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                Customers customer = new Customers {FirstName = "aaron", LastName = "aaronson" };
                context.Customers.Add(customer);
                context.SaveChanges();

                List<Customers> result = StoreMethods.GetSearchResults("a", context);
                int isEmpty = result.Count;
                Assert.False(isEmpty == 0);
            }

        }//3

        [Fact]
        public void SearchCustomerReturnsListOfCustomers()
        {

            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                var result = StoreMethods.GetSearchResults("a", context);
                Assert.IsType<List<Customers>>(result);
            }

        }//4

        [Fact]
        public void LogoutEmptiesCacheRegion()
        {
            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();
            var _cache = serviceProvider.GetService<IMemoryCache>();

            int isEmpty;
            Customers test = new Customers();
            Customers empty = new Customers();
            _cache.Set("loggedInCustomer", test);
            StoreMethods.LogoutCache(_cache);
            if(!_cache.TryGetValue("loggedInCustomer", out empty))
            {
                isEmpty = 1;
            }
            else
            {
                isEmpty = 2;
            }
            
            //Check that the loggedInCustomer is empty
            Assert.Equal(1, isEmpty);
        }//5

        [Fact]
        public void GetCustomerIDReturnsCustomerID()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                var result = StoreMethods.GetCustomerIDs(context);
                Assert.IsType<List<int>>(result);
            }
        }//6

        [Fact]
        public void GetCustomerIDReturnsPopulatedList()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                Customers customer = new Customers { CustomerId = 200 };
                context.Customers.Add(customer);
                context.SaveChanges();
                List<int> result = StoreMethods.GetCustomerIDs(context);
                int isEmpty = result.Count;
                Assert.True(result.Count > 0);
            }
        }//7

        [Fact]
        public void GetHighestIDReturnsOneMaxID()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                var custID = StoreMethods.GetCustomerIDs(context);
                var result = StoreMethods.GetNewCustID(custID);
                Assert.IsType<int>(result);
            }
        }//8

        [Fact]
        public void GetHighestIDIncrements()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                var custID = StoreMethods.GetCustomerIDs(context);
                var result = StoreMethods.GetNewCustID(custID);
                custID.Add(result);
                var result1 = StoreMethods.GetNewCustID(custID);

                Assert.True(result1 != result);
            }
        }//9

        [Fact]
        public void HighestIDSetsTo1IfListEmpty()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                List<int> empty = new List<int>();
                var result = StoreMethods.GetNewCustID(empty);
                
                Assert.True(result == 1);
            }
        }//10

        [Fact]
        public void SelectListOfStoreCreatesListOfStores()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
               .UseInMemoryDatabase(databaseName: "SGDB2")
               .Options;

            using (var context = new SGDB2Context(options))
            {
                var list = StoreMethods.SelectListOfStores(context);
                Assert.IsType<List<Stores>>( list);
            }
        }//11

        [Fact]
        public void SelectListOfStoreCreatesPopulatedList()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
               .UseInMemoryDatabase(databaseName: "SGDB2")
               .Options;

            using (var context = new SGDB2Context(options))
            {
                Stores store = new Stores();
                context.Stores.Add(store);
                context.SaveChanges();
                var list = StoreMethods.SelectListOfStores(context);
                int isEmpty = list.Count;
                Assert.True(isEmpty > 0);
            }
        }//12

        [Fact]
        public void SelectDefaultStoreReturnsACustomerType()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
               .UseInMemoryDatabase(databaseName: "SGDB2")
               .Options;

            using (var context = new SGDB2Context(options))
            {
                Customers loggedIn = new Customers{ FirstName = "kk", LastName = "kk", CustomerId = 1, DefaultStore = 5 };
                context.Customers.Add(loggedIn);
                context.SaveChanges();
                var result = StoreMethods.SetDefaultStore(context, loggedIn);
                
                Assert.IsType<Customers>(result);
            }
        }//13

        [Fact]
        public void SelectDefaultStoreReturnsASingleCustomer()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
               .UseInMemoryDatabase(databaseName: "SGDB2")
               .Options;

            using (var context = new SGDB2Context(options))
            {
                Customers loggedIn = new Customers { FirstName = "kk", LastName = "kk", CustomerId = 1, DefaultStore = 5 };
                var result = StoreMethods.SetDefaultStore(context, loggedIn);
                
                Assert.IsNotType<List<Customers>>(result);
            }
        }//14

        [Fact]
        public void SelectDefaultStoreReturnsEmptyOnInvalidEntry()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
               .UseInMemoryDatabase(databaseName: "SGDB2")
               .Options;

            using (var context = new SGDB2Context(options))
            {
                Customers loggedIn = new Customers { FirstName = "kk", LastName = "kk", CustomerId = -1, DefaultStore = 5 };
                Customers result = StoreMethods.SetDefaultStore(context, loggedIn);
                Assert.Null(result);
            }
        }//15

        [Fact]
        public void GetHighestOrderIDReturnsInt()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                var orderId = StoreMethods.GetAllOrderIds(context);
                var result = StoreMethods.GetNewOrderId(orderId);
                Assert.IsType<int>(result);
            }
        }//16

        [Fact]
        public void GetHighestOrderIdIncrements()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                var orderId = StoreMethods.GetAllOrderIds(context);
                var result = StoreMethods.GetNewOrderId(orderId);
                orderId.Add(result);
                var result1 = StoreMethods.GetNewOrderId(orderId);

                Assert.True(result1 != result);
            }
        }//17

        [Fact]
        public void GetHighestOrderIDSetsTo1IfListEmpty()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
                .UseInMemoryDatabase(databaseName: "SGDB2")
                .Options;

            using (var context = new SGDB2Context(options))
            {
                List<int> empty = new List<int>();
                int result = StoreMethods.GetNewOrderId(empty);

                Assert.True(result == 1);
            }
        }//18

        [Fact]
        public void SelectAllProductsReturnsListOfProducts()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
               .UseInMemoryDatabase(databaseName: "SGDB2")
               .Options;

            using (var context = new SGDB2Context(options))
            {
                var list = StoreMethods.GetAllProducts(context);
                Assert.IsType<List<Products>>(list);
            }
        }//19

        [Fact]
        public void SelectAllProductsReturnsPopulatedList()
        {
            var options = new DbContextOptionsBuilder<SGDB2Context>()
               .UseInMemoryDatabase(databaseName: "SGDB2")
               .Options;

            using (var context = new SGDB2Context(options))
            {
                Products item1 = new Products { };
                context.Products.Add(item1);
                context.SaveChanges();
                var list = StoreMethods.GetAllProducts(context);
                int isEmpty = list.Count;
                Assert.True(isEmpty > 0);
            }
        }//20

    }
}
