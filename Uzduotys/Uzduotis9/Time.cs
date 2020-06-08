using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys.Uzduotis9
{
    class Time
    {
        private int Hours;
        private int Minutes;
        private int Seconds;
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public void PrintTime()
        {
            Console.WriteLine("The time is now: {0}:{1}:{2}", 
                Hours < 10 ? "0" + Hours.ToString() : Hours.ToString(), 
                Minutes < 10 ? "0" + Minutes.ToString() : Minutes.ToString(), 
                Seconds < 10 ? "0" + Seconds.ToString() : Seconds.ToString());
        }

        public void AddSecond()
        {
            if (Seconds == 59)
            {
                Seconds = 0;
                if (Minutes == 59)
                {
                    Minutes = 0;

                    if (Hours == 23)
                    {
                        Hours = 0;
                    }
                    else
                    {
                        Hours++;
                    }
                }
                else
                {
                    Minutes++;
                }
            }
            else
            {
                Seconds++;
            }
        }

        public void AddMinute()
        {
            if (Minutes == 59)
            {
                Minutes = 0;
                if (Hours == 23)
                {
                    Hours = 0;
                }
                else
                {
                    Hours++;
                }
            }
            else
            {
                Minutes++;
            }
        }

        public void AddHour()
        {
            if (Hours == 23)
            {
                Hours = 0;
            }
            else
            {
                Hours++;
            }
        }
    }
}
