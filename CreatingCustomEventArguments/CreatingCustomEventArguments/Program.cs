using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatingCustomEventArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car("mycar", 10, 100);
            mycar.AboutToBlow += new Car.CarEngineHandler(mycar_AboutToBlow);
            mycar.Exploded += new Car.CarEngineHandler(mycar_Exploded);

            for (int i = 0; i < 6; i++)
            {
                mycar.Accelerate(20);
            }
            Console.ReadKey();
            
        }

        static void mycar_Exploded(object sender, Car.CarEventArgs e)
        {
            Console.WriteLine(e.msg);
        }

        static void mycar_AboutToBlow(object sender, Car.CarEventArgs e)
        {
            Console.WriteLine(e.msg);
        }

        
    }

    class Car
    {
        public delegate void CarEngineHandler(object sender, CarEventArgs e);
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
                    Exploded(this,new CarEventArgs("Sorry , car is dead"));
                }
            }
            else
            {
                currentSpeed += delta;

                if (currentSpeed >= maxSpeed)
                {
                    carIsDead = true;
                }
                else if (10 >= (maxSpeed - currentSpeed) && AboutToBlow != null)
                {
                    Console.WriteLine("Current speed = {0}", currentSpeed);
                    AboutToBlow(this,new CarEventArgs("Watch out !!"));
                }
                else
                {
                    Console.WriteLine("Current Speed = {0}", currentSpeed);
                }



            }
        }

        public class CarEventArgs : EventArgs
        {
            public readonly string msg;
            public CarEventArgs(string message)
            {
                msg = message;
            }
        }

    }
}
