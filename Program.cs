using System;
using System.Reflection;
using Assembles;

namespace Assembles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Assemblies");
        }
            class Stringer
        {
            public void StringerMethod()
            {
                Console.WriteLine("This method is defined in assembles namespace under class stringer");

                Stringer myStringInstance = new Stringer();
                Console.WriteLine("client code executes");
                myStringInstance.StringerMethod();
            }
        }
        }
    }

