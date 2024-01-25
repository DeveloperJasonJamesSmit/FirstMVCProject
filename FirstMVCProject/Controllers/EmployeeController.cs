using FirstMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employeeList = new List<Employee>();
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Jason";
            employee.Salary = 45000;
            employeeList.Add(employee);
            Employee emp2 = new Employee();
            emp2.ID = 2;
            emp2.Name = "James";
            emp2.Salary = 65000;
            employeeList.Add(emp2);
            ViewData["Age"] = 20;
            ViewBag.Job = "Engineer";
            string company2 = "OAK";
            TempData["company"] = company2;
            return View(employeeList);
            
        }

        public JsonResult GetDateWithJSON()
        {
            string JSONDate = DateTime.Today.ToShortDateString();
            return Json(JSONDate);
        }

        public ActionResult AddEmployee()
        {
            Employee emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            string textValue = "";
            if (ModelState.IsValid)
                textValue = "Model state is valid";
            else
                textValue = "Model state is not valid";
            return View();
        }

        public ActionResult UpdateEmployee()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            string company = (string)TempData["company"];
            employee.Name = company;
            employee.Salary = 55000;

            return View(employee);

        }

        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            return View(employee);
        }
    }
}