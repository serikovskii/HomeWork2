using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessData(string name, int age)
        {
            var composedData = $"{name} - {age}";
            return Redirect("https://mail.ru");
        }
    }
}