using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Declare the variable as private 
//Then declare its public method with get and set accessors
//Notice the "value" keyword
//Auto implementaion - whenever we do not have any restriction on a field, e.g its value can be anything , we do not need sech big blocks of get and set
//Look in the case of email id here
//You even dont need to declare that private variable
//just declare a public property and inclue get and set accessors without any condition
//the compiler will itself create a private variable of the same name which you can use later also (see S1.emailId")
namespace HowTousePropertiesInCsharp
{
    public class Student
    {
        private string _name;
        private int _id;
        private int _passingMarks = 40;


        public string emailID
        {
            get;
            set;
        }

        public int ID
        {
            set
            {
                if (value <= 0) //value keyword takes the value what we set to the variable, like S1.Id = 101, so value = 101
                {
                    throw new Exception("ID cannot be 0 or negative");
                }
                this._id = value;
            }
            get //while printing , get accessor is invoked
            {
                return this._id;
            }
        }

        public string name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or blank");
                }
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }
        public int passinMarks
        {
            get
            {
                return this._passingMarks;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.ID = 100;  //Just acting as a property , this calls the set accessor whwenver executed
            S1.name = "Ujjwal";
            Console.WriteLine("ID is {0}", S1.ID);
            Console.WriteLine("Welcome {0}", S1.name);
            Console.WriteLine("Passing marks = {0}", S1.passinMarks);
            S1.emailID = "ujjwalvaish@outlook.com";
            Console.WriteLine("email Id is {0}", S1.emailID);
            Console.ReadKey();
        }
    }
}
