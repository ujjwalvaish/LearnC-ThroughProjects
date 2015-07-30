using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Struct is a value type, and Class is a reference type
//struct is stored in stack
//Class is stored in heap
//when I say int i = 10 ; int is actually an alias for system.int32 which is a structure by itself
//when we say Customer C1 = new customer() , the left hand side C1 by itself is an object reference variable, the right side is the actual Customer object
//so object reference variable is stored as a stack where as actual object is stored as a heap
//object reference variable is just a pointer to the actual object
//Value types hold there value at a place where they are declared where as reference types hold a reference to an object in the memory
//so i , j are value types , they store their values
//C1 is a reference type , it holds the reference to the object C1
//value types are destroyed immediately after the scope is lost
//for reference types , only the reference variable is lost aftr the scope is lost, the object is later destroyed by the garbage collector
/*when we copy a class to another class, we only get a copy of the reference variable.Both the reference variables point to the same object on the heap, so operations on one 
variable will affect the values stored in the other variable*/
//when you create a copy of the struct , a new copy gets created and modifications on one struct will not affect the values contained by other struct
//structs can't have destructors but classes can have them
//structs can have parameterized constructors but they can't EXPLICITLY have parameter less constructor
//Structs can't inherit from another class
//Both structs and classes can inherit from an interface
//Structs and classes cannot inherit from a struct , struct is a sealed type
//If you mark a class as "sealed", then it cannot be inherited i.e it cannot act as a base class for another class
//structs are by default , sealed types
namespace DifferenceBetweenStructAndClass
{
    public class Customer
    {
        public string _name
        {
            get;
            set;
        }
        public int _id
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = i;
            j++;   //i and j are structs ,copy of the value is created.
            Console.WriteLine("i = {0} and j = {1}", i, j);

            Customer C1 = new Customer()
            {
                _id = 101,
                _name = "Ujjwal"
            };
            Customer C2 = C1; // not creating the copy of  vlaue , but a copy of the refence variable

            C2._name = "John";
            Console.WriteLine("C1._name = {0} and C2._name = {1}", C1._name, C2._name);



            Console.ReadKey();
        }
    }
}
