using System;
using System.Collections.Generic;
using System.Linq;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Logic
{
    [TestClass]
    public class Test_SortClass
    {
        private static int KeySum(double[] array, double[] brray)
        {
            int result = 0;
            if (array.Sum() > brray.Sum())
                result = 1;
            if (array.Sum() < brray.Sum())
                result = -1;
            return result;
        }

        private static int KeyMax(double[] array, double[] brray)
        {
            int result = 0;
            if (Math.Abs(array.Max()) > Math.Abs(brray.Max()))
                result = 1;
            if (Math.Abs(array.Max()) < Math.Abs(brray.Max()))
                result = -1;
            return result;
        }

        [TestMethod]
        public void Test_SortWithDelegate_KeySum()
        {
            double[][] a = new double[3][];
            a[0] = new double[2] { 2, 2 };
            a[1] = new double[2] { 3, 3 };
            a[2] = new double[3] { 1, 1, 1 };
            SortClass.SortWithDelegate(a, KeySum);
            CollectionAssert.AreEqual(a[0], new double[3] { 1, 1, 1 });
            CollectionAssert.AreEqual(a[1], new double[2] { 2, 2 });
            CollectionAssert.AreEqual(a[2], new double[2] { 3, 3 });
        }

        [TestMethod]
        public void Test_SortWithDelegate_KeyMax()
        {
            double[][] a = new double[3][];
            a[0] = new double[2] { 2, 2 };
            a[1] = new double[2] { 3, 3 };
            a[2] = new double[3] { 1, 1, 1 };
            SortClass.SortWithDelegate(a, KeyMax);
            CollectionAssert.AreEqual(a[0], new double[3] { 1, 1, 1 });
            CollectionAssert.AreEqual(a[1], new double[2] { 2, 2 });
            CollectionAssert.AreEqual(a[2], new double[2] { 3, 3 });
        }

        [TestMethod]
        public void Test_SortWthInterface_KeyMax()
        {
            double[][] a = new double[3][];
            a[0] = new double[2] { 2, 2 };
            a[1] = new double[2] { 3, 3 };
            a[2] = new double[3] { 1, 1, 1 };
            IComparer<Double[]> comparer = new SumComparer();
            SortClass.SortWithInterfaces(a, comparer);
            CollectionAssert.AreEqual(a[0], new double[3] { 1, 1, 1 });
            CollectionAssert.AreEqual(a[1], new double[2] { 2, 2 });
            CollectionAssert.AreEqual(a[2], new double[2] { 3, 3 });
        }

        [TestMethod]
        public void Test_SortWthInterface_KeySum()
        {
            double[][] a = new double[3][];
            a[0] = new double[2] { 2, 2 };
            a[1] = new double[2] { 3, 3 };
            a[2] = new double[3] { 1, 1, 1 };
            IComparer<Double[]> comparer = new MaxComparer();
            SortClass.SortWithInterfaces(a, comparer);
            CollectionAssert.AreEqual(a[0], new double[3] { 1, 1, 1 });
            CollectionAssert.AreEqual(a[1], new double[2] { 2, 2 });
            CollectionAssert.AreEqual(a[2], new double[2] { 3, 3 });
        }

        [TestMethod]
        public void Test_Sort_AcceptedDelegate_KeyMax()
        {
            double[][] a = new double[3][];
            a[0] = new double[2] { 2, 2 };
            a[1] = new double[2] { 3, 3 };
            a[2] = new double[3] { 1, 1, 1 };
            SortClass.Sort(a, KeyMax);
            CollectionAssert.AreEqual(a[0], new double[3] { 1, 1, 1 });
            CollectionAssert.AreEqual(a[1], new double[2] { 2, 2 });
            CollectionAssert.AreEqual(a[2], new double[2] { 3, 3 });
        }

        [TestMethod]
        public void Test_Sort_AcceptedDelegate_KeySum()
        {
            double[][] a = new double[3][];
            a[0] = new double[2] { 2, 2 };
            a[1] = new double[2] { 3, 3 };
            a[2] = new double[3] { 1, 1, 1 };
            SortClass.Sort(a, KeySum);
            CollectionAssert.AreEqual(a[0], new double[3] { 1, 1, 1 });
            CollectionAssert.AreEqual(a[1], new double[2] { 2, 2 });
            CollectionAssert.AreEqual(a[2], new double[2] { 3, 3 });
        }

        [TestMethod]
        public void Test_Sort_AcceptedInterfase_KeyMax()
        {
            double[][] a = new double[3][];
            a[0] = new double[2] { 2, 2 };
            a[1] = new double[2] { 3, 3 };
            a[2] = new double[3] { 1, 1, 1 };
            IComparer<Double[]> comparer = new MaxComparer();
            SortClass.Sort(a, comparer);
            CollectionAssert.AreEqual(a[0], new double[3] { 1, 1, 1 });
            CollectionAssert.AreEqual(a[1], new double[2] { 2, 2 });
            CollectionAssert.AreEqual(a[2], new double[2] { 3, 3 });
        }

        [TestMethod]
        public void Test_Sort_AcceptedInterfase_KeySum()
        {
            double[][] a = new double[3][];
            a[0] = new double[2] { 2, 2 };
            a[1] = new double[2] { 3, 3 };
            a[2] = new double[3] { 1, 1, 1 };
            IComparer<Double[]> comparer = new SumComparer();
            SortClass.Sort(a, comparer);
            CollectionAssert.AreEqual(a[0], new double[3] { 1, 1, 1 });
            CollectionAssert.AreEqual(a[1], new double[2] { 2, 2 });
            CollectionAssert.AreEqual(a[2], new double[2] { 3, 3 });
        }
    }
}
