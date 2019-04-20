using System;

namespace FirstTaskOfTheSecondOption.FifthLaba
{
    public class Start
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Первое время:");
            var firstTime = new Time(0,0,0);
            firstTime.Print();
            firstTime.Change(hour:+3,second:+3);
            firstTime.Print();
            Console.WriteLine("Второе время:");
            var secondTime = new Time(6,2,3);
            secondTime.Print();
            secondTime.Change(hour:-3,minute:+3);
            secondTime.Print();
            Console.WriteLine("Третье время:");
            var thirdTime = new Time(12,12,12);
            thirdTime.Print();
            thirdTime.Change(hour:-3,minute:12,second:+3);
            thirdTime.Print();
        }
        
    }  
}