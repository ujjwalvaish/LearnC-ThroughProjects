using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDetailed
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 10, 100);
            c1.RegisterWithCarEngine(OnCarEngineEvent1);
            c1.RegisterWithCarEngine(OnCarEngineEvent2);
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine();
            Console.WriteLine();

            Car c2 = new Car("SlugBug2", 10, 100);
            c2.RegisterWithCarEngine(OnCarEngineEvent1);
            c2.RegisterWithCarEngine(OnCarEngineEvent2);
            c2.UnRegisterWithCarEngine(OnCarEngineEvent1);

            
            
            for (int i = 0; i < 6; i++)
            {
                c2.Accelerate(20);
            }
            
            Console.ReadKey();
            
        }
        public static void OnCarEngineEvent1(string msg)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine(msg);
            Console.WriteLine();
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine(msg);
            Console.WriteLine();
        }

        
    }

    class Car
    {
        public int currentSpeed { get; set; }
        public int maxSpeed { get; set; }
        public string petName { get; set; }

        private bool carIsDead;

        public Car() { maxSpeed = 100; }
        public Car(string _nm, int _currspeed, int _mspeed)
        {
            currentSpeed = _currspeed;
            maxSpeed = _mspeed;
            petName = _nm;
        }

        private CarEngineHandler listOfHandlers;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("Sorry , car is dead");
                }
            }
            else
                {
                    currentSpeed += delta;
                    
                    if (currentSpeed >= maxSpeed)
                    {
                        carIsDead = true;
                    }
                    else if  (10 >= (maxSpeed - currentSpeed) && listOfHandlers != null)
                    {
                        Console.WriteLine("Current speed = {0}",currentSpeed);
                        listOfHandlers("Watch out !!");
                    }
                    else 
                    {
                        Console.WriteLine("Current Speed = {0}",currentSpeed);
                    }
                    

                        
                    }
                }
            }
        

    

    public delegate void CarEngineHandler(string msgForCaller);
}
