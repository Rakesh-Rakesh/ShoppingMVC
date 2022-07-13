using Microsoft.AspNetCore.Mvc;

namespace ShoppingMVC.Controllers
{
    public class ShoppingController : Controller
    {
       public IActionResult Productlist()
        {

            List<string> pList = new List<string>() { 
            
            "Refrigerater",
            "Washing maching",
            "Teli vision",
            "Laptop"
            };
            ViewBag.list=pList.ToList();
            ViewBag.plist=pList.Count;
           
 
            return View();
        }
        public IActionResult Serachproduct()
        {
            return View();
        }
        public IActionResult ProductSale()
        {
            return View();
        }
    }
}
