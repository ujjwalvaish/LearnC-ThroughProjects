using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
namespace ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> Persons = new ObservableCollection<Person>()
         {
             new Person("Ujjwal",23),
            new Person("Vidisha",22)
         };

            Persons.Add(new Person());
            Persons.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Persons_CollectionChanged);
            Console.ReadLine();
        }

        static void Persons_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

      
    }

    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string _nm, int _age)
        {
            Name = _nm;
            Age = _age;
        }

        public override string ToString()
        {
            return String.Format("Name is {0} and age is {1}", Name, Age);
        }

        public int CompareTo(object obj)
        {
            return this.Age - ((Person)obj).Age;
        }
    }

}
