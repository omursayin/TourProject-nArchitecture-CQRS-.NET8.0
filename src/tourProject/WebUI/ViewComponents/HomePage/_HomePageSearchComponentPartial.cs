using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage;

public class _HomePageSearchComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
