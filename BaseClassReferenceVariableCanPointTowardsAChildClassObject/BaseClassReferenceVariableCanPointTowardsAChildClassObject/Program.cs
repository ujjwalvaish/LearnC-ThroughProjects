using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Base class Reference variable can point towards a child class object
//This is the base for ploymorphism
//This is one of the methods by which we can avoid method hiding and access parent class method
namespace BaseClassReferenceVariableCanPointTowardsAChildClassObject
{
    class Employee
    {
        public string Name;
        public string LastName;
        public void PrintFullName()
        {
            Console.WriteLine(Name + " " + LastName);
        }
    }

    class FullTimeEployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(Name + " " + LastName + "-Derived Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new FullTimeEployee(); //Focus on this line
            E1.Name = "Ujjwal";
            E1.LastName = "Vaish";
            E1.PrintFullName(); //Parent class method is accessed hee

            FullTimeEployee E2 = new FullTimeEployee();
            E2.Name = "Apoorv";
            E2.LastName = "Vaish";
            E2.PrintFullName(); //Deived class is accessed here , method hiding
            Console.ReadKey();
        }
    }
}
