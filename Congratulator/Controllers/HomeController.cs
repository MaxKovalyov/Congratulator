using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congratulator.Interfaces;
using Congratulator.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Congratulator.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDBServices dbServices;
        private readonly IPerson _somePersons;

        public HomeController(IPerson isomePersons, IDBServices dbServices)
        {
            this.dbServices = dbServices;
            _somePersons = isomePersons;
        }
        public IActionResult Index()
        {
            PersonListViewModel obj = new PersonListViewModel();
            obj.somePersons = dbServices.orderByPerson(_somePersons.getSomePersons);
            
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id != 0)
            {
                dbServices.deletePerson(id);
            }
            return Redirect("~/AllBirthdays/Index");
        }
    }
}
