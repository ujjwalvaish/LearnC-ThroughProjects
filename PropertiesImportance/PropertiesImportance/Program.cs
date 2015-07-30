using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// The members of a class should not be public as then anyone can alter them , or even set them to unacceptable values
//They should always be private 
//One way to reach to them , then is to make public getter() and setter() methods
namespace PropertiesImportance
{
    public class Student
    {
        private string _name; //shouldn't be null or empty
        private int _id;  //shouldn't be negative
        private int _passingmarks = 40; // user should not be able to set this , it should only be a read only value

        public void setname(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            else
            {
                this._name = name;
            }
        }

        public string getname()
        {
            return this._name;
        }

        public void setid(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Id cannot be 0 or empty");
            }
            else
            {
                this._id = id;
            }

        }
        public int getid()
        {
            return this._id;
        }
        public int getPassingMarks()
        {
            return this._passingmarks;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.setname("Ujjwal");
            Console.WriteLine("Name is {0}", S1.getname());
            S1.setid(108);
            Console.WriteLine("Id is {0}", S1.getid());
            Console.WriteLine("Passing marks are {0}", S1.getPassingMarks());
            Console.ReadKey();

            Student S2 = new Student();
            S2.setname(" ");
            S2.setid(-100);
            Console.ReadKey();
        }
    }
}
