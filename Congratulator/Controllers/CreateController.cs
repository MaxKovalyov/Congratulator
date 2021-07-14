using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congratulator.Interfaces;
using Congratulator.Models;
using Congratulator.Service;
using Microsoft.AspNetCore.Mvc;

namespace Congratulator.Controllers
{
    public class CreateController : Controller
    {
        private readonly IDBServices dbServices;

        public CreateController(IDBServices dbServices)
        {
            this.dbServices = dbServices;
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            if(ModelState.IsValid)
            {
                dbServices.createPerson(person);
                return Redirect("~/AllBirthdays/Index");
            }
            else
            {
                return View(person);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
