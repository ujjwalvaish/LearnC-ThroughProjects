using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new List<Car>()
            {
                new Car("MyCar1",4),
                new Car("MyCar2",3),
                new Car("MyCar3",2),
                new Car("MyCar4",1),
            };

            Console.WriteLine("Number of Cars = {0}",Cars.Count());
            foreach ( Car c in Cars)
                Console.WriteLine(c);
            Console.WriteLine();
            Cars.Sort();
            foreach (Car c in Cars)
                Console.WriteLine(c);

            Cars.Insert(1, new Car("myCar5", 5));
            foreach (Car c in Cars)
                Console.WriteLine(c);

            Console.WriteLine();
            Car[] myCarArray = Cars.ToArray();
            foreach (Car c in Cars)
                Console.WriteLine(c);
            Console.ReadLine();
                
        }
    }
    public class Car : IComparable<Car>
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

        public int CompareTo(Car other)
        {
            return this.CarId - other.CarId;
        }
    }
}
