using Congratulator.Models;
using Congratulator.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Service
{
    public class CreatePerson
    {

        private readonly AppDBContent db;

        public CreatePerson(AppDBContent appDBContent)
        {
            db = appDBContent;
        }

        public void createPerson(Person person)
        {
            db.Person.Add(person);
            db.SaveChanges();
        }
    }
}
