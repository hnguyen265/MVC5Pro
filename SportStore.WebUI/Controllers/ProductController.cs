using SportStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SportStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repo;
        // GET: Product
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public int pageSize = 4;
        public ProductController(IProductRepository prod)
        {
            this.repo = prod;
        }
        public ViewResult List(int page =1)
        {
            return View(repo.Products
                .OrderBy(p=>p.ProductID)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                
                );
        }
    }
}