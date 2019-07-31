namespace WishList.Controller
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
