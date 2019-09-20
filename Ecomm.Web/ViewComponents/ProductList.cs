using Ecomm.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomm.Web.ViewComponents
{
    public class ProductList : ViewComponent
    {
        private EcommDataContext _dataContext;

        public ProductList(EcommDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            var products = _dataContext.Products.Include(p => p.Supplier).ToList();
            return Task.FromResult<IViewComponentResult>(View(products));
        }
        //public IActionResult Detail(int id)
        // {
        ///    var product = _dataContext.Products.Include(p => p.Supplier).SingleOrDefault(p => p.Id == id);
        //     return View(product);
        //}
    }
}
