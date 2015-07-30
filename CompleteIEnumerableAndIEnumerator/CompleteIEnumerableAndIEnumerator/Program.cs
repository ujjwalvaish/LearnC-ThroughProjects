using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CompleteIEnumerableAndIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Family f = new Family();
            foreach (Manager s in f)
            {
                Console.WriteLine(s);
            }

            foreach (Manager q in f.GetManagers(true))
            {
                Console.WriteLine(q);
            }
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string nm, int _age)
        {
            Name = nm;
            Age = _age;
        }
        public virtual void Display()
        {
            Console.WriteLine("Name is {0}, and Age is {1}", Name, Age);
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
            Console.WriteLine("Name is {0}, age is {1} and Number of Projects are {2}", Name, Age, NoOfProjects);
        }
        public override string ToString()
        {
            return string.Format("name of the manager is {0}", this.Name);
        }
    }

    class Family :IEnumerable
    {
        private Manager[] Managers = new Manager[4];
        public Family()
        {
            Managers[0] = new Manager("Ujjwal", 23);
            Managers[1] = new Manager("Swati", 22);
            Managers[2] = new Manager("Dj", 23);
            Managers[3] = new Manager("kanika", 24);

        }

        public IEnumerable GetManagers(bool reverse)
        {
            if (reverse)
            {
                for (int i = Managers.Length; i > 0; i--)
                {
                    yield return Managers[i - 1];
                }

            }
            else
            {
                foreach (Manager m in Managers)
                {
                    yield return m;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Manager m in Managers)
            {
                yield return m;
        
            }
        }
    }
}
        
    


