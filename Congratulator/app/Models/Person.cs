using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Models
{
    public class Person
    {
        [Key]
        [Required(ErrorMessage ="Поле пустое!")]
        public string name { get; set; }

        [Required(ErrorMessage = "Поле пустое!")]
        [Range(1,31, ErrorMessage ="Недопустимая дата!")]
        public int dayBirth { get; set; }

        [Required(ErrorMessage ="Поле пустое!")]
        [Range(1, 12, ErrorMessage = "Недопустимая дата!")]
        public int monthBirth { get; set; }

        public string category { get; set; }

        [Url]
        public string urlImg { get; set; }
    }
}
