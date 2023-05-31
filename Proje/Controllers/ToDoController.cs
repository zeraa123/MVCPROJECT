using Microsoft.AspNetCore.Mvc;
using Proje.Models;

namespace Proje.Controllers;

    public class ToDoController : Controller
    {
        public IActionResult Index2(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index2([FromForm]Candidate model){
            Repository.Add(model);
            return View("FeedBack",model);
        }
    }
