using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Classes that don't have implementations for all its members are called abstract classes
//A class that may not contain an abstract member , may also be termed as abstract , no errors (i.e it has all the members' implementations but still abstract)
//keyword abstract is used for the class as well as the member(s) that are abstract
//since they are incomplete , abstract classes cannot be instantiated
//They can only act as a base class for the classes that inherit them , child class hass to provide implementations for ALL the abstract members
//If the child class does not provide implementations for all the abstract members , then it should also be marked as abstract
//In order to give the implementation for an abstract method in the child class , "override" keyword should be used
//Abstract class cannot be sealed

namespace AbstractClass
{

  public abstract class Student
    {
        public abstract void PrintName();
    }

    class Program : Student
    {
        public override void PrintName()
        {
            Console.WriteLine("Abstract class inherited and method implemented");
        }
        static void Main(string[] args)
        {
            Program P1 = new Program();
            P1.PrintName();

            Student S1 = new Program();  //an abstract class reference variable can also point towards the child class object
            S1.PrintName();
            Console.ReadLine();
        }
    }
}
