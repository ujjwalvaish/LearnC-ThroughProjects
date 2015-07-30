using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CollectionsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.AddRange(new int[] { 1,2,3,4,5,});
            //foreach (int i in al)
            //    Console.WriteLine(i);
            //al.Reverse();
            //foreach (int i in al)
            //    Console.WriteLine(i);
            //al.Add(6);
            //foreach (int i in al)
            //    Console.WriteLine(i);
            //Console.ReadLine();

           

            Car[] Cars = new Car[4];
            Cars[0] = new Car("MyCar3", 0);
            Cars[1] = new Car("MyCar2", 1);
            Cars[2] = new Car("MyCar1", 2);
            Cars[3] = new Car("MyCar0", 3);

            Array.Sort(Cars);
            foreach ( Car c in Cars)
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
            return (String.Compare(this.Name,other.Name,true));          
        }
    }

}
