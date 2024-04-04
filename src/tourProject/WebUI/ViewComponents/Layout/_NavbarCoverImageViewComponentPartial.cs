using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Layout;

public class _NavbarCoverImageViewComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
