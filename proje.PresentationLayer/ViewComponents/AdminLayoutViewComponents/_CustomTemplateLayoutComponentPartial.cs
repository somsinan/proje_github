using Microsoft.AspNetCore.Mvc;

namespace proje.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _CustomTemplateLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
