using EF_test_01.Models;
using EF_test_01.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_test_01.Controllers
{
    public class PeopleController : Controller
    {
        public static PeopleViewModel database = new PeopleViewModel();
        public IActionResult ViewPeople()
        {                   
            return View(database);
        }


        [HttpPost]
        public IActionResult AddPerson(Person p)
        {
            if (ModelState.IsValid)
            {
                int lastId = database.PeopleList[database.PeopleList.Count - 1].Id;
                Person newPerson = new Person(lastId+1, p.Name,p.PhoneNumber, p.City);
                //Add the new person to the list
                database.PeopleList.Add(newPerson);
                return View("ViewPeople", database);
            }
            else
            {
                //Remove failed. Just return the view
                return View("ViewPeople", database);
            }
        }

        public IActionResult RemovePerson(int id)
        {
            //Logic
            if (ModelState.IsValid)
            {
                //Remove element with 
                var result = database.PeopleList.RemoveAll(x => x.Id == id);              
                return View("ViewPeople", database);
        }
            else
            {
                ModelState.Where(e => e.Value.Errors.Count > 0).ToList();
                //Remove failed. Just return the view
                return View("ViewPeople", database);
    }
}

        [HttpPost]
        public IActionResult Search(PeopleViewModel m)
        {
            if (!String.IsNullOrEmpty(m.SearchText))
            {
                var result = database.PeopleList.Where(q => (q.Name + " " + q.City)
                    .ToLower()
                    .Contains(m.SearchText.ToLower()))
                    .ToList();
                //Create a new instance of the viewmodel and send it to the view
                PeopleViewModel modelWithSearch = new PeopleViewModel();
                modelWithSearch.SearchText = m.SearchText;
                modelWithSearch.PeopleList = result;
                //m.PeopleList = result;
                return View("ViewPeople", modelWithSearch);
            }
            else
            {
                //Do nothing
                return View("ViewPeople", database);
            }
        }
    }
}
