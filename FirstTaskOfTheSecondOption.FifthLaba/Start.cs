using System;

namespace FirstTaskOfTheSecondOption.FifthLaba
{
    public class Start
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Первое время:");
                var firstTime = new Time(12,0,72);
                Console.WriteLine(firstTime.ToString());
                firstTime.Minute = -120;
                firstTime.Hour = -56;
                Console.WriteLine(firstTime.ToString());
                Console.WriteLine("Второе время:");
                var secondTime = new Time(6,10,90);
                Console.WriteLine(secondTime.ToString());
                Console.WriteLine("Третье время:");
                var thirdTime = new Time(12,12,12); 
                Console.WriteLine(thirdTime.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка!");
            }
            
        }
        
    }  
}