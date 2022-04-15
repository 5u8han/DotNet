using Microsoft.AspNetCore.Mvc;
using webapp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
   
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }

            return View(model);
        }
    }

    //public IActionResult Index(ErrorViewModel model)
    //    {
    //        ViewBag.Name = "Subhan";
    //        ViewBag.FV =0;
    //        ViewBag.Message = "Welcome to Download More Ram .com";
    //        return View();
    //    }

    //    public IActionResult Privacy()
    //    {
    //        return View();
    //        ViewBag.Message = "We take RAM very seriously";
    //    }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }
    //}
}