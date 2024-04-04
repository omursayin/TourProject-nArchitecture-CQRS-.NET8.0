using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomeLayout;

public class _ScriptsViewComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
