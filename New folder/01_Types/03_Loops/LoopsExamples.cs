using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopsExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            //for loops has 4 parts
            //1. Starting point (fires off only once)
            //2. Condition that while true, keeps loop running
            //3. What happens after each loop
            //4. What happens after each iteration

            int studentCount = 15;
            for (int i = 0; i < studentCount; i++)    //i++ means i=i+1
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            //see notebook for steps of For Each Loops (too lazy rn)
            string name = "Eleven Fifty Academy";
            foreach(char letter in name)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;
            while (total !=30)
            {
                Console.WriteLine(total);
                total++;
            }
        }
    }
}
