using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Fraction
    {
        public int numerator;
        public int denumerator;

        public Fraction ()
        {
            numerator = 0;
            denumerator = 0;
        }

        public Fraction (int numerator, int denumerator)
        {
            this.numerator = numerator;
            this.denumerator = denumerator;
        }

        public int nod (Fraction fraction)
        {
            int n = fraction.numerator;
            int d = fraction.denumerator;
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    var temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            return 1;
        }

        public static Fraction reduction (Fraction fraction)
        {
            int nod = fraction.nod(fraction);
            fraction.numerator = fraction.numerator / nod;
            fraction.denumerator = fraction.denumerator / nod;
            return fraction;
        }
    }
}
