using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.DataAccess;
using WebApplication3.Models;

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
        public ActionResult Index(string person, string date, string time, string name, string email, string phone)
        {
            using(var context = new ReserveContext())
            {
                var reserve = new Reserve();
                reserve.Person = person;
                reserve.Date = date;
                reserve.Time = time;
                reserve.Name = name;
                reserve.Email = email;
                reserve.Phone = phone;

                context.Reserves.Add(reserve);
                context.SaveChanges();
            }
            return View();
        }
    }
}