using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_conditions
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = true;
            if (isTrue) ;

            int age = 24;
            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }

            else if (age > 6)
            {
                Console.WriteLine("Youre a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You're far too young");
            }
            else
            {
                Console.WriteLine("You're not even born");
            }

            if (age > 65 && age < 75) ; //and comparison
            if (age <= 65 || age >= 18) ; //or comparison
            if (age == 17) ; //is equal to
            if (age != 19) ; //not equal to    
        }


        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;
            switch (age)
            {
                case 18:
                    Console.WriteLine("Vote");
                    break;
                case 19:
                    Console.WriteLine("Yay!");
                    break;
                case 20:
                case 21:
                case 22:
                    Console.WriteLine("Roaring 20s!");
                    break;
                default:
                    Console.WriteLine("Neat!");
                    break;
            }
        }
        [TestMethod]
        public void Ternaries()
        {
            int age = 37;
            bool isAge = (age == 24) ? true : false;
        }
    }
}
