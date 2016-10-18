using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstMVC.DataAccessLayer;

namespace MyFirstMVC.Models
{
    public class EmployeeBusinessLayer
    {
        Random rndSalary = new Random();
        public List<Employee> GetEmployees()
        {

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                Employee emp = new Employee();
                emp.FirstName = "johnson";
                emp.LastName = " fernandes";
                emp.Salary = rndSalary.Next(12000, 20000);
                employees.Add(emp);
            }

            return employees;
        }

        public List<Employee> getEmployeeList()
        {
            SalesERPDAL salseDl = new SalesERPDAL();
            return salseDl.Employees.ToList();
        }
    }
}