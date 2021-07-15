using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congratulator.Interfaces;
using Congratulator.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Congratulator.Controllers
{
    public class AllBirthdaysController : Controller
    {

        private readonly IDBServices dbServices;
        private readonly IPerson _allPersons;

        public AllBirthdaysController(IPerson iallPersons, IDBServices dbServices)
        {
            this.dbServices = dbServices;
            _allPersons = iallPersons;
        }

        public IActionResult Index()
        {
            PersonListViewModel obj = new PersonListViewModel();
            obj.allPersons = dbServices.orderByPerson(_allPersons.getAllPersons);

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
