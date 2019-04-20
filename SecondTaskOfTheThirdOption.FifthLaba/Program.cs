using System;
using System.Collections.Generic;

namespace SecondTaskOfTheThirdOption.FifthLaba
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many tests do you need?");
            var quantity = Convert.ToInt32(Console.ReadLine());
            TestManager testManager = new TestManager(quantity);
            Test[] tests = testManager.GetTests();
            Console.WriteLine("Tests generated!");
            testManager.ShowTests(tests);
        }
    }
}