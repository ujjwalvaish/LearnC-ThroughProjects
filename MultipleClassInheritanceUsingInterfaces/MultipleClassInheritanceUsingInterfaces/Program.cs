using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleClassInheritanceUsingInterfaces
{
    interface IA
    {
        void Amethod();
    }
    class A : IA  //Since it inherits IA, it has to provide the implememtation of its method
    {
        public void Amethod()
        {
            Console.WriteLine("A's method");
        }
    }
    interface IB
    {
        void Bmethod();
    }
    class B : IB  //Since it inherits IB, it has to provide the implememtation of its method
    {
        public void Bmethod()
        {
            Console.WriteLine("B's method");
        }
    }

    class C : IA, IB  //Multiple interface inheritance is possible , now the implementations of their methods are given in classes A, B respectively
    {
        A a = new A();  //make object of classes where the implementations are there
        B b = new B();
        public void Amethod()
        {
            a.Amethod();
        }
        public void Bmethod()
        {
            b.Bmethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();  
            c.Amethod();  // Call the methods by taking A , B class implementations
            c.Bmethod();
            Console.ReadLine();
        }
    }
}
