﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            ClassGreeter hello = new ClassGreeter();
            hello.HelloUser(name);
            hello.ByeUser(name);
            hello.TimeGreetings();

             }

    }
}