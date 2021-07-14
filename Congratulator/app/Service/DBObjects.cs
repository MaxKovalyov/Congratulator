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
                        name = "Yuki Asuna",
                        dayBirth = 14,
                        monthBirth = 7,
                        category = "Friends",
                        urlImg = "/img/asuna.jpg"
                    },
                    new Person
                    {
                        name = "Geralt iz Rivii",
                        dayBirth = 16,
                        monthBirth = 7,
                        category = "Professors",
                        urlImg = "/img/geralt.jpg"
                    },
                    new Person
                    {
                        name = "Kakoi-to chel",
                        dayBirth = 8,
                        monthBirth = 7,
                        category = "Familiars",
                        urlImg = "/img/1.jpg"
                    },
                    new Person
                    {
                        name = "Levy Leonhart",
                        dayBirth = 12,
                        monthBirth = 7,
                        category = "Professors",
                        urlImg = "/img/levy.jpg"
                    },
                    new Person
                    {
                        name = "Pokemon Pikachu",
                        dayBirth = 13,
                        monthBirth = 7,
                        category = "Familiars",
                        urlImg = "/img/pikachu.jpg"
                    },
                    new Person
                    {
                        name = "Kristiano Ronaldo",
                        dayBirth = 8,
                        monthBirth = 8,
                        category = "Friends",
                        urlImg = "/img/ronaldo.jpg"
                    },
                    new Person
                    {
                        name = "Some Dog",
                        dayBirth = 1,
                        monthBirth = 10,
                        category = "Friends",
                        urlImg = "/img/dog.jpg"
                    },
                    new Person
                    {
                        name = "Ciri Swallow",
                        dayBirth = 13,
                        monthBirth = 7,
                        category = "Family",
                        urlImg = "/img/ciri.jpg"
                    },
                    new Person
                    {
                        name = "Remuru Tempest",
                        dayBirth = 13,
                        monthBirth = 7,
                        category = "Family",
                        urlImg = "/img/sliz.jpg"
                    }
                ) ;
            }

            content.SaveChanges();

            
        }
    }
}
