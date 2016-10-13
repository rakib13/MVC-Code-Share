using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVC.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public string getMessage()
        {
            return "Hello World!!!";
        }

        public Customer getCustomerObj()
        {
            Customer customer = new Customer();
            customer.name = "Rakib";
            customer.age = 26;

            return customer;
        }

        public string getCustomerInfo()
        {
            Customer customer = new Customer();
            customer.name = "Rakib";
            customer.age = 26;

            return customer.name + " is "+ customer.age + " years old & the Random value is ";
        }

        [NonAction]
        public string getNonActionMethod()
        {
            return "THis is a non screen method.";
        }

        public ActionResult getView()
        {
            return View("MyView");
        }

        public ActionResult getSelectedView()
        {
            Random rnd = new Random();
            if (rnd.Next(1, 10) > 5)
            {
                return View("MaxView");
            }
            else
            {
                return View("MinView");
            }
        }
	}

    public class Customer
    {
        public string name { get; set; }
        public int age { get; set; }
    }
}