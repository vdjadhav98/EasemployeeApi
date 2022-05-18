using EmployeeAttendanceSystem.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace EmployeeAttendanceSystem.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {
        public static readonly List<Employee> employees = new List<Employee>()
{
new Employee {EmployeeId ="EID01", EmployeeName="Prathyusha",EmployeeGender="Female",EmployeeEmail="prathyusha3@gmail.com",EmployeeContact=7036970496,EmployeeUsername="Prathyusha_3",EmployeePassword="Rahul18"},



new Employee {EmployeeId ="EID02",EmployeeName="Pavan",EmployeeGender="Male",EmployeeEmail="pavan16@gmail.com",EmployeeContact=7997030869,EmployeeUsername="Pavan_16",EmployeePassword="Pavan123"},
};




        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return employees;
        }



        public async Task<Employee> GetEmployeeById(string employeeId)
        {
            return employees.SingleOrDefault(a => a.EmployeeId == employeeId);
        }



        public async Task<Employee> CreateEmployee(Employee employeeObj)
        {
            //string password = null;
            //this.CreatePasswordHash(employeeObj.EmployeePassword, out password);
            //employeeObj.EmployeePassword = password;
            employees.Add(employeeObj);
            return employeeObj;
        }



        public async Task<Employee> DeleteEmployee(string employeeId)
        {
            var result = employees.SingleOrDefault(a => a.EmployeeId == employeeId);
            if (result != null)
            {
                employees.Remove(result);

            }
            return result;
        }



        public async Task<Employee> UpdateEmployee(Employee employeeObj)
        {
            var result = employees.SingleOrDefault(a => a.EmployeeId == employeeObj.EmployeeId);



            if (result != null)
            {
                result.EmployeeName = employeeObj.EmployeeName;
                result.EmployeeGender = employeeObj.EmployeeGender;
                result.EmployeeEmail = employeeObj.EmployeeEmail;
                result.EmployeeContact = employeeObj.EmployeeContact;
                result.EmployeeUsername = employeeObj.EmployeeUsername;
                result.EmployeePassword = employeeObj.EmployeePassword;

                return result;
            }
            return null;
        }
    }
}