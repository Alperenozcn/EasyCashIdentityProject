using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartia:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
