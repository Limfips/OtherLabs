using System;
using System.IO;

namespace ThirdTaskOfTheThirdOption.FifthLaba
{
    internal class Program
    {
        private const string SourceFilePath = "e:\\in.txt";
        private const string OutputFilePath = "e:\\out.txt";

        public static void Main(string[] args)
        {
            Students students = new Students(GetListStudents());
            Console.WriteLine("Список создан!");

            Students.SortByAverageScore(students);
            WriteToFileStudents(students);
            Console.WriteLine("Файл записан!");
        }
        private static Student[] GetListStudents()
        {
            var file = new StreamReader(SourceFilePath);
            int n = Convert.ToInt32(file.ReadLine());
            Student[] students = new Student[n];
            string fileLine;
            int pos = 0;
            while ((fileLine = file.ReadLine()) != null)
            {
                students[pos++] = GetNewStudent(fileLine);
            }
            file.Close();
            return students;
        }
        private static Student GetNewStudent(string fileLine)
        {
            var simSent = fileLine.Split(' ');
            Student student = new Student(simSent[1], simSent[0],
                Convert.ToInt32(simSent[2]), Convert.ToInt32(simSent[3]),
                Convert.ToInt32(simSent[4]));
            return student;
        }
        private static void WriteToFileStudents(Students students)
        {
            StreamWriter file = new StreamWriter(OutputFilePath);

            var quantity = students.GetQuantity();
            for (int index = 0; index < quantity; index++)
            {
                file.WriteLine(students.GetByIndex(index).GetName());
            }
            file.Close();
        }
    }
}