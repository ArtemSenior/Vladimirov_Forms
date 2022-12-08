using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double F(double n)
        {
            if (n == 1) return -10;
            if (n == 2) return 2;
            return Math.Abs(F(n - 2)) - 6 * F(n - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            do
            {
                try
                {

                    double x = Convert.ToDouble(textBox1.Text);
                    if (x <= 0)
                    {
                        MessageBox.Show("Нельзя вводить числа меньше 0!");
                        break;
                    }
                    else
                    {
                        richTextBox1.Text += F(x);
                        break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Вводить только числа");
                    break;
                }
            }
            while (true);

        }
    }
}