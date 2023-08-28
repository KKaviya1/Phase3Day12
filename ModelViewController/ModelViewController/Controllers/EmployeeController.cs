using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelViewController.Models;

namespace ModelViewController.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee()
                {
                    ID=1,Name="Viya",Designation="Developer",Salary=46000.20,Doj=new DateTime(day:29,month:05,year:2023)
                },
                new Employee()
                 {
                    ID=2,Name="Priya",Designation="Tester",Salary=20000.20,Doj=new DateTime(day:19,month:05,year:2022)
                },
                 new Employee()
                 {
                    ID=3,Name="Praveen",Designation="Developer",Salary=40000.20,Doj=new DateTime(day:23,month:05,year:2023)
                },
                  new Employee()
                 {
                    ID=4,Name="Ramya",Designation="HR",Salary=70000.20,Doj=new DateTime(day:30,month:05,year:2023)
                },
            };
                  return View(listEmployees);
        }
    }
}