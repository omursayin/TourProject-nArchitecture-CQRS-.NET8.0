using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage;

public class _HomePageDestinationCountryComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
