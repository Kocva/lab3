using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void ReductionTest()
        {
            
            Fraction result = new Fraction(10, 30);
            result.reduction();
            string str = result.numerator.ToString();
            string str2 = result.denumerator.ToString();
            str += " ";
            str += str2;
            
            Assert.AreEqual("1 3", str);
        }

        [TestMethod()]
        public void AdditionTest()
        {

            Fraction first = new Fraction(1, 30);
            Fraction second = new Fraction(4, 15);
            Fraction result = (first + second);
            string str = result.numerator.ToString();
            string str2 = result.denumerator.ToString();
            str += " ";
            str += str2;

            Assert.AreEqual("3 10", str);
        }
        [TestMethod()]
        public void SubtractionTest()
        {

            Fraction first = new Fraction(10, 30);
            Fraction second = new Fraction(2, 15);
            Fraction result = (first - second);


            Assert.AreEqual(new Fraction(1, 5), result);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {

            Fraction first = new Fraction(10, 30);
            Fraction second = new Fraction(2, 15);
            Fraction result = (first * second);
            string str = result.numerator.ToString();
            string str2 = result.denumerator.ToString();
            str += " ";
            str += str2;

            Assert.AreEqual("2 45", str);
        }

        [TestMethod()]
        public void DivisionTest()
        {

            Fraction first = new Fraction(10, 30);
            Fraction second = new Fraction(2, 15);
            Fraction result = (first / second);
            string str = result.numerator.ToString();
            string str2 = result.denumerator.ToString();
            str += " ";
            str += str2;

            Assert.AreEqual("5 2", str);
        }

        [TestMethod()]
        public void ComparsionTrueTest()
        {

            Fraction first = new Fraction(10, 30);
            Fraction second = new Fraction(5, 15);
            string str = (first == second);
            

            Assert.AreEqual("Дроби равны", str);
        }

        [TestMethod()]
        public void ComparsionFalseTest()
        {

            Fraction first = new Fraction(11, 30);
            Fraction second = new Fraction(5, 15);
            string str = (first == second);


            Assert.AreEqual("Дроби не равны", str);
        }
    }
}