using System;

namespace FirstTaskOfTheSecondOption.FifthLaba
{
    public class Time
    {
        private int _hour;
        private int _minute;
        private int _second;
        
        public Time(int hour, int minute, int second)
        {
            _hour = CheckHourValue(hour);
            _minute = CheckMinuteValue(minute);
            _second = CheckSecondValue(second);
        }
        private int CheckHourValue(int hour)
        {
            if (hour<0 || hour >= 24)
            {
                return 0;
            }

            return hour;
        }
        private int CheckMinuteValue(int minute)
        {
            if (minute<0 || minute >= 60)
            {
                return 0;
            }

            return minute;
        }
        private int CheckSecondValue(int second)
        {
            if (second<0 || second >= 60)
            {
                return 0;
            }

            return second;
        }
        public  void Print()
        {
            Console.WriteLine("{0}:{1}:{2}",_hour,_minute,_second);
        }

        public void Change(int hour = 0, int minute = 0, int second = 0)
        {
            if (hour!=0)
            {
                _hour = CheckHourValue(_hour+hour);
            }
            if (minute!=0)
            {
                _minute = CheckHourValue(_minute+minute);
            }
            if (second!=0)
            {
                _second = CheckHourValue(_second+second);
            }
        }

        public int Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        public int Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }

        public int Second
        {
            get { return _second; }
            set { _second = value; }
        }
    }
}