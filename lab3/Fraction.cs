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

        public int nod(Fraction fraction)
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

        public Fraction reduction(Fraction fraction)
        {
            int nod = fraction.nod(fraction);
            fraction.numerator = fraction.numerator / nod;
            fraction.denumerator = fraction.denumerator / nod;
            return fraction;
        }

        public int newDenum(Fraction first, Fraction second)
        {
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.numerator;
            int d1 = second.denumerator;
            int d2;
            if ((d1 >= d) && (d1 % d == 0))
            {
                d2 = d1;

            }
            else if ((d > d1) && (d % d1 == 0))
            {
                d2 = d;

            }
            else
            {
                d2 = d1 * d;
            }
            return d2;
        }
        public static Fraction operator +(Fraction first, Fraction second)
        {
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.numerator;
            int d1 = second.denumerator;
            int d2 = first.newDenum(first, second);

            int n2 = n * (d2 / d) + n1 * (d2 / d1);

            Fraction result = new Fraction(n2, d2);
            result = result.reduction(result);
            return result;
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.numerator;
            int d1 = second.denumerator;
            int d2 = first.newDenum(first, second);

            int n2 = n * (d2 / d) - n1 * (d2 / d1);

            Fraction result = new Fraction(n2, d2);
            result = result.reduction(result);
            return result;
        }

        public static Fraction operator *(Fraction first, Fraction second)
        {
            
            first.reduction(first);
            second.reduction(second);
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.numerator;
            int d1 = second.denumerator;

            int n2 = n * n1;
            int d2 = d * d1;
            Fraction result = new Fraction(n2, d2);
            result = result.reduction(result);
            return result;
        }

        public static Fraction operator /(Fraction first, Fraction second)
        {
            first.reduction(first);
            second.reduction(second);
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.denumerator;
            int d1 = second.numerator;

            int n2 = n * n1;
            int d2 = d * d1;
            Fraction result = new Fraction(n2, d2);
            result = result.reduction(result);
            return result;
        }

        public string comparison (Fraction first, Fraction second)
        {
            int d2 = first.newDenum(first, second);
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.denumerator;
            int d1 = second.numerator;
            int newN1 = n * (d2 / d);
            int newN2 = n1 * (d2 / d1);
            if (newN1 < newN2)
            {
                return "<";
            }
            else if (newN1 > newN2)
            {
                return ">";
            }
            else if (newN1 == newN2)
            {
                return "=";
            }
            else { return "ошибка"; }
        }

    }
}
