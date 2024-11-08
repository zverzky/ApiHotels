using Microsoft.AspNetCore.Mvc;

namespace ApiHotels.Controllers
{
    public class HotelsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
