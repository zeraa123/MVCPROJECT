using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers;

    public class ToDoController : Controller
    {
        public IActionResult Index(){
            return View("Index");
        }
    }
