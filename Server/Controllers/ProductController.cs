using Microsoft.AspNetCore.Mvc;
using NewBlazor.Server.Model;
using NewBlazor.Server.Services;
using NewBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlazor.Server.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ProductController:Controller
    {
        private readonly IProduct _productService;
        public ProductController(IProduct productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var product = _productService.GetAll();
            return View(product);
        }
    }
}
