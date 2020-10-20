using System;

namespace GenericsProject
{
    public class GenericsMain
    {
        public int getIntMax(int a,int b,int c)
        {
            if(a==b && b == c)
            {
                throw new Exception("All are same");
            }
            int max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            return max;
        }

        public double getDoubleMax(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                throw new Exception("All are same");
            }
            double max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics test case problem...");
        }
    }
}
