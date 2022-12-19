using Microsoft.AspNetCore.Mvc;
using tp1.data;

namespace tp1.Controllers
{
    public class EmployeeController : Controller
    {
        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
        //[Route("Home/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }

}
