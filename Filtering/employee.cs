using ProjectionAndFiltering;
using System.Collections;
using System.Collections.Generic;

public class Employee : IEnumerable<EmployeeInfo>
{
    private static List<EmployeeInfo> _employees = new();

    public Employee()
    {

    }
    public EmployeeInfo this[int index]
    {
        get => _employees[index];
    }

    public void Add(EmployeeInfo emp)
    {
        _employees.Add(emp);
    }
    public IEnumerator<EmployeeInfo> GetEnumerator()
    {
        foreach (var employee in _employees)
        {
            yield return employee;
        }


        //return new EmployeeInfoEnumerator(_employees);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    //private class EmployeeInfoEnumerator : IEnumerator<EmployeeInfo>
    //{
    //    private readonly List<EmployeeInfo> _employees;
    //    private int _currentIndex = -1;
    //    public EmployeeInfoEnumerator(List<EmployeeInfo> employees)
    //    {
    //        _employees = employees;
    //    }
    //    public EmployeeInfo Current => _employees[_currentIndex];

    //    object IEnumerator.Current => Current;

    //    public void Dispose()
    //    {
    //    }

    //    public bool MoveNext()
    //    {            
    //        return ++_currentIndex < _employees.Count;
    //    }

    //    public void Reset()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

