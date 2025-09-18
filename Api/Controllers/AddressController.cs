using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class AddressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
