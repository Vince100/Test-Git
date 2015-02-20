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

            TestMain testMain = new TestMain();
            testMain.DoTheJob();

            Console.WriteLine("Hit return to terminate");
            Console.ReadLine();
        }
    }
}
