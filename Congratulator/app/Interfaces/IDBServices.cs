using Congratulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Interfaces
{
    public interface IDBServices
    {

        void createPerson(Person person);

        void deletePerson(int id);

        void updatePerson(int id, Person person);

        IEnumerable<Person> orderByPerson(IEnumerable<Person> persons);
    }
}
