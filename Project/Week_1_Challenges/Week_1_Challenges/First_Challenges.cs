using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_1_Challenges
{
    [TestClass]
    public class First_Challenges
    {
        [TestMethod]
        public void ForEachChall()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach(char letter in name)
            {
                if (letter == 'i')
                { Console.WriteLine(letter); }
            }

            string firstName = "Mary Carole";
            string lastName = "Scannell";
            int age = 26;
            string interpolate = $"{firstName} {lastName} is {age}.";
            Console.WriteLine(interpolate);
        }
        [TestMethod]
        public void ArrayChall()
        {
            string[] stringArray = { "Harry Potter", "Little Women", "Pride Prejudice", "Something Else" };

        }

        [TestMethod]
        public void Dates()
        {
            DateTime now = DateTime.Now;
            DateTime laterDate = new DateTime(2020, 12, 1);
            DateTime beforeDate = new DateTime(2020, 10, 31);
            List<DateTime> listOfDates = new List<DateTime>
            {
                now,
                laterDate,
                beforeDate
            };
            Console.WriteLine(listOfDates);

        }
        [TestMethod]
        public void Operators()
        {
            int age = 26;
            int sum = age + 7;
            Console.WriteLine(sum);
            int diff = age - 7;
            Console.WriteLine(diff);
            int prod = age * 7;
            Console.WriteLine(prod);
            int quot = age / 7;
            Console.WriteLine(quot);
            int remainder = age % 7;
            Console.WriteLine(quot);

        }
        [TestMethod]
        public void Sleep()
        {
            int sleep = 8;
            if (sleep >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if(sleep >= 8 && sleep < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if(sleep > 4 && sleep < 8)          
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep");
            }
        }

        [TestMethod]
        public void HowsYourDay()
        {
            string myDay = "good";
            switch(myDay)
            {
                case "great": 
                    Console.WriteLine("Awesome");
                    break;
                case "good":
                    Console.WriteLine("Dope!");
                    break;
                case "okay":
                    Console.WriteLine("Hope it gets better!");
                    break;
                case "bad":
                    Console.WriteLine("I'll be thinking of you!");
                    break;
                case ":(":
                    Console.WriteLine("Call if you need to!");
                    break;
            }

          
        }
    }
}
