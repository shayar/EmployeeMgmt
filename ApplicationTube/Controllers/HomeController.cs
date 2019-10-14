using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationTube.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationTube.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public ViewResult Details()
        {
            Employee employee = _employeeRepository.GetEmployee(1);
            return View(employee);
        }
    }
}