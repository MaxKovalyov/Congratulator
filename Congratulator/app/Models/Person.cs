using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Congratulator.Models
{
    public class Person
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Enter Name")]
        [StringLength(30)]
        [Required(ErrorMessage = "The name must contain no more than 30 characters")]
        public string Name { get; set; }

        [Display(Name = "Enter day birth")]
        [Range(1,31)]
        [Required(ErrorMessage = "The number must be from 1 to 31")]
        public int DayBirth { get; set; }

        [Display(Name = "Enter month birth")]
        [Range(1, 12)]
        [Required(ErrorMessage = "The number must be from 1 to 12")]
        public int MonthBirth { get; set; }

        [Display(Name = "Enter category")]
        [StringLength(15)]
        [Required(ErrorMessage = "The name must contain no more than 15 characters")]
        public string Category { get; set; }

        [Display(Name = "Enter local url for image")]
        [StringLength(30)]
        [Required(ErrorMessage = "The name must contain no more than 30 characters")]
        public string UrlImg { get; set; }
    }
}
