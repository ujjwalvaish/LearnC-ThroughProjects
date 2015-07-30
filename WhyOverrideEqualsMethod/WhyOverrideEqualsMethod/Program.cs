using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhyOverrideEqualsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 20;
            Console.WriteLine(i.Equals(j));

            Customer C1 = new Customer();
            C1.firstName = "Ujjwal";
            C1.lastName = "Vaish";

            Customer C2 = C1;

            Console.WriteLine(C2 == C1);//== gives a reference type comparison, are the 2 objects referencing to the same object
            Console.WriteLine(C2.Equals(C1));//Equals gives a value type comparison

            Customer C3 = new Customer();
            C3.firstName = "Ujjwal";
            C3.lastName = "Vaish";
            Console.WriteLine(C3 == C1);//Reference type , should return false as they are pointing to different instances of objects
            Console.WriteLine(C3.Equals(C1));//Value types , should return true , BUT returns false because of some default implementatiion , thats why we override the method
            //remove the override implementation and check
            Console.ReadKey();
        }

        public class Customer
        {
            public string firstName { get; set; }
            public string lastName { get; set; }

            public override bool Equals(object obj) 
            {
                if (obj == null) //check if the object is not null

                if (!(obj is Customer))//check if the  object doen not belong to customer or its inherited classes
                    return false;

                return this.firstName == ((Customer)obj).firstName && this.lastName ==((Customer)obj).lastName;//we are sure now that obj is Customer or inherited from customer
            //So typecast the objand check
            }
            public override int GetHashCode()
            {
                return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
                //whenever we override Equals method , it is a good practice to override GetHashCode method otherwise we get a green squigly
                //Note the ^ symbol
            }
        }
    }
}
