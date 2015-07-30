using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToStructsAndTypesOfInstanceDeclarations
{
    public struct Student
    {
        private int _id;
        private string _name;

        public int Id
        {
            get{return this._id;}
            set{this._id = value;}
        }
        public string Name
        {
          get{return this._name;}
         set{this._name = value;}
        }
        public Student(int ID, string NAME)
        {
            this._id = ID;
            this._name = NAME;
        }

        public void printDetails()
        {
            Console.WriteLine("Id is {0} and Name is {1}", this._id, this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student(101, "Ujjwal");
            S1.printDetails();
            Student S2 = new Student();
            S2.Id = 102;
            S2.Name = "Apoorv";
            S2.printDetails();
            Student S3 = new Student  ////Same declaration as S2 , just that it is cleaner and shorter, values can be passed even to default constructor like this
            {
                Name = "Udbhav",
                Id = 103
            };
            S3.printDetails();
            Console.ReadKey();
        }
    }
}
