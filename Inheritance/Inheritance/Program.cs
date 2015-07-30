using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Syntax: public class derivedclassName : ParentclassName
// one derived class can only inherit one parent class, multi-level inheritance is possible though.
// C# does not support multiple class inheritance but supports multiple interface inheritance
//Base classes are automatically instantiated before derived classes and their constructors are called before automatically

namespace Inheritance
{
    public class Employee
    {
       
           public string name;
            public string id;
            public void PrintNameAndId()
            {
                Console.WriteLine("Name is {0}", name);
                Console.WriteLine("Id is {0}", id);
            }
    }


    public class FullTimeEmployee : Employee
    {
       public int SalaryPerYear;
       public void PrintSalaryPerYear()
    {
        Console.WriteLine(SalaryPerYear);
        }
    }

    public class ComputerFullTimeEmployee : FullTimeEmployee
    {
       public int NoOfHoursPerDay;
    }

    class Program
    {
         static void Main(string[] args)
         {
             ComputerFullTimeEmployee Raju = new ComputerFullTimeEmployee();
             Raju.NoOfHoursPerDay = 5;
             Raju.name = "Raju";
             Raju.id = "Raju707";
             Raju.SalaryPerYear = 500000;
             Raju.PrintNameAndId();
             Raju.PrintSalaryPerYear();
             Console.ReadKey();
         }

    }

}



