using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Manager("Ujjwal", 23);
            //e1.Display();
            //Employee e2 = new Manager("Swati", 22, 3);
            //e2.Display();
            //ArrayList al = new ArrayList();
            //al.AddRange(new string[] { "first", "second", "third" });
            //Console.WriteLine("Array list has {0} items",al.Count);
            //Console.WriteLine("The elements are:");
            //foreach (string s in al)
            //{
            //    Console.WriteLine(s);
            //}
            //al.Add("fourth");
            //Console.WriteLine("Array list has {0} items", al.Count);
            //Console.WriteLine("The elements are:");
            //foreach (string s in al)
            //{
            //    Console.WriteLine(s);
            //}           

            //Family myFamily = new Family();
            //foreach (Manager m in myFamily)
            //{
            //    Console.WriteLine(m.Name);
            //}

            //Point c1 = new Point()
            //{
            //    X = 10,
            //    Y = 20
            //};

            //Console.WriteLine(c1.ToString());

            //Point c2 = (Point)c1.Clone();
            //Console.WriteLine(c2.ToString());
            //c2.X = 30;
            //Console.WriteLine(c2.ToString());
            //Console.WriteLine(c1.ToString());

            //int myint = 7;
            //object myboxedObject = myint;
          
            //int unboxed = (int)myboxedObject;
	    
	    
            //Console.WriteLine(myint);
            //Console.WriteLine(myboxedObject);
            //Console.WriteLine(unboxed);
            //ArrayList al = new ArrayList();
            //al.Add(10);
            //al.Add(20);
            //al.Add(30);

            //int i = (int)al[0];
            //int[] myArray = new int[5];
            //myArray[0] = 50;
            //myArray[1] = 40;
            //myArray[2] = 30;
            //myArray[3] = 20;
            //myArray[4] = 10;
            //Array.Sort<int>(myArray);
            //foreach (int i in myArray)
            //{
            //    Console.WriteLine(i);
            //}
            Family f1 = new Family();
            //IEnumerator e1 = f1.GetEnumerator();
            //foreach (Manager m in f1)
            //{
            //    if (e1.MoveNext())
            //        Console.WriteLine(e1.Current.ToString());
            //}

            IEnumerator e2 = f1.GetEnumerator();
            while (e2.MoveNext())
            {
                Console.WriteLine(e2.Current);
            }
            Console.ReadKey();


        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string nm , int _age)
        {
            Name = nm;
            Age = _age;
        }
        public virtual void Display()
        {
            Console.WriteLine("Name is {0}, and Age is {1}",Name,Age);
        }

        
    }

    class Manager : Employee
    {
        public int NoOfProjects { get; set; }
        public Manager()
            : base("", 25)
        {
            NoOfProjects = 1;
        }

        public Manager(string name, int age, int nop)
            : base(name, age)
        {
            NoOfProjects = nop;
        }
        public Manager(string name, int age)
            : base(name, age)
        {
            NoOfProjects = 1;
        }
        public override void Display()
        {
            Console.WriteLine("Name is {0}, age is {1} and Number of Projects are {2}",Name,Age,NoOfProjects);
        }
        public override string ToString()
        {
            return string.Format("name of the manager is {0}", this.Name);
        }
    }

    class Family : IEnumerable
    {
        private Manager[] Managers = new Manager[4];
        public Family()
        {
            Managers[0] = new Manager("firstmanager", 30);
            Managers[1] = new Manager("secondmanager", 30);
            Managers[2] = new Manager("thirdmanager", 30);
            Managers[3] = new Manager("fourthmanager", 30);
        }

        public IEnumerator GetEnumerator()
        {
            foreach ( Manager m in Managers)
        {
            yield return m;
        }
        }
        //public IEnumerator GetEnumerator()
        //{
        //    return Managers.GetEnumerator();
        //}
    }

    [Serializable]
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Pointdescription desc = new Pointdescription();
        public Point() { }
        public Point(int x, int y , string pName)
        {
            X = x;
            Y = y;
            desc.PetName = pName;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}, Name = {2},ID = {3}", X, Y,desc.PetName,desc.PointID);
        }
    }

    public class Pointdescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }
        public Pointdescription()
        {
            PetName = "Noname";
            PointID = Guid.NewGuid();
        }
    }

}
