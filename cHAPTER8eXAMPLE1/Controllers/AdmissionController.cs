using Microsoft.AspNetCore.Mvc;

namespace cHAPTER8eXAMPLE1.Controllers
{
    public class AdmissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
