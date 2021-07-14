using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congratulator.Interfaces;
using Congratulator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Congratulator.Controllers
{
    public class UpdateController : Controller
    {
        private readonly IDBServices dbServices;
        private readonly IPerson _onePerson;
        private static int _id;

        public UpdateController(IPerson onePerson, IDBServices dbServices) {
            _onePerson = onePerson;
            this.dbServices = dbServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            _id = id;
            Person obj = new Person();
            if (id != 0)
            {
                obj = _onePerson.getOnePerson(id);
                ViewData["Name"] = obj.Name;
                ViewData["DayBirth"] = obj.DayBirth;
                ViewData["MonthBirth"] = obj.MonthBirth;
                ViewData["Category"] = obj.Category;
                ViewData["UrlImg"] = obj.UrlImg;

            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            if(ModelState.IsValid)
            {
                dbServices.updatePerson(_id, person);
                return Redirect("~/AllBirthdays/Index");
            }
            else
            {
                return View(person);
            }
        }
    }
}
