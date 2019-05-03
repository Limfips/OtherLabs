using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lab_6_v_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите кол-во вопросов: ");
            var n = Convert.ToInt32(Console.ReadLine());
            var x = TestManager.TestGenerator(ref n);
            Console.WriteLine(x[0].Questions[0]);
        }
    }

    public class QuestionClass
    {
        public string Question { get; set; }

        public enum Theme
        {
            Theme1 = 1,
            Theme2 = 2,
            Theme3 = 2
        }
        public string OptionalAnswers { get; set; }
        public string CorrectAnswer { get; set; }
        
    }

    public class TestClass
    {
        public string[] Questions { get; set; }
        // Хранит в себе список вопросов
    }

    public class TestManager
    {
        public static string[] ListOfAllQuestions = {"1. Как тебя зовут?" +
                                                     "2. Что ты за человек?" +
                                                     "3. Кто ты по знаку?" +
                                                     "4. Ну в общем пока?" +
                                                     "5. Я тебя не знаю?"};

        public static string[] GetListOfAllQuestions()
        {
            return ListOfAllQuestions;
            // Возвращает список всех вопросов!
        }


        public static List<TestClass> TestGenerator(ref int n)
        {
            //    формирует Тесты - то есть возвращает списк (массив)
            //    экземпляров класса Test, в которые он помещает нужные вопросы
            
            var tests = new List<TestClass>();

            var test = new TestClass();
            var x = new[] {"Ehf!","TTTT"};
            test.Questions = x;
            tests.Add(test);
            
            return tests;
        }
        
        public static string AddingQuestion(ref int i)
        {
            return ListOfAllQuestions[i];
        }
    }
}