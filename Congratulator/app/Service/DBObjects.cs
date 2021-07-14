using Congratulator.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Service
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if(!content.Person.Any())
            {
                content.AddRange(
                    new Person
                    {
                        Name = "Yuki Asuna",
                        DayBirth = 14,
                        MonthBirth = 7,
                        Category = "Friends",
                        UrlImg = "/img/asuna.jpg"
                    },
                    new Person
                    {
                        Name = "Geralt iz Rivii",
                        DayBirth = 16,
                        MonthBirth = 7,
                        Category = "Professors",
                        UrlImg = "/img/geralt.jpg"
                    },
                    new Person
                    {
                        Name = "Kakoi-to chel",
                        DayBirth = 8,
                        MonthBirth = 7,
                        Category = "Familiars",
                        UrlImg = "/img/1.jpg"
                    },
                    new Person
                    {
                        Name = "Levy Leonhart",
                        DayBirth = 12,
                        MonthBirth = 7,
                        Category = "Professors",
                        UrlImg = "/img/levy.jpg"
                    },
                    new Person
                    {
                        Name = "Pokemon Pikachu",
                        DayBirth = 13,
                        MonthBirth = 7,
                        Category = "Familiars",
                        UrlImg = "/img/pikachu.jpg"
                    },
                    new Person
                    {
                        Name = "Kristiano Ronaldo",
                        DayBirth = 8,
                        MonthBirth = 8,
                        Category = "Friends",
                        UrlImg = "/img/ronaldo.jpg"
                    },
                    new Person
                    {
                        Name = "Some Dog",
                        DayBirth = 1,
                        MonthBirth = 10,
                        Category = "Friends",
                        UrlImg = "/img/dog.jpg"
                    },
                    new Person
                    {
                        Name = "Ciri Swallow",
                        DayBirth = 13,
                        MonthBirth = 7,
                        Category = "Family",
                        UrlImg = "/img/ciri.jpg"
                    },
                    new Person
                    {
                        Name = "Remuru Tempest",
                        DayBirth = 13,
                        MonthBirth = 7,
                        Category = "Family",
                        UrlImg = "/img/sliz.jpg"
                    }
                ) ;
            }

            content.SaveChanges();

            
        }
    }
}
