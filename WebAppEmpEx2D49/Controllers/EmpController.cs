using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppEmpEx2D49.Models;

namespace WebAppEmpEx2D49.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee(){EId=101,EName="Sarika",EDesig="Developer",EDoj=DateTime.Parse("22/10/2013")},
                new Employee(){EId=103,EName="Shekhar",EDesig="Tester",EDoj=DateTime.Parse("03/06/2011")},
                new Employee(){EId=115,EName="Amar",EDesig="Manager",EDoj=DateTime.Parse("15/12/2016")},
                new Employee(){EId=121,EName="Neha",EDesig="HR",EDoj=DateTime.Parse("30/01/2016")},
                new Employee(){EId=126,EName="Priya",EDesig="Developer",EDoj=DateTime.Parse("12/12/2012")}
            };
            return View(empList);
        }
    }
}
