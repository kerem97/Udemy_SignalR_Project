using Microsoft.AspNetCore.Mvc;

namespace SignalR.Web.UI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
