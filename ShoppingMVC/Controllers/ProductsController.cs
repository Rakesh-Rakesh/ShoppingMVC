using Microsoft.AspNetCore.Mvc;
using ShoppingMVC.Models;
namespace ShoppingMVC.Controllers
{
    public class ProductsController : Controller
    {
        Products objProd = new Products();
       public IActionResult DisplayProducts()
        {
            ViewBag.products = objProd.GetAllProducts();
            return View();
        }

        public  IActionResult SearchProduct()
        {
            
            ViewBag.hasData = false;
            return View();
        }

        [HttpPost]
        public IActionResult SearchProduct(int id)
        {
            ViewBag.hasData = true;
            ViewBag.productinf = objProd.GetProductsById(id);
            return View();
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                ViewBag.message = objProd.DeleteProducts(id);
                return View();

            }
            catch (Exception es)
            {
                ViewBag.errorMessage = es.Message;
            }
            return View();

        }

       public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Products newProd)
        {
            ViewBag.message = objProd.AddProducts(newProd);
            return View();
        }
    }
}
