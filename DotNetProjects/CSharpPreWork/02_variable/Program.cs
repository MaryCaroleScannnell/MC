using System;

namespace _02_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Paul";
            Console.WriteLine(firstName);
            //1       //2
            string lastName = "Johnson";

            int birthYear= 1994; // Not initialized
                           //3
            Console.WriteLine(lastName);
            Console.WriteLine(birthYear);
            Console.ReadLine();
        }
    }
}
