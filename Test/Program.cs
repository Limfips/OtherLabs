using System;

namespace Test 
{ 
    internal class Program 
    { 
        public static void Main(string[] args) 
        { 

            Console.WriteLine("Введите натуральное число n: "); 
            Console.Write("n= ");
            
            Mai();
        } 

        public static void Mai() 

        { 
            var n = Convert.ToDouble(Console.ReadLine()); 
            var f= 1.0; 
            var k = 1; 
            for (var i = 1; i < n; i++) 
            { 
                if (k % 3 == 0) 
                { 
                    k++; 
                } 

                f *= (double) (k + 1) / k; 
// Console.WriteLine("{0}) f = {1}",k, f); 
                k++; 
            } 

            Console.WriteLine("Результат задания: " + f); 
        } 
    } 
}