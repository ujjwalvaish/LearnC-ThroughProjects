using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Interfaces only have declarations , they don't have definitions.
//Interface are public by default , explicit access modifiers are not allowed in interfaces
//Interfaces cannot contain fileds i.e variables , like int a;
//Interfaces can be inherited by a class
/*A class or a struct can inherit from more than 1 interfaces at a time(provided it provides definitions for all the methods)
, but a class cannot inherit from more than 1 class at the same time*/
//An interface can also inherit from other interfaces , a class that inherits this interface has to provide implementations for all the methods in the interface chain
/*we cannot create an instance of an interface but an interface reference variable can point to a derived class object, same thing as a child class reference variable
can point to the parent object */
namespace IntroductionToInterface
{
    interface ICustomer
    {
        void Print();
    }

    interface ICustomer2
    {
        void Print2();
    }

    interface ICustomer3 : ICustomer2
    {
        void Print3();
    }

    class DoubleInteface : ICustomer3
    {
        public void Print3()
        {
            Console.WriteLine("I am interface 3");
        }

        public void Print2()
        {
            Console.WriteLine("I am interface 2");
        }

    }

    class SingleInterface : ICustomer
    {
        public void Print()
        {
            Console.WriteLine("I am interface 1");
        }

        class Program
        {
            static void Main(string[] args)
            {
                ICustomer I1 = new SingleInterface();
                I1.Print(); //an interface reference variable can point to a derived class object

                DoubleInteface D1 = new DoubleInteface();
                D1.Print2();
                D1.Print3();
                Console.ReadKey();
            }
        }
    }
}