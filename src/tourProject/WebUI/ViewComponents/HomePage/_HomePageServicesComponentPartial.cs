﻿using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage;

public class _HomePageServicesComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
