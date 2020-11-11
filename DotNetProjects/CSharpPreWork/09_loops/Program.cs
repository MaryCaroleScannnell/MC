using System;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =100;

            //1         //2       //3
            for (int i = 0; i <= number; i+=5) // i is the loop control variable (LCV)
            {
                //4
                Console.WriteLine(i);
            }
            //5
        }
    }
}
