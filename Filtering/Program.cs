using ProjectionAndFiltering;
using System;
using System.ComponentModel.DataAnnotations;

namespace Filtering
{
    public class Program
    {
        static void Main(string[] args)
        {
            // what is the filtering and projection in LINQ?
            // Filtering in LINQ is the process of selecting a subset of elements
            // from a collection based on specific criteria.
            // It allows you to retrieve only those elements that meet certain conditions.

            // Projection in LINQ is the process of transforming each element of a collection   
            // into a new form, often by selecting specific properties or fields.

            // Common filtering & projection methods in LINQ include:
            // - Where: Filters elements based on a predicate.
            // - OfType: Filters elements based on their type.
            // - Select: Projects each element of a sequence into a new form.
            // - SelectMany: Projects each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence.
            // Example of filtering using Where
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Salary = 50000, Age = 30, Department = "HR" },
                new Employee { Id = 2, Name = "Bob", Salary = 60000, Age = 35, Department = "IT" },
                new Employee { Id = 3, Name = "Charlie", Salary = 70000, Age = 28, Department = "Finance" },
                new Employee { Id = 4, Name = "David", Salary = 80000, Age = 40, Department = "IT" },
                new Employee { Id = 5, Name = "Eve", Salary = 90000, Age = 45, Department = "HR" }
            };
            foreach (var employee in employees.Where(e => e.Salary > 60000))
            {
                Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
            }
        }
    }
}
