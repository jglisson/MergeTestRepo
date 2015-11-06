using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 var = new Class1();
            var.MyProperty = "Hello world from jg-change3 Class1!";

            Console.WriteLine(var.MyProperty);
            Console.ReadLine();
        }
    }
}
