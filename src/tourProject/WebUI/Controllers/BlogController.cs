﻿using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;
public class BlogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
