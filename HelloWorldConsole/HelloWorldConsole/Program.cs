﻿using System;
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
            var.Argument1 = "Hello world from jg-develop2 Class1...merge these!";

            Console.WriteLine(var.Argument1);
            Console.ReadLine();
        }
    }
}
