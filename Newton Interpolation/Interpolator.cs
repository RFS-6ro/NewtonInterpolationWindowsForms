using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Newton_Interpolation
{
    class Interpolator
    {
        private void xVal(Point[] p, double x, int N, double[] product)
        {
            product[0] = 1;
            for (int i = 1; i < N; ++i)
            {
                product[i] = product[i - 1] * (x - p[i - 1].x);
            }
        }

        //private double xVal(Point[] p, double x, int k)
        //{
        //    double product = 1;
        //    for (int i = 0; i < k; ++i)
        //    {
        //        product *= (x - p[i].x);
        //    }
        //    return product;
        //}

        //public double computeNewtonPoly(Point[] p, int N, double x)
        //{
        //    double result = 0;
        //    for (int i = 0; i < N; ++i)
        //    {
        //        result += dividedDifferences(p, 0, i) * xVal(p, x, i);
        //    }
        //    return result;
        //}

        public double computeNewtonPoly(Point[] p, int N, double x, double[] arr)
        {
            double[] product = new double[N];
            xVal(p, x, N, product);
            double result = 0;
            for (int i = 0; i < N; ++i)
            {
                result += arr[i] * product[i];
            }

            return result;
        }
    }
}
