﻿using Microsoft.AspNetCore.Mvc;

namespace proje.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _SidebarLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
