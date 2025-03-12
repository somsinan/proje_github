﻿using Microsoft.AspNetCore.Mvc;
using proje.BusinessLayer.Abstract;

namespace proje.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult ProductList()
        {
            var values = _productService.TGetAll();
            return View(values);
        }

        public IActionResult ProductListWithCategory()
        {
            var values =_productService.TProductsListWithCategory();
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductListWithCategory");
        }

        [HttpGet]

        public IActionResult CreateProduct()
        {
            return View();
        }
    }
}
