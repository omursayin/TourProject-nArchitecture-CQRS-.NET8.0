using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage;

public class _HomePageDestinationsComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
