using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;
public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
