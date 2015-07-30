using System;
namespace ConsoleApplication1
{
    class Program
    {
         static void Main(string[] args)
        {
            Employee e1 = new Employee("Ujjwal");
            e1.GetEmployeeDetails();

            
            

            PartTimeClerk p1 = new PartTimeClerk();
            p1.NoOfWorkingDays = 50;
            Console.WriteLine();
            p1.GetEmployeeDetails();
            

            Employee e2 = new Manager();
            e2.GetEmployeeDetails();
            if (e2 is Employee)
            {
                Console.WriteLine("it is employee");
            }
          
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public String Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        public virtual void GetEmployeeDetails()
        {
             Console.WriteLine("Employee's name is {0}" ,Name);
             Console.WriteLine("Employee's age is {0}", Age);
             Console.WriteLine("Employee's salary is {0}", Salary);
        }
        
        public Employee() : this("NoName")
        {
        }
        public Employee(string name_, int age_ = 0, int salary_= 0)
        {
            Name = name_;
            Age = age_;
            Salary = salary_;
        }

    }

    public class Manager : Employee
    {
        public Manager() : base("Default Manager")
        {
        }
        
        public int stockOptions{get;set;}
        public override void GetEmployeeDetails()
        {
            base.GetEmployeeDetails();
            Console.WriteLine("Manager's stockOptions  are {0}", stockOptions);
            Console.WriteLine();
        }
    }

    public class Clerk : Employee
    {
        public Clerk() : base("Default Clerk")
        {

        }
        public int salaryRaise { get; set; }
        public override void GetEmployeeDetails()
        {
            base.GetEmployeeDetails();
            Console.WriteLine("Clerk's salaryRaise is {0}", salaryRaise);
            Console.WriteLine();
        }
    }

    public class PartTimeClerk : Clerk
    {
        public PartTimeClerk() : base()
        {

        }
        public int NoOfWorkingDays { get; set; }
        public override void GetEmployeeDetails()
        {
            base.GetEmployeeDetails();
            Console.WriteLine("PartTimeClerk's number of working days are {0}", NoOfWorkingDays);
            Console.WriteLine();
        }


    }
}
