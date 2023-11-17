using Microsoft.AspNetCore.Mvc;

namespace SignalR.Web.UI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
