using Microsoft.AspNetCore.Mvc;

namespace SignalR.Web.UI.ViewComponents.MenuComponents
{
    public class _MenuHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
