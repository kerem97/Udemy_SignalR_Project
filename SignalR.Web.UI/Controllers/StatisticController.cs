using Microsoft.AspNetCore.Mvc;

namespace SignalR.Web.UI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
