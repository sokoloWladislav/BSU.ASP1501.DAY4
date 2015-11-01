using System;
using System.Collections.Generic;

namespace Logic
{
    class Adapter : IComparer<Double[]>
    {
        private Key key;
        public Adapter(Key key)
        {
            this.key = key;
        }

        public int Compare(double[] array, double[] brray)
        {
            return key(array, brray);
        }
    }
}
