using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{   
    class Fibonacci_matrix
    {

        private static readonly matrix2x2 fibMatrix = new matrix2x2(1, 1, 1, 0);
        private static readonly matrix2x2 identityMatrix = new matrix2x2(1, 0, 0, 1);

        private struct matrix2x2
        {
            public int mElem11, mElem12, mElem21, mElem22;
            public matrix2x2(int matrixElem11, int matrixElem12, int matrixElem21, int matrixElem22)
            {
                mElem11 = matrixElem11;
                mElem12 = matrixElem12;
                mElem21 = matrixElem21;
                mElem22 = matrixElem22;
            }

            public static matrix2x2 operator *(matrix2x2 lhs, matrix2x2 rhs)
            {
                return new matrix2x2
                {
                    mElem11 = lhs.mElem11 * rhs.mElem11 + lhs.mElem12 * rhs.mElem21,
                    mElem12 = lhs.mElem11 * rhs.mElem12 + lhs.mElem12 * rhs.mElem22,
                    mElem21 = lhs.mElem21 * rhs.mElem11 + lhs.mElem22 * rhs.mElem21,
                    mElem22 = lhs.mElem21 * rhs.mElem12 + lhs.mElem22 * rhs.mElem22
                };
            }
        }

        private static long IntPower(int x, short power)
        {
            if (power == 0) return 1;
            if (power == 1) return x;
            int n = 15;
            while ((power <<= 1) >= 0) n--;
            long tmp = x;
            while (--n > 0)
                tmp = tmp * tmp *
                     (((power <<= 1) < 0) ? x : 1);
            return tmp;
        }

        private static matrix2x2 IntPower(matrix2x2 x, short power)
        {
            if (power == 0) return identityMatrix;
            if (power == 1) return x;
            int n = 15;
            while ((power <<= 1) >= 0) n--;
            matrix2x2 tmp = x;
            while (--n > 0)
                tmp = (tmp * tmp) * (((power <<= 1) < 0) ? x : identityMatrix);
            return tmp;
        }

        public static int FibonacciMatrixMethod(short n)
        {
            return IntPower(fibMatrix, (short)(n - 1)).mElem11;
        }
    }


}
