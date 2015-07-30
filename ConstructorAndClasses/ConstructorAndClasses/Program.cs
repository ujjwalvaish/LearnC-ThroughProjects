using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorAndClasses
{
    class Customer
    {
        String fname;
        String lname;

        public Customer(String FirstName, String LastName) //This is a constructor , same name as a class , called everytime an instance of class is created , never has a return type
        {
            this.fname = FirstName; // this keyword means the instance of this class
            this.lname = LastName;
        }

        
        public void WriteFullName()
        {
            Console.WriteLine("Full Name is {0}",this.fname + " " + this.lname);
        }

        ~Customer() //This is a destructor , used to release the resource of a class when the work is done , called automatically , never has a return type or parameters
        {
            // Clean up code goes here
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Customer C1 = new Customer("Ujjwal", "Vaish");
            C1.WriteFullName();


            Console.ReadKey();
        }
        
    }
}