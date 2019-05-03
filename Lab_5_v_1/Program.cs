using System;
using System.IO;

namespace Lab_5_v_1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            MyClassTimeChangeEx12.MainClass();
            Console.ReadKey();
            Question.MainClass();
            Console.ReadKey();
            MyClassFileEx33.File();
        }
    }

    internal static class MyClassTimeChangeEx12
    {
        private static readonly DateTime Today = DateTime.Now;
        private static readonly int Year = Today.Year;
        private static readonly int Month = Today.Month;
        private static readonly int Day = Today.Day;
        private static int _hour = Today.Hour;
        private static int _minute = Today.Minute;
        private static int _second = Today.Second;

        internal static void MainClass()
        {
            Console.WriteLine("Текущее время: {0:T}", Data());
            DateChangeRequest();
        }

        private static void DateChangeRequest()
        {
            while (true)
            {
                Console.Write("Желаете изменить данные?(Y/N): ");
                var code = Console.ReadLine();
                switch (code)
                {
                    case "Y":
                        VariableSelection();
                        break;
                    case "N":
                        break;
                    default:
                        Console.WriteLine("Неверно введено значение");
                        continue;
                }

                break;
            }
        }

        private static void VariableSelection()
        {
            while (true)
            {
                Console.Write("Какие данные хотите изменить?(h/m/s): ");
                var code = Console.ReadLine();
                switch (code)
                {
                    case "h":
                        TimeVariableChange(ref _hour);
                        break;
                    case "m":
                        TimeVariableChange(ref _minute);
                        break;
                    case "s":
                        TimeVariableChange(ref _second);
                        break;
                    default:
                        Console.WriteLine("Неверно введено значение");
                        continue;
                }

                break;
            }
        }

        private static void TimeVariableChange(ref int item)
        {
            Console.Write("Вводите: ");
            try
            {
                item = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Ошибка, повротире ввод....");
                TimeVariableChange(ref item);
            }
            finally
            {
                Console.WriteLine("\nПосле изменения: {0:T}", Data());
            }
        }

        private static DateTime Data()
        {
            try
            {
                return new DateTime(Year, Month, Day, _hour, _minute, _second);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Вы вышли за диапазон, данные выставлены по умолчанию....");
                return Today;
            }
        }
    }

    internal static class MyClassFileEx33
    {
        internal static void File()
        {
            var fileRead = new StreamReader("e:\\in.txt");

            var n = Convert.ToInt32(fileRead.ReadLine());
            var students = new Student[n];

            for (var i = 0; i < n; i++)
            {
                var text = fileRead.ReadLine();
                var name = GetName(text);

                var averageRating = GetAverageRating(text);

                students[i] = new Student {Name = name, AgeStud = averageRating};
            }

            fileRead.Close();
            foreach (var item in students) Console.WriteLine("Имя:\t{0}\n\tСредний балл:{1}", item.Name, item.AgeStud);

            SortMass(students);
            foreach (var item in students) Console.WriteLine("Имя:\t{0}\n\tСредний балл:{1}", item.Name, item.AgeStud);

            var fileWrite = new StreamWriter("e:\\output.txt");
            WriteFile(fileWrite, students);
            fileWrite.Close();
        }

        private static string GetName(string text)
        {
            var simSent = text.Split(' ');
            var final = simSent[0] + " " + simSent[1];
            return final;
        }

        private static double GetAverageRating(string text)
        {
            var simSent = text.Split(' ');
            var final = Math.Round(
                (double) (Convert.ToInt32(simSent[2]) + Convert.ToInt32(simSent[3]) + Convert.ToInt32(simSent[4])) / 3,
                2);
            return final;
        }

        private static void SortMass(Student[] students)
        {
            Console.WriteLine("Готовая таблица: ");


            for (var i = 0; i < students.Length; i++)
            for (var k = 0; k < students.Length; k++)
            {
                if (!(students[i].AgeStud > students[k].AgeStud)) continue;
                var temp = students[i];
                students[i] = students[k];
                students[k] = temp;
            }
        }

        private static void WriteFile(StreamWriter fileWrite, Student[] students)
        {
            fileWrite.WriteLine(students.Length);
            foreach (var item in students) fileWrite.WriteLine(item.Name + "  " + item.AgeStud);

            Console.WriteLine("Файл записан!");
        }

        private class Student
        {
            public double AgeStud;
            public string Name;
        }
    }

    internal static class Question
    {
        public static string UrlFile = "e://vopros.txt";

        internal static void MainClass()
        {
            const int n = 3; // Кол-во тестов
            CreateTests(n);
        }

        private static void CreateTests(int n)
        {
            var massAllTests = new string[n];

            const int questionsTheme1 = (int) Theme.Theme1;
            const int questionsTheme2 = (int) Theme.Theme2;
            const int questionsTheme3 = (int) Theme.Theme3;
            const int maxQuestions = questionsTheme1 + questionsTheme2 + questionsTheme3;

            var fileReader = new StreamReader(UrlFile);
            for (var question = 0; question < maxQuestions; question++)
            for (var test = 0; test < n; test++)
            {
                massAllTests[test] += fileReader.ReadLine() + "\n";
                question++;
            }

            fileReader.Close();
            Console.WriteLine("Тесты созданы!");
        }

        private enum Theme
        {
            Theme1 = 3,
            Theme2 = 10, // Тут я решил сразу задать количество вопросов
            Theme3 = 9 // в каждой теме
        }
    }
}