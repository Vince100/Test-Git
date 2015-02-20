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
            // Hotfix 1 code

            // Implement new feature
            // Issue 2 
            TestMain testMain = new TestMain();
            testMain.DoTheJob();

            Console.WriteLine("Hit return to terminate");
            Console.ReadLine();
        }
    }
}
