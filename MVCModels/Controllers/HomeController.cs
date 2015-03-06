using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCModels.Models;

namespace MVCModels.Controllers
{
    public class HomeController : Controller
    {
        private Person[] _personData =
        {
            new Person {PersonId = 1, FirstName = "Adam", LastName = "Freeman", Role = Role.Admin},
            new Person {PersonId = 1, FirstName = "Derek", LastName = "Rivers", Role = Role.User},
            new Person {PersonId = 1, FirstName = "Jonny", LastName = "Rivers", Role = Role.User},
            new Person {PersonId = 1, FirstName = "Mark ", LastName = "Kennedy", Role = Role.Guest},

        };

        // GET: Home
        public ActionResult Index(int id = 1)
        {
            Person dataItem = _personData.FirstOrDefault(p => p.PersonId == id);

            return View(dataItem);
        }


        public ActionResult CreatePerson()
        {
            return View(new Person());
        }

        public ActionResult DisplaySummary([Bind(Prefix = "HomeAddress")]AddressSummary summary)
        {
            return View(summary);
        }

        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            return View("Index", model);
        }

        public ActionResult Names(string[] names)
        {
            names = names ?? new string[0];

            return View(names);
        }

        public ActionResult Address()
        {
            IList<AddressSummary> addresses = new List<AddressSummary>();
            UpdateModel(addresses);
            return View(addresses);
        }

        //public ActionResult Address(FormCollection formData)
        //{
        //    IList<AddressSummary> addresses = new List<AddressSummary>();

        //    if (TryUpdateModel(addresses, formData))
        //    {
                
        //    }
        //    else
        //    {
                
        //    }
      
     


        //    return View(addresses);
        //}
    }
}