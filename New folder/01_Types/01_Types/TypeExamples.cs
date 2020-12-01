using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //whole numbers//

            byte oneBytesWorth = 255;
            short smallWholeNumber = 16; //aka int16
            int wholeNumber = 32; //aka int32
            long largeWholeNumber = 64; //aka int64

            //decimals//

            float floatExample = 1.234567f;
            double doubleExample = 1.237909d; //this is the default for decimal
            decimal decimalExample= 1.7000m;

            //character//

            char letter = 'm'; //single quotes mean just one letter, symbol, etc

            //operators video//

            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; //this divides 17 by 5 and gives us the remainder
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");
        }
        [TestMethod]
        public void ReferenceTypes()

        {

            //any characters inside of double quotes is called a string
            string stringExamples = "This is a string";
            string name = "Mary Carole";

            string concatenate = stringExamples + name;
            string interpolate = $"{name}. Here is the string: {stringExamples}";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //object examples

            DateTime now = DateTime.Now;  //should do current date & time
            Console.WriteLine(now);
            DateTime randomDate = new DateTime(2021, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new String[15];
            Console.WriteLine(stringArray);

            //lists

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            //queues

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //dictionaries

            Dictionary<char, string> keyValuePairs = new Dictionary<char, string>();
            keyValuePairs.Add('j', "Josh");

            //others
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();
        }

    }
}
