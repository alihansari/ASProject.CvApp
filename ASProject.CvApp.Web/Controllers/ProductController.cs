using ASProject.CvApp.Business.Abstract;
using ASProject.CvApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASProject.CvApp.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGenericService<Product> _productGenericService;
        private readonly IProductService _productService;

        public ProductController(IGenericService<Product> productGenericService,IProductService productService)
        {
            _productGenericService = productGenericService;
            _productService = productService;
        }

        public ActionResult<string> Index()
        {
            List<Product> products = _productGenericService.GetAll();
            
            string json = JsonConvert.SerializeObject(products);
            return json;
        }
        public ActionResult<string> GetProductDetails()
        {
            List<Product> products = _productService.GetProductDetails();

            string json = JsonConvert.SerializeObject(products);
            return json;
        }
    }
}
