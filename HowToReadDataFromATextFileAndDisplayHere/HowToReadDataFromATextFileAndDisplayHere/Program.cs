using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//This program is only for .txt files - notepad
namespace HowToReadDataFromATextFileAndDisplayHere
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\UVaish\Desktop\ToFindAParticularFileInAFolder.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            Console.ReadKey();
        }
    }
}
