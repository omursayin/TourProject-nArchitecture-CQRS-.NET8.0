using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomeLayout;

public class _HomePageCoverViewComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
