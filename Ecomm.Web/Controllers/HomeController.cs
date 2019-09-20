using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ecomm.Web.Models;
using Ecomm.DataAccess;
using EComm.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecomm.Web.Controllers
{
    public class HomeController : Controller
    {
        private EcommDataContext _dataContext;

        public HomeController(EcommDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            //var products = _dataContext.Products.Include(p => p.Supplier).ToList();
            //return View(products);
            //return Content($"Number of Products: {_dataContext.Products.Count()}");
            return View();
        }

         public List<Customer> Customers()
        {
            return _dataContext.Customers.ToList();
        }

         public List<Product> Products()
        {
            return _dataContext.Products.ToList();
        }

        public IActionResult ProdCount()
        {
            return Content($"Number of Products: {_dataContext.Products.Count()}");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
