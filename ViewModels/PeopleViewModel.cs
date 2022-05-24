using EF_test_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_test_01.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            CreateStartingData();
            //PersonFactory = new CreatePersonViewModel();
        }
        public string PageTitle { get; set; } = "List of people";
        public string SearchText { get; set; } = "";
        public List<Person> PeopleList { get; set; } 

        private void CreateStartingData()
        {
            PeopleList = new List<Person>() {
            new Person(1, "Josh", "123 456", "Abu Dabi"),
            new Person(2, "Miguel", "234 567", "San Jose"),
            new Person(3, "Andreas", "345 678", "Stockholm")  };
        }
    }
}
