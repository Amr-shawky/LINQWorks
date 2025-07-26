using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionAndFiltering
{
    public class Employee : IEnumerable<Employee>
    {
        private static List<Employee> _employees = new List<Employee>();
        public Employee()
        {
            _employees.Add(this);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public IEnumerator GetEnumerator()
        {
            return _employees.GetEnumerator();
        }

        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
            return _employees.GetEnumerator();
        }
    }
}
