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

        }

        public void deletePerson(int id)
        {
            Person obj = db.Person.Where(c => c.Id == id).FirstOrDefault();
            db.Person.Remove(obj);
            db.SaveChanges();
        }
    }
}
