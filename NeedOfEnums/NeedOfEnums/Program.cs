using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeedOfEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Ujjwal",
                Gender = 2
            };

            Console.WriteLine("Student's name is  {0}, and gender is {1}", student.Name,IdentifyGender(student.Gender));
            Console.ReadKey();
        }
            
            public static string IdentifyGender(int gender)
            {
            switch (gender)
            {
                case 0: return "unknown";
                case 1: return "female";
                case 2: return "male";
                default: return "invalid";
            }
            }
     }

  


    public class Student
    {
        public string Name { get; set; }
        public int Gender { get; set; }    
    }

}

