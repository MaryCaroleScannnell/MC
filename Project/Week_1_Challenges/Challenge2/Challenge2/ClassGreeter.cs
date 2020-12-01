using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge2
{
    class ClassGreeter
    {
        public void HelloUser(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public void ByeUser (string name)
        {
            Console.WriteLine($"Farwell {name}");
        }
        public void TimeGreetings()
        {
            DateTime now = DateTime.Now;
            if (now.Hour <12)
            {
                Console.WriteLine("Morning");
            }
            else if (now.Hour <17)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (now.Hour <21)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
