using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace IComparableDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] CarArray = new Car[4];
            CarArray[0] = new Car("mycar1", 1, 40);
            CarArray[1] = new Car("mycar2", 2, 50);
            CarArray[2] = new Car("mycar3", 3, 40);
            CarArray[3] = new Car("mycar4", 4, 40);
            Array.Sort(CarArray, new CarComparer());
            foreach (Car c in CarArray)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }

    class Car :IComparable
    {
        public int CarID { get; set; }
        public string Name { get; set; }
        public int CurrentSpeed { get; set; }

        public Car(string name, int carid, int currSpeed)
        {
            CarID = carid;
            Name = name;
            CurrentSpeed = currSpeed;

        }
        public override string ToString()
        {
            return string.Format("Name is {0}, id is {1} and speed is {2}", Name, CarID, CurrentSpeed);
        }


        public int CompareTo(object obj)
        {
            Car c = obj as Car;
            if (c != null)
            {
                if (this.CurrentSpeed > c.CurrentSpeed)
                    return 1;
                else if (this.CurrentSpeed < c.CurrentSpeed)
                    return -1;
                else return 0;
            }
            else
            {
                throw new ArgumentException("Not a valid Car object");
                    
            }
        }
    }

    public class CarComparer : IComparer
    {

        public int Compare(object x, object y)
        {
            Car c1 = x as Car;
            Car c2 = y as Car;
            if (c1 != null && c2 != null)
            {
                return String.Compare(c1.Name, c2.Name);
            }
            else
            {
                throw new ArgumentException("Not valid car objects");
            }
            
        }
    }
}
