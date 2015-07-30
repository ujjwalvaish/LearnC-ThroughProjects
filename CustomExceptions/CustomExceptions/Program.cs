using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization; //for serialization

//To create your own exceptions , create a class and inherit it from Exceptions, since every excerption inherits this. Make your class end with the word exception
//Then just make the needed constructors , and refer to the base constructors
//make use of serialization so that it can be used in other apps as well
namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserLoggedInException("yayy, it's working!");
            }
            catch (UserLoggedInException ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            }
    }

    [Serializable]
    public class UserLoggedInException : Exception
    {
        public UserLoggedInException() : base()
        {
        }
        public UserLoggedInException(string message) : base(message)
        {
        }
        UserLoggedInException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
        UserLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context) //to make it serializable
        {
        }
    }
}
