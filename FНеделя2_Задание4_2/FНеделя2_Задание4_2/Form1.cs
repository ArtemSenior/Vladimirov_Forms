using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FНеделя2_Задание4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void Rec(double a0, double d, int n, double s, out double an, out double sum)
        {
            an = a0;
            s += a0;
            sum = s;
            if (n == 1) return;
            Rec(a0 + d, d, n - 1, s, out an, out sum);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            do
            {
                double a0 = 0;
                double d = 0;
                int n = 0;
                do
                {
                    try
                    {
                        a0 = double.Parse(textBox1.Text);
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Вводите только числа");
                        break;
                    }
                }
                while (true);

                do
                {
                    try
                    {
                        d = double.Parse(textBox2.Text);
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Вводите только числа");
                        break;
                    }                    
                }                
                while (true);

                do
                {                   
                    try
                    {
                        n = int.Parse(textBox3.Text);
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show ("Введите числа, где n > 1");
                        break;
                    }
                }
                while (true);

                double an, sum;
                Rec(a0, d, n, 0, out an, out sum);
                richTextBox1.Text = ($"An = {an}, sum = {sum}");
                break;

            } while (true);
        }
    }
}


