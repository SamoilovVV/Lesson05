using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson05
{
    class MathLib
    {
        public const double PI = 3.141;
        public const double E = 2.81;

        public readonly double K = 11.1;

        public MathLib(double k = -1)
        {
            if (k < 0)
                K = k;
        }
    }
}
