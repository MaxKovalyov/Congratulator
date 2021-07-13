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

        private readonly IPerson _allPersons;

        public AllBirthdaysController(IPerson iallPersons)
        {
            _allPersons = iallPersons;
        }

        public IActionResult Index()
        {
            PersonListViewModel obj = new PersonListViewModel();
            obj.allPersons = _allPersons.getAllPersons;

            return View(obj);
        }
    }
}
