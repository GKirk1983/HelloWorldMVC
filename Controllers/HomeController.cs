using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorldMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            AppMessage obj = new AppMessage()
            {
                Message = "Hello World!"
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(AppMessage obj)
                {
            ViewBag.Message = "Message changed.";
            return View(obj);
                }
    }
}
