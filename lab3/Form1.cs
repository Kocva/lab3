using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNum.Text, out int Num) ||
                !int.TryParse(tbDenum.Text, out int Denum))
            {
                MessageBox.Show("Вы неверно ввели число или оставили поле пустым!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Fraction fraction = new Fraction(Num, Denum);
            fraction.reduction();
            tbNum.Text = fraction.numerator.ToString();
            tbDenum.Text = fraction.denumerator.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNum1.Text, out int firstNum) ||
                !int.TryParse(tbDenum1.Text, out int firstDenum) ||
                !int.TryParse(tbNum2.Text, out int secondNum) ||
                !int.TryParse(tbDenum2.Text, out int secondDenum))
            {
                MessageBox.Show("Вы неверно ввели число или оставили поле пустым!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fraction first = new(firstNum, firstDenum);
            Fraction second = new(secondNum, secondDenum);

            if (comboBox1.Text == "сложение")
            {
                Fraction answer = (first + second);
                tbRes1.Text = (answer.numerator).ToString();
                tbRes2.Text = (answer.denumerator).ToString();
            }
            else if (comboBox1.Text == "вычитание")
            {
                Fraction answer = (first - second);
                tbRes1.Text = (answer.numerator).ToString();
                tbRes2.Text = (answer.denumerator).ToString();
            }
            else if (comboBox1.Text == "умножение")
            {
                Fraction answer = (first * second);
                tbRes1.Text = (answer.numerator).ToString();
                tbRes2.Text = (answer.denumerator).ToString();
            }
            else if (comboBox1.Text == "деление")
            {
                Fraction answer = (first / second);
                tbRes1.Text = (answer.numerator).ToString();
                tbRes2.Text = (answer.denumerator).ToString();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbNum3.Text, out int firstNum) ||
                !int.TryParse(tbDenum3.Text, out int firstDenum) ||
                !int.TryParse(tbNum4.Text, out int secondNum) ||
                !int.TryParse(tbDenum4.Text, out int secondDenum))
            {
                MessageBox.Show("Вы неверно ввели число или оставили поле пустым!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Fraction first = new(firstNum, firstDenum);
            Fraction second = new(secondNum, secondDenum);

            string str = (first == second);
            label4.Text = str;

        }
    }
}
