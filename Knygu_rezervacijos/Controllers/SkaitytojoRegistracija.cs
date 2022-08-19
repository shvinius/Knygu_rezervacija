using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Knygu_rezervacijos.Controllers
{
    public class SkaitytojoRegistracija : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
