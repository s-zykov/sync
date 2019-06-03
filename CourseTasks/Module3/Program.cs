using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{   
    class Program
    {
        static void Main(string[] args)
        {

            //Recursive
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            fibRecursPrintSeq(11);

            //Console.WriteLine("Press any key to start Matrix method");
            //Console.ReadLine();
            //Console.WriteLine("Fibonacci(3) = {0}", Fibonacci_matrix.FibonacciMatrixMethod(4));
            //
            Console.ReadLine();
        }




        public static void fibRecursPrintSeq(int number)
        {
            int[] values = new int[number];
            fibSeqRecurs(number - 1, ref values);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(values[i]);
            }
        }


        private static int fibSeqRecurs(int n, ref int[] values)
        {            
            int value;   
            
            if (n > 1)            
                value = fibSeqRecurs(n - 1, ref values) + fibSeqRecurs(n - 2, ref values);            
            else            
                value = n;

            values[n] = value;
            return value;
        }


        public static int fibRecursMethod(int n)
        {
            return n > 1 ? fibRecursMethod(n - 1) + fibRecursMethod(n - 2) : n;
        }
    }
}
