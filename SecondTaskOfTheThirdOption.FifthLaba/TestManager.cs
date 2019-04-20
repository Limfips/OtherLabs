using System;
using System.Collections.Generic;

namespace SecondTaskOfTheThirdOption.FifthLaba
{
    public class TestManager
    {
        private readonly Question[] _questions = new List().Questions;
        private readonly int _qty;

        public TestManager(int quantity)
        {
            _qty = quantity;
        }

        public Test[] GetTests()
        {
            Test[] tests = new Test[_qty];
            Console.WriteLine();

            for (int i = 0; i < _qty; i++)
            {
                Test test = new Test();
                var j = i;
                for (; j < _questions.Length; j+=_qty)
                {
                    test.AddQuestion(_questions[j]);
                }
                tests[i] = test;
            }

            return tests;
        }

        public void ShowTests(Test[] tests)
        {
            foreach (var test in tests)
            {
                Console.WriteLine("Тест----------------");
                for (int j = 0; j < test.GetQuantity(); j++)
                {
                    test.GetQuestionByIndex(j).Show();
                }
                Console.WriteLine("------------------");
            }
        }
    }
}