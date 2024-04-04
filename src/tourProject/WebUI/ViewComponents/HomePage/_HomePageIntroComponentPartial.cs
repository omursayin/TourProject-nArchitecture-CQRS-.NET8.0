using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage;

public class _HomePageIntroComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}