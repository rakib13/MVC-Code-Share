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

        public Customer getCustomerInfo()
        {
            Customer customer = new Customer();
            customer.name = "Rakib";
            customer.age = 26;

            return customer;
        }
	}

    public class Customer
    {
        public string name { get; set; }
        public int age { get; set; }
    }
}