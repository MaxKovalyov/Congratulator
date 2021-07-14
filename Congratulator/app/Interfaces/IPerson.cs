using Congratulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Interfaces
{
    public interface IPerson
    {

        IEnumerable<Person> getAllPersons { get; }

        IEnumerable<Person> getSomePersons { get; }

        IEnumerable<Person> getBirthdayPeople { get; }

        Person getOnePerson(int id);

    }
}
