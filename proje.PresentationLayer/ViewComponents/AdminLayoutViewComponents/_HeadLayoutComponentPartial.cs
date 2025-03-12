using Microsoft.AspNetCore.Mvc;

namespace proje.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _HeadLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
