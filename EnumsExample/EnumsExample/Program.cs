using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[2];
            customers[0] = new Customer()
            {
               Name = "Ujjwal",
               Gender = Gender.Male

            };
            customers[1] = new Customer()
            {
                Name = "Swati",
                Gender = Gender.Female

            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer's name is {0} and Gender is {1}", customer.Name, GetGender(customer.Gender));
            }
            Console.ReadKey();
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid";
            }
        }
    }


    public enum Gender 
    {
        Unknown,
        Male,
        Female
    }


    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; } 
    }
}
