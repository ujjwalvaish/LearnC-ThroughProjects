using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//Multicast delegate is a delegate that points to multiple functions
//Approach1 =>Just use a '+' sign between different delegate objects 
//The methods are invoked in the same order that they are added to (they are stored as lists)
//If delegates have return types other than void , then only the return value of the last method will be returned
//Also , if the delegate has an output parameter , then it will take the value of the output parameter of the last called method
//Multicast delegates find usage in observer design patter which become really easier if we use multicast delegates
//observer design pattern is also called publish/subscribe pattern - Later coverd
namespace MulticastDelegate
{
    public delegate void SampleDelegate();
    public delegate int ReturningValueDelegate();
    public delegate void OutputParameterDelegate(out int OutputParameter);


    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate SD1, SD2, SD3,SD4;
                SD1 = new SampleDelegate(SampleMethod1);
                SD2 = new SampleDelegate(SampleMethod2);
                SD3 = SD1 + SD2;
                SD3(); //This is a multicast delegate
                SD4 = SD1 + SD2 - SD1;//like the + sign , - sign can also be used to remove the delegates (here , SD4 = SD2 basically)
                SD4();
                SampleDelegate SD5 = new SampleDelegate(SampleMethod1);
                SD5 += SampleMethod2; //Another way to multicast delegates
                SD5();//Here , we don't need to create many instances of the delegate to make it multicast
                Console.ReadKey();

                ReturningValueDelegate RVD;//Demonstrating return value
                RVD = new ReturningValueDelegate(ReturningValueMethod1);
                RVD += ReturningValueMethod2;
                int ReturnedValue = RVD();
                Console.WriteLine("Returned Value is {0}", ReturnedValue);
                Console.ReadKey();

                OutputParameterDelegate OPD;  //Demonstrating output parameter
                OPD = new OutputParameterDelegate(OutputParameterMethod1);
                OPD += OutputParameterMethod2;
                int OutParameter = -1;
                OPD(out OutParameter);
                Console.WriteLine("Final output parameter is {0}", OutParameter);
                Console.ReadKey();   
        }

        public static void SampleMethod1()
        {
            Console.WriteLine("I am SampleMethod1");
        }
        public static void SampleMethod2()
        {
            Console.WriteLine("I am SampleMethod2");
        }
        public static int ReturningValueMethod1()
        {
            return 1;
        }
        public static int ReturningValueMethod2()
        {
            return 2;
        }
        public static void OutputParameterMethod1(out int num1)
        {
            num1 = 10;
        }
        public static void OutputParameterMethod2(out int num2)
        {
            num2 = 20;
        }
    }
}
