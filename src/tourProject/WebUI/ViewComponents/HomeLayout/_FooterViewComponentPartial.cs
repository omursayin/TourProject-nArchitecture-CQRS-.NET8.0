using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomeLayout;

public class _FooterViewComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
