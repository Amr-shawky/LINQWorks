using ProjectionAndFiltering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Filtering
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Example of filtering using Where  

            EmployeeInfo employeeInfo1  = new EmployeeInfo { Id = 1, Name = "Alice", Salary = 50000, Age = 30, DepartmentID = 1 };
            EmployeeInfo employeeInfo2 = new EmployeeInfo { Id = 2, Name = "Bob", Salary = 60000, Age = 35, DepartmentID = 2 };
            EmployeeInfo employeeInfo3 = new EmployeeInfo { Id = 3, Name = "Charlie", Salary = 70000, Age = 28, DepartmentID = 3 };
            EmployeeInfo employeeInfo4 = new EmployeeInfo { Id = 4, Name = "David", Salary = 80000, Age = 40, DepartmentID = 4 };
            EmployeeInfo employeeInfo5 = new EmployeeInfo { Id = 5, Name = "Eve", Salary = 90000, Age = 45, DepartmentID = 5 };

            var employee = new Employee();  
            employee.Add(employeeInfo1);
            employee.Add(employeeInfo2);
            employee.Add(employeeInfo3);
            employee.Add(employeeInfo4);
            employee.Add(employeeInfo5);

            //foreach (var employeeinfo in employee)
            //{
            //    Console.WriteLine($"Employee: {employeeinfo.Name}, Salary: {employeeinfo.Salary}");
            //}
            for (int i = 0; i < employee.Count(); i++)
            {
                var emp = employee[i];
                Console.WriteLine($"Employee {i + 1}: {emp.Name}, Salary: {emp.Salary}");
            }
        }
    }
}
