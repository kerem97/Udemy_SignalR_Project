using Microsoft.AspNetCore.Mvc;

namespace SignalR.Web.UI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
