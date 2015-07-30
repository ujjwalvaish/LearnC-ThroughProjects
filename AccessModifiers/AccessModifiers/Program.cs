using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//There are two types of projects(assembly) :exe and dll , console applications, web applications etc contribute to exe, class library contribute to dll
//Classes,Interfaces etc are called "types" where as the methods (variables and functions in them) are called "type methods"
//There are 5 types of access modifiers : public , private , protected , internal ,protected internal
//Types only have 2 types of access modifiers : public and internal , default is internal
//Type methods have all 5 types of access modifiers available to them, default is private
//An internal modifier means , the method is only available to that assembly i.e that project
/*A protected internal is a combination of both that is it is available to all the classes in that assembly as well as all the other classes that inherit this class, that 
even may be outside this assembly*/
//A solution may contain more than 1 projects/assemblies ,each will contain its own exe/dll and combine to form a solution
//All the projects will be in their respective namespaces
//To access another namespace , add its reference to the currebt namespace and the use the "using" keyword

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
