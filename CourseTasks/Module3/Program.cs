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
            int number;

            Console.WriteLine("Please enter a number");
            bool success = Int32.TryParse(Console.ReadLine(), out number);
            if (!success)
            {
                Console.WriteLine("Failed to parse input");
                Console.ReadKey();
                return;
            }

            fibIterative(number);        // Iterative
            fibRecursPrintSeq(number);   // Recursion
            fibTailRecursion(number);    // TailRecursion            

            Console.WriteLine("\nCompleted...");
            Console.ReadKey();
        }


        //Recursive
        public static void fibRecursPrintSeq(int n)
        {
            int[] values = new int[n];
            fibSeqRecurs(n - 1, ref values);
            for (int i = 0; i < n; i++)
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

        //Tail recursion
        public static int fibTailRecursion(int n, int a = 0, int b = 1)
        {
            Console.WriteLine(a);
            if (n>1)
            {                
                return fibTailRecursion(n - 1, b, a + b);                
            }
            
            return a;
        }

        //Iterative
        public static int fibIterative(int n)
        {
            int a = 0; 
            int b = 1;
            int result = 0;

            Console.WriteLine(0);
            if (n == 0) return 0; 
            Console.WriteLine(1);
            if (n == 1) return 1; 

            for (int i = 2; i < n; i++)
            {
                result = a + b;
                a = b;
                b = result;
                Console.WriteLine(result);
            }

            return result;
        }
    }
}