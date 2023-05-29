using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class SiteController:Controller{
      public IActionResult Index2(){
        return View("Index2");
      }
    }
}