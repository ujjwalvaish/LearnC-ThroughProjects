using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Delegate is a type safe function pointer.
//A delegate is declared just as a method but , with the delegate keyword.
//A delegate can point to a method with a similar signature
//When the delegate is called , it will point towards the method , and the method will get invoked . Why don't we call the method directly ? Delegate is very flexible(Later)
//To make a delegate point to a method , you have to make an instance of the delegate (just like a class)
//while creating the instance , a delegate will contain the name of the method it points to in the constructor parenthesis , just the name.
//The method should have the same return type and pass the same type of parameters that is why delegates are "type safe"
//A delegate is called just like a function . like NameOfDelegate(argument(s));
//Notice that the method is static here . why ?? (look for it)

namespace IntroductionToDelegates
{
    public delegate void HelloMethodPointer(string Name);
    class Program
    {
        static void Main(string[] args)
        {
           
        HelloMethodPointer H1 = new HelloMethodPointer(HelloMethod);
         H1("Ujjwal");
         Console.ReadKey();
        }
        public static void HelloMethod(string name)
                {
                    Console.WriteLine("Hello {0}",name);
                }
    }
}
