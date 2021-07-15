using Congratulator.Interfaces;
using Congratulator.Models;
using Congratulator.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Repository
{
    public class DBServicesRepository : IDBServices
    {
        private readonly AppDBContent db;

        public DBServicesRepository(AppDBContent db)
        {
            this.db = db;
        }

        public void createPerson(Person person)
        {
            db.Person.Add(person);
            db.SaveChanges();
        }

        public void updatePerson(int id, Person person)
        {
            person.Id = id;
            db.Person.Update(person);
            db.SaveChanges();
        }

        public void deletePerson(int id)
        {
            Person obj = db.Person.Find(id);
            db.Person.Remove(obj);
            db.SaveChanges();
        }

        public IEnumerable<Person> orderByPerson(IEnumerable<Person> persons) => persons.OrderBy(c => c.DayBirth).ThenBy(c => c.MonthBirth);
    }
}
