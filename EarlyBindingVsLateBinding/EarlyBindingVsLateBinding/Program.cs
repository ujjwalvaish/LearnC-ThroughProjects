using System;
using System.Reflection;

//early Binding is done 99.9% of the times
//Use late binding only when you are unsure of the class to be available at the runtime, else in all cases , use early binding
namespace EarlyBindingVsLateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is Early binding
           Customer C1 = new Customer();
           string fullName = C1.GetFullName("Ujjwal", "Vaish");
           Console.WriteLine("Fullname is {0}", fullName);

            //This is Late Binding
           Assembly executeAssembly = Assembly.GetExecutingAssembly();
           Type customerType = executeAssembly.GetType("EarlyBindingVsLateBinding.Customer");
           object customerObject = Activator.CreateInstance(customerType);
           MethodInfo method = customerType.GetMethod("GetFullName");
           string[] parameters = new string[2];
            parameters[0] = "Swati";
            parameters[1] = "Pandey";
            string fullname = (string)method.Invoke(customerObject, parameters);
            Console.WriteLine("Fullname is {0}", fullname);

           Console.ReadKey();
        }
    }

    public class Customer
    {
        public string GetFullName(string firstName, string lastName)
        {
            return (firstName + lastName);
        }
    }
}
