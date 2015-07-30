using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ExtensionMethods
{
     class Program
    {
        static void Main(string[] args)
        {
            int myint = 12345678;
            myint.DisplayDefiningAssembly(); //notice the method can be used directly , this is the case with all the static methods.
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembly();
            MyExtensions.DisplayDefiningAssembly(123);
            int a = MyExtensions.ReverseDigits(123);
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
     static class MyExtensions
     {
         public static void DisplayDefiningAssembly(this object obj)
         {
             Console.WriteLine("{0} lives here => {1}", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetName().Name);
         }

         public static int ReverseDigits(this int myNumber)
         {
             char[] myChar = myNumber.ToString().ToCharArray();
             Array.Reverse(myChar);
             string newNumber = new string(myChar);
             int reversedInt = int.Parse(newNumber);
             return reversedInt;

         }
     }

}
