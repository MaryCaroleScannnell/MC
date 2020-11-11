using System;

namespace _07_conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on, it's bright.");
            }

            if (isOn == true)
            {
                Console.WriteLine("The light is on.");
            }

            if (isOn && isHot)
            {
                Console.WriteLine("lights on and it's hot");
            }

            if (isOn || isHot)
            {
                Console.WriteLine("lights on or it is hot");
            }

            if (!isHot)
            {
                Console.WriteLine("it is not hot");
            }
        }
    }
}
