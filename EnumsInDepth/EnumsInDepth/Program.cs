using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Enums makw the program more readable and maintainable
//Enums are enumerations
//They have int as their underlying datatype
//Enums are strongly typed constants, i.e. you have to explicitly cast them to int and vice versa
//Note the Enums class and its GetValues and GetNames methods, and the use of typeof method
//enum is the keyword which we use to create an enum where as Enum is a class which contains static methods like GetNames and GetValues
//We can also customize enums , i.ee change the underlying datatype from int which is default to long , short etc
//We can also change the values of the enums , they can either start from a particular number(only specify the value for the first element of enum here) or random(specify all)
//An enum of one type cannot be implicitly assigned to an enum of another type even though their underlying datatypes are same, you have to cast them.
//Enums are value types not reference types
namespace EnumsInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Values = (int[])Enum.GetValues(typeof(Gender));//Note tha return type is an array for GetValues method,also explicit casting is required

            foreach (int value in Values)
            {
                Console.WriteLine(value);
            }

            string[] Names = (string[])Enum.GetNames(typeof(Gender));////Note tha return type is an array for GetNames method,also explicit casting is required

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            

            Gender gender = (Gender)Food.Chicken; // Valid after type conversion

            short[] seasons = (short[])Enum.GetValues(typeof(Season));

            foreach (short season in seasons)
            {
                Console.WriteLine(season);
            }
            Console.ReadKey();         

        }
    }


    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum Season : short
    {
        Summer = 1,
        Winter = 2,
        Spring = 5
    }

    public enum Food
    {
        Chicken = 7,
        Mutton,
        Fish
    }

}
