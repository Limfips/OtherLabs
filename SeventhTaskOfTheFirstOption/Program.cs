using System;
using System.Text;

namespace SeventhTaskOfTheFirstOption
{
    internal class Program
    {
        private static readonly char[] ArrayChars = {'a','b','c','d','e','f','g','h','1','2','3','4','5','6','7','?','!',';'};
        public static void Main(string[] args)
        {
            int rowLength = Convert.ToInt32(Console.ReadLine());
            StringBuilder text = GetText(rowLength);
            Console.WriteLine(text.ToString());
            ReplaceChar(text);
            Console.WriteLine(text.ToString());
        }

        private static StringBuilder GetText(int length)
        {
            StringBuilder text = new StringBuilder(length);
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                text.Append(ArrayChars[random.Next(0,ArrayChars.Length)]);
            }
            return text;
        }

        private static void ReplaceChar(StringBuilder text)
        {
            for (var i = 0; i < text.Length; i++)
                if (text[i] == ';')
                    text[i] = '_';
        }
    }
}