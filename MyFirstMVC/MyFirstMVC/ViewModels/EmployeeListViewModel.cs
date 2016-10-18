using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVC.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> employeeList { get; set; }
        public string userName { get; set; }
    }
}