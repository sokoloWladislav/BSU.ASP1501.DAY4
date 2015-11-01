using System.Collections.Generic;

namespace Logic
{
    public delegate int Key(double[] array, double[] brray);
    public static class SortClass
    {
        public static void SortWithDelegate(double[][] array, Key key)
        {

            for (int i = 0; i < array.Length - 1; ++i)
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (key(array[j], array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }
        }

        public static void SortWithInterfaces(double[][] array, IComparer<double[]> comparer)
        {
            for (int i = 0; i < array.Length - 1; ++i)
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                        Swap(ref array[j], ref array[j + 1]);
                }
        }

        public static void Sort(double[][] array, Key key)
        {
            Adapter adapter = new Adapter(key);
            SortWithInterfaces(array, adapter);
        }

        public static void Sort(double[][] array, IComparer<double[]> comparer)
        {
            SortWithDelegate(array, comparer.Compare);
        }

        private static void Swap(ref double[] a, ref double[] b)
        {
            double[] temp = a;
            a = b;
            b = temp;
        }
    }
}
