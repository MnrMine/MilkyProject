using Microsoft.AspNetCore.Mvc;
using MilkyProject.WebUI.Dtos.Gallery;

namespace MilkyProject.WebUI.ViewComponents
{
    public class _UILayoutNewsletterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new CreateGalleryDto());
        }
    }
    
    }

