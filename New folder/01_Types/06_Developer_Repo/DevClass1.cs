using System;

namespace _06_Developer_Repo
{
    public class DevClass1
    {
        //Plain Old C# Object//

        public string Name { get; set; }
        public int IDs { get; set; }
        public bool AccessToPluralsight { get; set; }

        public DevClass1() { }
        public DevClass1(string name, int ids, bool accessToPluralsight)
        {
            Name = name;
            IDs = ids; 
            AccessToPluralsight = accessToPluralsight;

        }

    }
}
