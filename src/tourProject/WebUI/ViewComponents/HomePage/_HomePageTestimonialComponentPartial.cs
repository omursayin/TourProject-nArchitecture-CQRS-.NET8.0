using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage;

public class _HomePageTestimonialComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}