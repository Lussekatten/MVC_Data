using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_test_01.Models
{
    public class Person
    {
        public Person()
        { }
        public Person(int id, string name, string phone, string city)
        {
            Id = id;
            Name = name;
            PhoneNumber = phone;
            City = city;
        }
        public int Id { get; set; }

        [Display(Name = "Förnamn och eftrnamn: ")]
        [Required(ErrorMessage = "Du måste ange ett namn")]
        public string Name { get; set; }

        [Display(Name = "Telefon nr: ")]
        [Required(ErrorMessage = "Du måste ange ett telefon nummer")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Du måste ange en stad")]
        [Display(Name = "Stad")]
        public string City { get; set; }
    }
}
