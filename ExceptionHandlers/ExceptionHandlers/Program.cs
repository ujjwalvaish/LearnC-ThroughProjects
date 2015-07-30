using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//More specific exceptions should come first
//Specific exceptions inherit exceptions class , so they contain some specific methods that are not a part of the exceptions parent class
//Play with the file name and the directory name to see the various types of exceptions
namespace ExceptionHandlers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null; //If you'll define it in the try lock , its scope will be limited to there
            try
            {
                streamReader = new StreamReader(@"C:\Users\UVaish\Desktop\ToFindAParticularFileInAFolder.txt");
                Console.WriteLine(streamReader.ReadToEnd());                
            }                       
            catch (FileNotFoundException Fnf)//will only catch a "file not found" exception , different from directory not found exception.
            {
                Console.WriteLine("{0} File Not Found",Fnf.FileName);
                
            }
            catch (Exception Exc)//will catch all other exceptions, always place the generic type in the end
            {
                Console.WriteLine(Exc.Message); //Message is a method which retiurns the message from the exception
                
            }
            finally //Add all the code to release the resources here, as this block is always executed whether we find an error or not
            {
                if (streamReader != null) //if there is an error in the statement after the try block , streamReader remains null , so we cannot close it.
                {
                    streamReader.Close(); //contd.... closing it will only create an error, so we have to checl if it exists or not
                }
                Console.ReadKey();
            }
            
        }
    }
}
