using System;
using Microsoft.AspNetCore.Mvc;

namespace app_mvc.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}