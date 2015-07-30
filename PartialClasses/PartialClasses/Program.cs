using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Partial classes allow us to split a class into multiple files.All files are then combined into a single class when the app is compiled.Also, multiple users can work on 
 the same class then.
 *Partial keyword should be used in every component
 *All components must have the same access modifiers
 *If any component is declared abstract/sealed,whole class becomes abstract/sealed
 *If any component inherits a class , whole class inherits it, that's why different components cannot inherit from differnt classes, as C# does not support multi class inheritance
 *Different components of the partial classcan specify different interfaces, and the final type implements all the interfaces listed by all the partial classes.
 *Implementations of interface inherited by one component can be declared in some other partial class also
 */
namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPartialClass C1 = new MyPartialClass();
            C1.Name = "Ujjwal";
            string name = C1.PrintName();

            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
