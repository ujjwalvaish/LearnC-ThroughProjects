using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DelegateIntroduction
{
    
    class Program
    {
        static void Main(string[] args)
        {
            AddSubtractTwoNumbers asm = new AddSubtractTwoNumbers();
            BinaryOp a = new BinaryOp(asm.AddMethod);
            a(10, 5);
            //BinaryOp b = new BinaryOp(asm.SubtractMethod);
            a += asm.SubtractMethod;
            a(10, 5);
            //Console.WriteLine("10 + 5 equals {0}", a(10,5));
            //Console.WriteLine("10 - 5 equals {0}", a(10, 5));
            //GetDelegateDetails(a);
            //Console.WriteLine();
            //GetDelegateDetails(a);
            Console.ReadKey();


        }
        public static void GetDelegateDetails(Delegate d)
        {
            foreach (Delegate dg in d.GetInvocationList())
            {
                Console.WriteLine("Type is {0}",dg.GetType());
                Console.WriteLine("Method is {0}",dg.Method);
                Console.WriteLine("target is {0}",dg.Target);
            }
        }
    }

    public delegate int BinaryOp(int x, int y);

    class AddSubtractTwoNumbers
    {
        public  int AddMethod(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
            
        }
        public  int SubtractMethod(int a, int b)
        {
            Console.WriteLine(a-b);
            return a - b;
        }

    }
}
