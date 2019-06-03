using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid test = new Pyramid();
            test.initPyramid(5);
            test.initPyramid(7);
            test.initPyramid(10);

            Console.ReadLine();
        }
    }

    class Pyramid
    {
        private char[,] charMap;
        int width, heigth, middle;

        public void initPyramid(int n)
        {
            charMap = new char[2 * n - 1, n];
            width = charMap.GetLength(0);
            heigth = charMap.GetLength(1);
            middle = n;
            calculateCharMap();
            print();
        }

        private void calculateCharMap()
        {
            for (int j = 0; j < heigth; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    charMap[i, j] = condition(i, j);
                }
            }
        }

        /*Axes:
         *          (middle, 0)
         *          0---^---|-->i
         *          |  /*\  | 
         *          | /***\ |
         *          |/*****\|
         *(0,heigth)/*******\(width, heigth)
         *          |
         *          j
         *          
         * Left and right sides of the pyramide can be defined as a line with equation y = ax + b
         * Left through points (0, height), (middle, 0): j = (-1*i + middle-1)
         * Right through points (middle, 0), (width, heigth): j = (1*i - middle))
        */

        private char condition(int i, int j)
        {
            if (i < middle && j >= (-1 * i + middle - 1))
                return '*';
            if (i >= middle && j > (1 * i - middle))
                return '*';
            return ' ';
        }

        private void print()
        {
            Console.WriteLine("\nn = {0}", heigth);
            for (int j = 0; j < heigth; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write(string.Format("{0} ", charMap[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
        }
    }


}
