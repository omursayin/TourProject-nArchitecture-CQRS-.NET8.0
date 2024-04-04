using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomeLayout;

public class _HeadViewComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
