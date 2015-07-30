using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//This program is a continuation to the "Need for Delegates" program
//the end-user will always(if at all) change the code in the main() 
//By using delegates , we can make our program to call the function in the main() where our actual logic is defined
//So , the actual logic gets shifted to the main() method , instead going elsewhere
namespace ConsoleApplication1
{
    class UseOfDelegatesJustified
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { id = 101, name = "Ujjwal", salary = 50000, experience = 1 });
            empList.Add(new Employee { id = 102, name = "Swati", salary = 60000, experience = 2 });
            empList.Add(new Employee { id = 103, name = "Niki", salary = 50000, experience = 3 });
            empList.Add(new Employee { id = 104, name = "Bharti", salary = 60000, experience = 4 });

            IsPromotable isHe = new IsPromotable(Promote);
            Employee.PromoteEmployee(empList,isHe);

            Console.ReadKey();
        }

            public static bool Promote(Employee emp)
            {
                if (emp.salary > 20000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

       

        public delegate bool IsPromotable(Employee emp);


        public class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public int salary { get; set; }
            public int experience { get; set; }

            public static void PromoteEmployee(List<Employee> emploList,IsPromotable isPromotable)
            {
                foreach (Employee employee in emploList )
                {
                    if (isPromotable(employee))
                    {
                        Console.WriteLine("{0} is promoted", employee.name);
                    }
                }
            }
        }
    }
