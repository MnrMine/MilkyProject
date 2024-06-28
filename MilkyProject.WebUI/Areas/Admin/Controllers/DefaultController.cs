using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.Areas.Admin.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
    }
}
