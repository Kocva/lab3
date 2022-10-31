using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Fraction
    {
        public int numerator;
        public int denumerator;

        public override bool Equals(Object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Fraction p = (Fraction)obj;
                return numerator == p.numerator && denumerator == p.denumerator;
            }
        }

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

        public int nod()
        {
            int n = this.numerator;
            int d = this.denumerator;
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

        public void reduction()
        {
            int nod = this.nod();
            this.numerator = this.numerator / nod;
            this.denumerator = this.denumerator / nod;
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
            result.reduction();
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
            result.reduction();
            return result;
        }

        public static Fraction operator *(Fraction first, Fraction second)
        {
            
            first.reduction();
            second.reduction();
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.numerator;
            int d1 = second.denumerator;

            int n2 = n * n1;
            int d2 = d * d1;
            Fraction result = new Fraction(n2, d2);
            result.reduction();
            return result;
        }

        public static Fraction operator /(Fraction first, Fraction second)
        {
            first.reduction();
            second.reduction();
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.denumerator;
            int d1 = second.numerator;

            int n2 = n * n1;
            int d2 = d * d1;
            Fraction result = new Fraction(n2, d2);
            result.reduction();
            return result;
        }

        public static string operator == (Fraction first, Fraction second)
        {
            first.reduction();
            second.reduction();
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.numerator;
            int d1 = second.denumerator;
            string str = "";

            float a = n / d;
            float b = n1 / d1;

            if (n == n1 && d == d1)
            {
                str = "Дроби равны";
            }
            else
            {
                str = "Дроби не равны";
            }


            return str;
        }

        public static string operator !=(Fraction first, Fraction second)
        {
            first.reduction();
            second.reduction();
            int n = first.numerator;
            int d = first.denumerator;
            int n1 = second.numerator;
            int d1 = second.denumerator;
            string str = "";

            float a = n / d;
            float b = n1 / d1;

            if (n != n1 || d != d1)
            {
                str = "Дроби не равны";
            }
            else
            {
                str = "Дроби равны";
            }

            return str;
        }
    }
}
