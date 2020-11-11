using System;

namespace _08_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Bill = 54.23m;
            decimal Tip = 12;

            decimal Percentage = Tip / Bill;

            Console.WriteLine(Percentage);
            Console.WriteLine(Math.Round(Percentage, 2));
            Console.ReadLine();
        }
    }
}
