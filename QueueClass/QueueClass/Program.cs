using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Car> QueueOfCars = new Queue<Car>();
            QueueOfCars.Enqueue(new Car("Mycar1", 4));
            QueueOfCars.Enqueue(new Car("Mycar2", 3));
            QueueOfCars.Enqueue(new Car("Mycar3", 2));
            QueueOfCars.Enqueue(new Car("Mycar4", 1));

            Console.WriteLine(QueueOfCars.Peek());
            Console.WriteLine();
            foreach(Car c in QueueOfCars)
                Console.WriteLine(c);
            Console.WriteLine();
            QueueOfCars.Dequeue();
            foreach (Car c in QueueOfCars)
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
