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

        private readonly IPerson _somePersons;

        public HomeController(IPerson isomePersons)
        {
            _somePersons = isomePersons;
        }
        public IActionResult Index()
        {
            PersonListViewModel obj = new PersonListViewModel();
            obj.somePersons = _somePersons.getSomePersons;
            
            return View(obj);
        }
    }
}
