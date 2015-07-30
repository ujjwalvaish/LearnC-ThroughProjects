using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedSetClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Car> ListOfCars = new SortedSet<Car>(new Car())
            {
                new Car("Car1",4),
                new Car("Car2",3),
                new Car("Car3",2),
                new Car("Car4",1)
            };

            foreach (Car c in ListOfCars)
            Console.WriteLine(c);


            ListOfCars.Add(new Car("Car0", 6));//Still Sorted
            foreach (Car c in ListOfCars)
                Console.WriteLine(c);
            
            Console.ReadLine();

        }
    }
    public class Car : IComparer<Car>
    {
        public string Name { get; set; }
        public int CarId { get; set; }

        public Car() { }

        public Car(string _nm, int _id)
        {
            Name = _nm;
            CarId = _id;
        }

        public override string ToString()
        {
            return string.Format("Car's name is {0} and ID is {1}", Name, CarId);
        }


        public int Compare(Car x, Car y)
        {
            return x.CarId - y.CarId;
        }
    }
}
