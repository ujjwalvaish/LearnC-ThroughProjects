using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;




namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Marks2 = 100;
            s1.CalculateNewPercent();
            
            Console.WriteLine("{0},{1},{2},{3}",s1.Name, s1.Marks1.ToString(), s1.Marks2.ToString(), s1.Percent.ToString());
            Student s2 = new Student("Swati", 0, 80);
            Console.WriteLine("{0},{1},{2},{3}", s2.Name, s2.Marks1.ToString(), s2.Marks2.ToString(), s2.Percent);
            Console.WriteLine();
            

            
            Console.ReadKey();
        }
    }
    public class Student
    {
        private string name;
        private int marks1;
        private int marks2;
        private float percent;

       
        
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Please write a shorter Name");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Marks1
        {
            get { return marks1; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    marks1 = value;
                }
                else
                {
                    Console.WriteLine("Invalid Marks1");
                }
            }
        }
        public int Marks2
        {
            get { return marks2; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    marks2 = value;
                }
                else
                {
                    Console.WriteLine("Invalid Marks2");
                }
            }

        }
        public float Percent
        {
            get { return percent; }
            
        }
       

        public Student(string nm = "NoName", int m1= 50, int m2=50)
        {
            Name = nm;
            Marks1 = m1;
            Marks2 = m2;
            this.percent = (m1 + m2) / 2;           
        }

        public Student()
            : this("NoName", 50, 50)
        {
        }
        public void CalculateNewPercent()
        {
            this.percent = (this.marks1 + this.marks2) / 2;
        }
    }
}