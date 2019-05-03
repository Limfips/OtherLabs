using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lab_5_v_2._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many tests do you need?");
            var quantityTest = Convert.ToInt32(Console.ReadLine());
            var tests = new TestManager().TestGenerator(ref quantityTest);
            Console.WriteLine("Tests generated!");
        }
    }

    public class QuestionClass
    {
        public string question { get; set; }

        public enum Theme
        {
            Theme1,
            Theme2,
            Theme3
        }

        public Theme theme { get; set; }

        public string optionalAnswers { get; set; }
        public int correctAnswer { get; set; }
    }

    public class TestClass
    {
        public QuestionClass[] Questions { get; set; }
        // Хранит в себе список вопросов
    }

    public class TestManager
    {
        public QuestionClass[] ListOfAllQuestions =
        {
            new TestQuestionsClass().Q1_1,
            new TestQuestionsClass().Q1_2,
            new TestQuestionsClass().Q1_3,
            new TestQuestionsClass().Q2_1,
            new TestQuestionsClass().Q2_2,
            new TestQuestionsClass().Q2_3,
            new TestQuestionsClass().Q3_1,
            new TestQuestionsClass().Q3_2,
            new TestQuestionsClass().Q3_3,
            new TestQuestionsClass().Q3_4,
            new TestQuestionsClass().Q3_5
        };

        public int ArrayLength = 2;

        public List<TestClass> TestGenerator(ref int quantityTest)
        {
            //    формирует Тесты - то есть возвращает списк (массив)
            //    экземпляров класса Test, в которые он помещает нужные вопросы

            var tests = new List<TestClass>();

            var quantityAllQuestion = ListOfAllQuestions.Length;
            var n = quantityAllQuestion / quantityTest;
            var remainder = quantityAllQuestion % (n * quantityTest);

            for (var i = 0; i < quantityTest; i++)
            {
                var test = new TestClass();

                if (remainder != 0)
                {
                    ArrayLength = n + 1;
                    remainder -= 1;
                }
                else
                {
                    ArrayLength = n;
                }

                var indexItem = i;
                var massQ = new QuestionClass[ArrayLength];
                for (var j = 0; j < ArrayLength; j++)
                {
                    massQ[j] = AddingQuestion(indexItem);
                    indexItem += quantityTest;
                }

                test.Questions = massQ;
                tests.Add(test);
            }

            return tests;
        }

        public static QuestionClass AddingQuestion(int i)
        {
            var x = new TestManager().ListOfAllQuestions[i];

            return x;
        }
    }

    
    // Класс хранящий в себе список всех вопросов
    class TestQuestionsClass
    {
        public QuestionClass Q1_1 = new QuestionClass
        {
            question = "1-1",
            theme = QuestionClass.Theme.Theme1,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q1_2 = new QuestionClass
        {
            question = "1-2",
            theme = QuestionClass.Theme.Theme1,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q1_3 = new QuestionClass
        {
            question = "1-3",
            theme = QuestionClass.Theme.Theme1,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q2_1 = new QuestionClass
        {
            question = "2-1",
            theme = QuestionClass.Theme.Theme2,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q2_2 = new QuestionClass
        {
            question = "2-2",
            theme = QuestionClass.Theme.Theme2,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q2_3 = new QuestionClass
        {
            question = "2-3",
            theme = QuestionClass.Theme.Theme2,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q3_1 = new QuestionClass
        {
            question = "3-1",
            theme = QuestionClass.Theme.Theme3,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q3_2 = new QuestionClass
        {
            question = "3-2",
            theme = QuestionClass.Theme.Theme3,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q3_3 = new QuestionClass
        {
            question = "3-3",
            theme = QuestionClass.Theme.Theme3,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q3_4 = new QuestionClass
        {
            question = "3-4",
            theme = QuestionClass.Theme.Theme3,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };

        public QuestionClass Q3_5 = new QuestionClass
        {
            question = "3-5",
            theme = QuestionClass.Theme.Theme3,
            optionalAnswers = "1)  2)  3)",
            correctAnswer = 1
        };
    }
}