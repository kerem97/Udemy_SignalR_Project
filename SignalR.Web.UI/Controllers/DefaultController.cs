using Microsoft.AspNetCore.Mvc;

namespace SignalR.Web.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
