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

        public string getStringMax(string aa, string bb, string cc)
        {
            int a = Convert.ToInt32(aa);
            int b = Convert.ToInt32(bb);
            int c = Convert.ToInt32(cc);
            if (a == b && b == c)
            {
                throw new Exception("All are same");
            }
            int max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            
            return max.ToString();
        }

        //Generics Method to get max from int/double/string
        public T getMax<T>(T a,T b,T c) where T : IComparable<T>
        {
            if(a.Equals(b) && b.Equals(c))
            {
                throw new Exception("All are same");
            }
            T max1 = (a.CompareTo(b) > 0) ? a : b;
            T max = (c.CompareTo(max1) > 0) ? c : max1;
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics test case problem...");
        }
    }
}
