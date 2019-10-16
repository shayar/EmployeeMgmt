using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationTube.Models;
using ApplicationTube.ViewModels;
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
        public IActionResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}