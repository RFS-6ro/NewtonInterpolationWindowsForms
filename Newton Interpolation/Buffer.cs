using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Newton_Interpolation
{
    class Buffer
    {
        private double DivDif(double x1, double x2, double y1, double y2)
        {
            return (y2 - y1) / (x2 - x1);
        }

        public double[] DivDifTable(Point[] p, int N)
        {
            double[] array = new double[N];
            double[,] divDifTableBuffer = new double[N, N];
            double[] x = new double[N];
            for (int i = 0; i < N; ++i)
            {
                divDifTableBuffer[i, 0] = p[i].y;
                x[i] = p[i].x;
            }
            for (int j = 1; j < N; ++j)
            {
                for (int i = 0; i < N - j; ++i)
                {
                    divDifTableBuffer[i, j] = DivDif(x[i], x[i + j], divDifTableBuffer[i, j - 1], divDifTableBuffer[i + 1, j - 1]);
                }
            }
            for (int i = 0; i < N; ++i)
            {
                array[i] = divDifTableBuffer[0, i];
            }
            
            return array;
        }
    }
}
