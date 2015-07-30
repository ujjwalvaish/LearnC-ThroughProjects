using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//If a class is inheriting from 2 interfaces , and both have got the identical signatures then there is a need to explicitly state which method is being called
//Note that by not explicitly stating which method , the compliler/run time shows no errror, both the interfaces take it as there method
//when explicitly calling a method of a specific interface , don't use access modifiers while defining it , also state which interface is being referred to
//Also typecast , where the method is called
/*when we explicitly implement(define) methods, then we ALWAYS need to typecast them while calling(invoking) them i.e it can no longer be called by the 
class reference variable but only by the interface reference variable*/
//If you don't want to typecast , you can point the interface reference variable towards the child class
//If you want one of the two methods to be the default method, just define it normally , i.e having an access modifier like all normal methods and other explicitly
namespace ExplicitInterfaceImplementation
{
    interface Interface1
    {
        void PrintInterface();
    }
    interface Interface2
    {
        void PrintInterface();
    }

   public class NotExplicitlyStating : Interface1, Interface2
    {
        public void PrintInterface()
        {
            Console.WriteLine("Ambiguous about which method to call but still  no error");
        }
    }


   public class ExplicitlyStating : Interface1, Interface2
   {
       void Interface1.PrintInterface()         //No access modifier, interface reference given
       {
           Console.WriteLine("I come from Interface 1 , as explicitly stated");
       }
       void Interface2.PrintInterface()         //No access modifier, interface reference given
       {
           Console.WriteLine("I come from Interface 2 , as explicitly stated");
       }
   }

    class Program
    {
        static void Main(string[] args)
        {
            NotExplicitlyStating N1 = new NotExplicitlyStating();
            N1.PrintInterface();
            ExplicitlyStating E1 = new ExplicitlyStating();
            ((Interface1)E1).PrintInterface(); //Typecast
            ((Interface2)E1).PrintInterface(); //Typecast
            Interface1 E11 = new ExplicitlyStating(); //Interface1 pointing towards ExplicitlyStating object reference
            E11.PrintInterface();                      
            Console.ReadKey();

           /* if we define Interface1.PrintInterface() as public void PrintInterface()
                                                                       {
            *                                                                    }       
        and call it as ExplicitlyStating E4 = new ExplicitlyStating();
            *          E4.PrintInterface();
            *          Then interface1.printmethod is set as default and will be called, other will be called only when we explicitly call it*/
    }
}
