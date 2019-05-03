using System;

namespace SecondTaskOfTheThirdOption
{
    internal class Program
    {

        public static void Main(string[] args)
        {
           
            int arrayLength = Convert.ToInt32(Console.ReadLine()); 
            int?[] array = new int?[arrayLength];
            var random = new Random();    
            for (var i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(0, 10);
            }
            Print(array);
           
            int itemIndex = Convert.ToInt32(Console.ReadLine());
            Remove(array,itemIndex);
            Print(array);
        }
        private static void Remove(int?[] array,int itemIndex)
        {
            for (int i = itemIndex; i < array.Length - 1; i++)
            {
//                tmp = array[i + 1];
//                array[i + 1] = array[i];
                array[i] = array[i + 1];

                
            }
            array[array.Length-1] = null;
        }
        private static void Print(int?[] arg)
        {
            foreach (var item in arg)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}