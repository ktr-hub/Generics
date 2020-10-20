using System;

namespace GenericsProject
{
    public class GenericsMain
    {
        public int getMax(int a,int b,int c)
        {
            int max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            return max;
        }
        static void Main(string[] args)
        {

        }
    }
}
