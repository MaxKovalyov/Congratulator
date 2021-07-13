using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congratulator.Interfaces;
using Congratulator.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Congratulator.Controllers
{
    public class BirthdayPeopleController : Controller
    {
        private readonly IPerson _birthdayPersons;

        public BirthdayPeopleController(IPerson ibirthdayPersons)
        {
            _birthdayPersons = ibirthdayPersons;
        }

        public IActionResult Index()
        {
            PersonListViewModel obj = new PersonListViewModel();
            obj.birthdayPersons = _birthdayPersons.getBirthdayPeople;

            return View(obj);
        }
    }
}
