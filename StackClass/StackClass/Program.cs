using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Car> CarStack =  new Stack<Car>();

            CarStack.Push(new Car("MyCar1", 4));
            CarStack.Push(new Car("MyCar2", 3));
            CarStack.Push(new Car("MyCar3", 2));
            CarStack.Push(new Car("MyCar4", 1)); //Topmost Item in the stack

            Console.WriteLine((Car)CarStack.Peek());
            Console.WriteLine(CarStack.Count);
            CarStack.Pop();
            CarStack.Pop();
            CarStack.Pop();
            CarStack.Pop();
            //CarStack.Pop();  - this will give Invalid Operation Exception as the stack is now empty.
            Console.WriteLine(CarStack.Count);
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
