using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    public struct Timer 
    {
        public const double PI = 3.14;

        public Timer(int hh, int mm, int ss = 0)
        {
            Hours = hh;
            Minutes = mm;
            Seconds = ss;
        }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
}
