using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//This program just takes two numbers from the user and divides them , displays the result
//There can be a number of exceptions here, like if the user enters alphabets or special symbols - they cannot be converted to a number - format exception
//If the number is too long (for int or float depending upon what we use)-overflow error
//division by zero error
//We also need to log our errors on a text file (notepad)
namespace InnerExceptionAndErrorLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the first number");
                    int FNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    int SNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("First number / Second number = {0}", FNumber / SNumber);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please try again");
                    string path = @"C:\Users\UVaish\Desktop\Logfile1.txt";
                    if (File.Exists(path))
                    {
                        StreamWriter sw = new StreamWriter(path);
                        sw.Write(ex.GetType().Name);
                        sw.Close();
                        Console.ReadKey();
                    }
                    else //now , we can have 2 exceptions , one is the inner exception - div by zero etc , other is the outer exception - filenotfound , we don't want to lose the before(inner) one
                    //so that is why we will also pass it in the next exception
                    {
                        throw new FileNotFoundException("file at {0} was not found", path, ex); //here we are passing ex as inner exception
                    }
                }
            }
                catch(Exception exc) // this is the current exception
                {
                    Console.WriteLine("Outer Exception is {0}",exc.GetType().Name);
                    if(exc.InnerException != null) //to check if the inner exception is present , read the last comment of this prog
                    {
                    Console.WriteLine("Inner exception is {0}", exc.InnerException.GetType().Name); //note that ex.GetType().Name is not valid as ex's scope has ended
                    }
                    Console.ReadKey();
                }
            }//if we don't pass ex to the outer exception , the innerException property of the outer exception will be equal to zero , and it will give a nullreferenceException
        //Try it , for handling this , we have put the second console.writeline in the if block , it will prevent the system from getting crashed
        }
    }
