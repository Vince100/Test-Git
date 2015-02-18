using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!!!");

            TestMain testMain = new TestMain();
            testMain.DoTheJob();

            // Added Sprint 2 functionality Blabla

            Console.WriteLine("Hit return to terminate");
            Console.ReadLine();
        }
    }
}
