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
            var.Argument1 = "Hello world from jg-develop Class1...another change to merge!";

            Console.WriteLine(var.Argument1);
            Console.ReadLine();
        }
    }
}
