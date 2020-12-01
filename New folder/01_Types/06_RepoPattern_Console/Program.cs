using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepoPattern_Console
{
    //Program.cs file: each method should have a single responsibility

    class Program
    {
        static void Main(string[] args)
            //the responsibility of the Main method is:
            //start the application
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }
}
