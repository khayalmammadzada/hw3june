using System;
namespace ClassLibrary
{
    public class Department
    {
        public string Name;
        public int EmployeeLimit;
        protected int _salarylimit;
        public Employee[] employees=new Employee[0];


        public void AddEmployee(Employee emp)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = emp;
        }
    }
}
