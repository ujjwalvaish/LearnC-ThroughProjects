using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//How a list is declared and used 
//Here , only one kind of promoting criteria is used , if some other complany wanted to promote its employees using some other criteria , it will have to change its code
//Here , delegates come into picture, they provide flexibility
namespace IntroductionToListsAndNeedForDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { id = 101, name = "Ujjwal", salary = 60000, experience = 1 });
            emplist.Add(new Employee() { id = 102, name = "Swati", salary = 70000, experience = 4});
            emplist.Add(new Employee() { id = 103, name = "Aashima", salary = 60000, experience = 4 });
            emplist.Add(new Employee() { id = 104, name = "Bharti", salary = 80000, experience = 5 });

            Employee.PromoteEmployee(emplist);
            Console.ReadKey();

        }
    }

    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }

        public static void PromoteEmployee(List<Employee> EmployeeList)
        {
            foreach (Employee employee in EmployeeList)
            {
                if (employee.experience >=4)
                {
                    Console.WriteLine("{0} is promoted",employee.name);
                }
            }
        }
    }
}
