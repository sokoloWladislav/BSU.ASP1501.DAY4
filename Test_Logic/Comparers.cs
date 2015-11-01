using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_Logic
{
    class SumComparer : IComparer<Double[]>
    {
        public int Compare(double[] array, double[] brray)
        {
            int result = 0;
            if (array.Sum() > brray.Sum())
                result = 1;
            if (array.Sum() < brray.Sum())
                result = -1;
            return result;
        }
    }

    class MaxComparer : IComparer<Double[]>
    {
        public int Compare(double[] array, double[] brray)
        {
            int result = 0;
            if (Math.Abs(array.Max()) > Math.Abs(brray.Max()))
                result = 1;
            if (Math.Abs(array.Max()) < Math.Abs(brray.Max()))
                result = -1;
            return result;
        }
    }
}
