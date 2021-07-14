using Congratulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.ViewModels
{
    public class PersonListViewModel
    {
        public IEnumerable<Person> allPersons { get; set; }

        public IEnumerable<Person> somePersons { get; set; }

        public IEnumerable<Person> birthdayPersons { get; set; } 

        public Person onePerson { get; set; }
    }
}
