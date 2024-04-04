using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomeLayout;

public class _NavbarViewComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
