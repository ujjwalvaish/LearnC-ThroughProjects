using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.turnOnRadio(false);
            Console.ReadKey();       
        }
    }

    public class Radio
    {

        public void Power(bool on)
        {
            Console.WriteLine("RadioState isn on : {0}",on);
        }

    }
    class Car
    {       
            private Radio myRadio = new Radio();
            public void turnOnRadio(bool isOn)
            {
                myRadio.Power(isOn);

            }

    }

    
}

