using MyFirstMVC.Models;
using MyFirstMVC.ViewModels;
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
            Employee emp = new Employee();
            emp.FirstName = "Rakib";
            emp.LastName = "Omar";
            emp.Salary = 1700;

            ViewData["Employee"] = emp;

            return View("MyView",emp);
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

        public ActionResult getEmployeeViewModel()
        {
            Employee emp = new Employee();
            emp.FirstName = "Rakib";
            emp.LastName = "Omar";
            emp.Salary = 16000;

            EmployeeViewModel vmEmp = new EmployeeViewModel() ;
            vmEmp.employeeName = emp. FirstName + " " + emp. LastName;
            vmEmp.Salary = emp. Salary. ToString("C") ;
            if(emp. Salary>15000)
            {
            vmEmp. SalaryColor="yellow";
            }else
            {
            vmEmp. SalaryColor = "green";
            }
            vmEmp.UserName = "Admin";
            return View("getViewbyViewModel", vmEmp);
        }

        public ActionResult getEmployeeListView()
        {
            EmployeeListViewModel empList = new EmployeeListViewModel();

            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();

            List<Employee> employees = empBL.GetEmployees();

            List<EmployeeViewModel> empModel = new List<EmployeeViewModel>();

            foreach(Employee emp in employees)
            {
                EmployeeViewModel empV = new EmployeeViewModel();
                empV.employeeName = emp.FirstName + " " + emp.LastName;
                if (emp.Salary > 15000)
                {
                    empV.Salary = emp.Salary.ToString("C");
                    empV.SalaryColor = "yellow";
                }
                else
                {
                    empV.Salary = emp.Salary.ToString("C");
                    empV.SalaryColor = "green";
                }
                empModel.Add(empV);
            }
            empList.employeeList = empModel;
            empList.userName = "Rakib";
            return View("EmployeeListView", empList);
        }
	}

    public class Customer
    {
        public string name { get; set; }
        public int age { get; set; }
    }
}