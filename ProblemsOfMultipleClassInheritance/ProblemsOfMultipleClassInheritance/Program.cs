using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Diamond problem - A has a virtual method , B,C overrides it , D inherits B,C but does not override the method.
namespace ProblemsOfMultipleClassInheritance
{
    public class A
    {
        public virtual void  Print()
        {
            Console.WriteLine("A's implementation");
        }
    }
    public class B : A
    {
        public override void  Print()
        {
            Console.WriteLine("B's implementation");
        }
    }
    public class C :A
    {
        public override void Print()
        {
            Console.WriteLine("C's Implementataion");
        }
    }
    public class D : B,C
{
       
}

        class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.Print();   //Here d doesn't know which method to call , this is known as the diamond problem because of the structure
        }
    }
}
