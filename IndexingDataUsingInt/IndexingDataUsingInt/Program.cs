using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IndexingDataUsingInt
{
    //Note : You can't index via strings in the same way , have to make use off the dictionary in that case
    class Program
    {
        static void Main(string[] args)
        {
            PersonCollection pc = new PersonCollection();
            pc[0] = new Person("Ujjwal", 23);
            pc[1] = new Person("Swati", 22);
            pc[2] = new Person("Surabhi", 22);

            foreach (Person p in pc)
            {
                p.Display(p);
            }

            Console.ReadKey();
        }
    }

    class PersonCollection : IEnumerable
    {
        public ArrayList Persons = new ArrayList();
        public Person this[int index]
        {
            get { return (Person)Persons[index]; }
            set { Persons.Insert(index, value); }  //string indexer will create a problem here , as in the insert method , 1st parameter should be an int
        }

       
        public IEnumerator GetEnumerator()
        {
            return Persons.GetEnumerator();
        }
    }

    class Person
    {
        public string Name{get;set;}
        public int Age{get;set;}

        public Person() {}
        public Person(string _nm, int _age)
        {
            Name = _nm;
            Age = _age;
        }

        public void Display(Person p)
        {
            Console.WriteLine("Person's name is {0} and age is {1}",p.Name,p.Age);
        }
    }
}
