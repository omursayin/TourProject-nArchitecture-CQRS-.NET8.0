using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage;

public class _HomePageAboutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}