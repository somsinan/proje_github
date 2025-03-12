using Microsoft.AspNetCore.Mvc;

namespace proje.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _ScriptsLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
