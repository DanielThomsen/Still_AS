using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelClass
    {
        public string ClockNow()
        {
            int Hour = DateTime.Now.Hour;
            int Minute = DateTime.Now.Minute;
            int Second = DateTime.Now.Second;

            string time = "";

            if (Hour < 10)
            {
                time += "0" + Hour;
            }
            else
            {
                time += Hour;
            }

            time += ":";

            if (Minute < 10)
            {
                time += "0" + Minute;
            }
            else
            {
                time += Minute;
            }

            time += ":";

            if (Second < 10)
            {
                time += "0" + Second;
            }
            else
            {
                time += Second;
            }
            return time;
        }
        public string ClockNY()
        {
            DateTime DT = DateTime.Now.AddHours(-6);
            int Hour = DT.Hour;
            int Minute = DateTime.Now.Minute;
            int Second = DateTime.Now.Second;
            string time = "";

            if (Hour < 10)
            {
                time += "0" + Hour;
            }
            else
            {
                time += Hour;
            }

            time += ":";

            if (Minute < 10)
            {
                time += "0" + Minute;
            }
            else
            {
                time += Minute;
            }

            time += ":";

            if (Second < 10)
            {
                time += "0" + Second;
            }
            else
            {
                time += Second;
            }
            return time;
        }
        public string BooingIntSpawner(string a)
        {
            string Number = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != ',')
                {
                    Number += a[i];
                }
                else
                {
                    break;
                }
            }
            return Number;
        }
    }
}
