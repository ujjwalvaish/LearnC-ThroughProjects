using System;
using System.Reflection;

//Reflection is the ability of inspecting an assemblies' metadata at runtime. It is used to find all the assemblies and/or dynamically invoke the methods in the assembly.
/*The major use of reflection is in late binding(to use the code that is bnot available to us during the compile time. e.r dynamically creating the instance of a class.
 -note that what we normally do is early binding where we have all the knowledge of the class whose instance we want to create
 -Type class is in System Namespace
 -System.Reflection contains PropertyInfo, MethodInfo etc
 -Note that we can also get the method's return typeand properties' type
 -Every type (class) inherits from System.Object that is why we are getting extra methods
 -Note the different ways to get the type of class
 -Constructor.Name gives .ctor , useless
 -Constructor.string also gives that but along with constructors' parameters ,more useful (we can also get a method's parameters)*/
namespace ReflectionsOverview
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Type T1 = Type.GetType("ReflectionsOverview.Customer");//1st way to get the type
            Console.WriteLine("Fullname is {0}", T1.FullName);
            Console.WriteLine("Namespace is {0}", T1.Namespace);
            Console.WriteLine("Name of the type is {0}", T1.Name);

            Customer C1 = new Customer();//2nd way to get the type
            Type T2 = C1.GetType();
            Console.WriteLine("Fullname is {0}",T2.FullName);

            Type T3 = typeof(Customer);//3rd way to get the type
            Console.WriteLine("Fullname is {0}", T3.FullName);

            PropertyInfo[] properties = T1.GetProperties();
            Console.WriteLine("Properties are :-");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            ConstructorInfo[] constructors = T1.GetConstructors();
            Console.WriteLine("Constructors are :-");
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
            }

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            MethodInfo[] methods = T1.GetMethods();
            Console.WriteLine("Methods are :-");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            MemberInfo[] members = T1.GetMembers();
            Console.WriteLine("Members are :-");
            foreach (MemberInfo member in members)
            {
                Console.WriteLine(member);
            }
            Console.ReadKey();
        }
    }


    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }

        public  Customer()
        {
            id = 101;
            Name = "NoName";
        }

        public Customer(int _Id, string _Name)
        {
            this.id = _Id;
            this.Name = _Name;
        }

        public void PrintName()
        {
            Console.WriteLine("Name is {0}", this.Name);
        }

        public void PrintId()
        {
            Console.WriteLine("Name is {0}", this.id);
        }
    }
}
