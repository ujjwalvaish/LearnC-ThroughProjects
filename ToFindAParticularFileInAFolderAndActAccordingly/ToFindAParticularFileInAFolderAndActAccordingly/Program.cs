using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ToFindAParticularFileInAFolderAndActAccordingly
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderpath = @"C:\Users\UVaish\Desktop\UjjwalPractice";
            string filename = "*";
            string[] fileList = System.IO.Directory.GetFiles(folderpath,filename);//getting the file names from the folder as an array
            
            List<InputFile> inputFiles = new List<InputFile>(fileList.Length);//making a list of same number of elements as the number of files            
            
            InputFile inputFile =new InputFile();
            foreach (string str in fileList)
            {
                inputFile.FileName = str;
                inputFiles.Add(inputFile);
             }

            DateTime y = DateTime.Now;

            int i = y.Year;
            Console.WriteLine(i);
           
            Console.ReadKey(); 

        }
    }
    public class InputFile
    {
        public string FileName;
    }
}
