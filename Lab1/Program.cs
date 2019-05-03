using System;
using System.Xml;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        
        private static void Ex1_1()
        {
            var x = int.Parse(Console.ReadLine());
            x = x * x;
            var temp = x;
            x = x * temp;
            x = x * temp;
            Console.WriteLine(x);
        }
        private static void Ex1_2()
        {
            var x = int.Parse(Console.ReadLine());
            x = x * x;
            x = x * x;
            x = x * x;
            Console.WriteLine(x);
        }
        private static void Ex1_3()
        {
            var x = int.Parse(Console.ReadLine());
            var temp1 = x;
            x = x * x;
            var temp2 = x;
            x = x * temp2;
            x = x * temp2;
            x = x * temp1;
            Console.WriteLine(x);
        }

        private static void Ex2_1()
        {
            var x = int.Parse(Console.ReadLine());
            var result = x / 10;
            Console.WriteLine(result);
        }
        private static void Ex2_2()
        {
            var x = int.Parse(Console.ReadLine());
            var y = Convert.ToInt32(x.ToString()[0]);
            var num1 = x.ToString()[0]-48;
            var num2 = x.ToString()[1]-48;
            var num3 = x.ToString()[2]-48;
            Console.WriteLine(num1+num2+num3);
        }
        private static void Ex2_3()
        {
            var x = 32.975;
            x = x % 1;
            var d = (int) (x * 10);
            Console.WriteLine(d);
        }
        
        private static void Ex3_1(int m,int n,int p,int a,int b,int c,int d,int e)
        {
            var step = a/Math.Pow(b, 2 * p);
            var step2 = (123+527*step)*(123-527*step);
            var step3 = 856 + Math.Pow(c, n) * Math.Pow(d,m);
            var step4 = Math.Pow(step3,1.0/3.0);
            var step5 = step4*(e-Math.Log10(6));
            var step6 = step2 / step5;
            var x = step6;
            const int time = 7+12+25+21+65;
            Console.WriteLine("Итог выражения: "+x+"\nВремя в ус: "+time);
        }
        private static void Ex3_2(int m,int n,int p,int a,int b,int c,int d,int e)
        {
            var step = 52.7*Math.Pow(a,n)/Math.Pow(b,2.5);
            var step2 = Math.Pow(2,1.0/n)*(12.3+step)*(12.3-step);
            var step3 = Math.Log(Math.Sqrt(123.5+Math.Sin(Math.Pow(e,m))))-Math.Cos(Math.Pow(d,p)*c);
            var x = step2/step3;
            const int time = 4+12+20+21+117;
            Console.WriteLine("Итог выражения: "+x+"\nВремя в ус: "+time);
        }
        private static void Ex3_3(int m,int n,int p,int a,int b,int c,int d,int e)
        {
            var step = b*c/Math.Pow(d,m);
            var step2 = Math.Pow(2,n)*(Math.Sin(a)+Math.Cos(step))*(Math.Sin(a)-Math.Cos(step));
            var step3 = Math.Log10(Math.Pow(a+step,1.0/3.0))-e/Math.Pow(2,p);
            var x = step2/step3;
            const int time = 4+9+15+28+117;
            Console.WriteLine("Итог выражения: "+x+"\nВремя в ус: "+time);
        }

        private static void Ex4_1()
        {
            const double minDistanseMarsToEathKm = 55.75; // млн. км
            var minDistanseMarsToEathM = minDistanseMarsToEathKm*Math.Pow(10,9); // в метры
            var minDistanseMarsToEathArshin = minDistanseMarsToEathM*0.7112;     // в аршинах
            Console.WriteLine(minDistanseMarsToEathArshin);
        }

        private static void Ex4_2(double height = 9) // в км
        {
            const int radius = 6371; //Радиус Земли в км
            var s = Math.Pow(Math.Pow(radius+height,2)-Math.Pow(radius,2),1.0/2.0); //Растояние до горизонта
            Console.WriteLine((int)s); //330км примерное расстояние между островами 
               // Выходит так что увидит остров он только с высоты в 9км+-
        }

        private static void Ex4_3(int disk = 1)
        {
            /*
             *     Скорость собаки 12 км\ч
             *     Скорость сети 1гигабитэ\с (1террабайт = 8000гигабит)
             *     Найти расстаяние, для того чтобы перестать использовать собак
             * 
             */
            int dataVolume = disk*8000;
            const int speed = 12;
            var rezult = Math.Ceiling(speed*dataVolume / 3600.0);
            Console.WriteLine("На расстоянии больше "+rezult+" должны находиться офисы,"+ 
                              "чтобы сравнительно выгоднее (с точки зрения времени передачи)"+
                              " было передавать данные по оптоволоконной сети");
        }
    }
}