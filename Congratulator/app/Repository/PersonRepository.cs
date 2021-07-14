using Congratulator.Interfaces;
using Congratulator.Models;
using Congratulator.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Repository
{
    public class PersonRepository : IPerson
    {

        private readonly AppDBContent appDBContent;

        public PersonRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Person> getAllPersons => appDBContent.Person.ToList();

        //Получение людей, у которых день рождения было, есть или будет в ближайшие 3 дня
        public IEnumerable<Person> getSomePersons => appDBContent.Person.Where(c => (((c.DayBirth - NowDate.nowDay) <= 3)&&(c.DayBirth- NowDate.nowDay >= 0)) && (c.MonthBirth == NowDate.nowMonth)).ToList();

        //Получение людей, у которых день рождения сегодня
        public IEnumerable<Person> getBirthdayPeople => appDBContent.Person.Where(c => (c.DayBirth == NowDate.nowDay) && (c.MonthBirth == NowDate.nowMonth)).ToList();

        public Person getOnePerson(int id) => appDBContent.Person.Find(id);
        

    }
}
