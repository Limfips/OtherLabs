using System;

namespace TaskOfTheFirstOption
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ведите строку: ");
            string userString = Console.ReadLine();
            int quantity = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (quantity == 0)
                {
                    if (userString[i] != ' ')
                    {
                        quantity++;
                    }  
                }
                else
                {
                    if (userString[i]!=' ' && userString[i-1] == ' ')
                    {
                        quantity++;
                    }
                }
            }
            
            Console.Write(quantity);
        }
    }
}