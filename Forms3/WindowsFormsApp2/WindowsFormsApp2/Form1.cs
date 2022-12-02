using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < (Math.PI / 2)) y = Math.Sin(x);
            else if (Math.Abs(x) > Math.PI) y = 0;
            else y = Math.Cos(x);
            return y;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            double a = 0;
            double b = 0;
            double h;

            try
            {

                a = double.Parse(textBox1.Text);


                b = double.Parse(textBox2.Text);

                    h = double.Parse(textBox3.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Вводите числа");
                return;
            }



            for (double i = a; i <= b; i += h)
            {
                richTextBox1.Text += $"f({i:f2})={f(i):f2}" + Environment.NewLine;
            }

        }
    }

}