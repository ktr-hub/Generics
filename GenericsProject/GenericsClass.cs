using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericsProject
{
    public class GenericsClass<T> where T : IComparable<T>
    {
        public T a;
        public T b;
        public T c;
        public GenericsClass(T a,T b,T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static T testMaximum(T a,T b, T c)
        {
            if (a.Equals(b) && b.Equals(c))
            {
                throw new Exception("All are same");
            }
            T max1 = (a.CompareTo(b) > 0) ? a : b;
            T max = (c.CompareTo(max1) > 0) ? c : max1;
            return max;
        }

        public T maxMethod()
        {
            T max = testMaximum(this.a, this.b, this.c);
            return max;
        }

    }
}
