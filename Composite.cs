using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Employee
    {
        private string name;
        private int salary;
        private List<Employee> employees;

        public Employee(string name,int salary)
        {
            this.name = name;
            this.salary = salary;
            employees = new List<Employee>();
        }

        public void Add(Employee e)
        {
            employees.Add(e);
        }
        public void Remove(Employee e)
        {
            employees.Remove(e);
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }

    }
}

//Demo
//{

//    Employee ceo = new Employee("CEO", 1000);
//    Employee sales = new Employee("sales", 500);
//    Employee marketing = new Employee("marketing", 2000);

//    ceo.Add(sales);
//    ceo.Add(marketing);

//    //foreach (employee e in ceo.getemployees())
//    //{
//    //    console.writeline(e);
//    //}

//    //Console.WriteLine(ceo);
//}