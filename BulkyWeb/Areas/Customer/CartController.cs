using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Customer {
    [Area("customer")]
    [Authorize]
    public class CartController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
