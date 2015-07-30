using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EnvironmentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ARGS = Environment.GetCommandLineArgs();
            foreach (string argss in ARGS)
            {
                Console.WriteLine(argss);
            }
            GetEnvDetails();
            Console.ReadKey();
        }

        public static void GetEnvDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive is {0}", drive);
            }
            Console.WriteLine("OS version is {0}", Environment.OSVersion);
            Console.WriteLine("Processor count is {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version is {0}", Environment.Version);
        }


    }
}
