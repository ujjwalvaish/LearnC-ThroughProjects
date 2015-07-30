using System;

//Instance members and static members , static constructor is allowed to initiate static fields.
//Static constructors are called before instance constructors
//static constructors cannot take an access modifier, because they are always called on their own and no other class should be allowed to call them explicitly
//static constructor is called only once no matter how many instances you create
//To show static constructos are called before instance constructors and even before any instance of the class is created.
//Assign a member as static , whenever it's value is not going to change for multiple instances of that class. (e.g pi)

namespace StaticAndInstanceMembers
{
    class Circle1
    {
        public static float pi =  3.14f;
        float radius;

        public Circle1(float _rad)
        {
            radius = _rad; 
        }

        public void printArea() 
        {
            Console.WriteLine(this.radius * this.radius * Circle1.pi);
        }
    
    }


    class Program1
    {
        static void Main(string[] args)
        {
            Circle1 C1 = new Circle1(5);
            C1.printArea();
            Circle2 C2 = new Circle2(10);
            C2.printArea();
            Circle2 C3 = new Circle2(20);
            C3.printArea();
            Console.ReadKey();
        }
    }



    class Circle2
    {
        static float pi;
        float radius;

        public Circle2(float _rad)
        {
            Console.WriteLine("Instance constructor called");
            radius = _rad;
        }

        static Circle2()
        {
            Console.WriteLine("Static constructor called");
            pi = 3.41f;
        }
        public void printArea()
        {
            Console.WriteLine(this.radius * this.radius * Circle1.pi);
        }

    }

//Note that instance constructor is calle devery time an instance of the class is created , but static constructor is called only once, and that too before instance constructor.
}
