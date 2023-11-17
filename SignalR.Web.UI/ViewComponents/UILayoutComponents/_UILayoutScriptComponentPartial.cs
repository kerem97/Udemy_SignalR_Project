using Microsoft.AspNetCore.Mvc;

namespace SignalR.Web.UI.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
