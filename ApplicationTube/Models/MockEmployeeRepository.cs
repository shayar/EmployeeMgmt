using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTube.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Abxc", Department = "HR", Email = "shayar@uba-solutions.com"},
                new Employee() {Id = 2, Name = "Abc", Department = "IT", Email = "shayar@uba-solutions.com"},
                new Employee() {Id = 3, Name = "Cat", Department = "IT", Email = "shayar@uba-solutions.com"},
                new Employee() {Id = 4, Name = "Dog", Department = "Operation", Email = "shayar@uba-solutions.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
