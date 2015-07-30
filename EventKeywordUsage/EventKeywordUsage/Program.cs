using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventKeywordUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Bucky", 10, 100);
            c1.Exploded += new Car.CarEngineHandler(c1_Exploded); //1st way
            c1.AboutToBlow += c1_AboutToBlow; //Better way, direct assignment by name.
            for (int m = 0; m < 6; m++)
            {
                c1.Accelerate(25);
            }
            Console.ReadKey();
        }

        static void c1_AboutToBlow(string msgForCaller)
        {
            Console.WriteLine(msgForCaller);
            Console.WriteLine();
        }

        static void c1_Exploded(string msgForCaller)
        {
            Console.WriteLine(msgForCaller);
            Console.WriteLine();
        }       
    }

    class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
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

        

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Exploded != null)
                {
                    Exploded("Sorry , car is dead");
                }
            }
            else
                {
                    currentSpeed += delta;
                    
                    if (currentSpeed >= maxSpeed)
                    {
                        carIsDead = true;
                    }
                    else if  (10 >= (maxSpeed - currentSpeed) && AboutToBlow != null)
                    {
                        Console.WriteLine("Current speed = {0}",currentSpeed);
                        AboutToBlow("Watch out !!");
                    }
                    else 
                    {
                        Console.WriteLine("Current Speed = {0}",currentSpeed);
                    }
                    

                        
                    }
                }
            }
        

    


}


