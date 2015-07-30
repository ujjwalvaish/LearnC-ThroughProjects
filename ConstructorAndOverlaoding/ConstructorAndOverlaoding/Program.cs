using System;

namespace ConstructorAndOverlaoding
{
    // In this , even if we provide no parameter to the constructor , it by default takes "no first name provide" and "no last name provided" as its parameters and functions normally.
    public class Customer
    {

        string fName = "";
        string lName = "";

        public Customer(string FirstName = "", string LastName = "")
        {
            this.fName = FirstName;
            this.lName = LastName;
        }

        public Customer()
            : this("No first name provided", "no last name provided")
        {
        }

        public void PrintFullName()
        {
            Console.WriteLine("Welcome {0}", this.fName + " " + this.lName);
        }

    }


    public class Caller
    {
        static void Main(string[] args)
        {

            Customer Person1 = new Customer("Ujjwal", "Vaish");

            Person1.PrintFullName();

            Console.ReadKey();

            Customer Person2 = new Customer();
            Person2.PrintFullName();

            Console.ReadKey();
        }

    }

}