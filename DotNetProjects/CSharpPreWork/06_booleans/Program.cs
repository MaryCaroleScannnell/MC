using System;

namespace _06_booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 100 / 5;
            //1
            if (value == 50)
            {
                //2
                Console.WriteLine(true);
            }

            //3
            Console.WriteLine("Since I'm not in the if block, I'll always display.");
        }
    }
}
