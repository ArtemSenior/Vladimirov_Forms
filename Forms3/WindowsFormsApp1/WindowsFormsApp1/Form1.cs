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

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            double min(double a, double b)
            {
                return (a < b) ? a : b;
            }
            {
                double x = 0, y = 0, z = 0, v = 0;
                do
                {
                    try
                    {
                        
                        x = double.Parse(textBox1.Text);
        
                        y = double.Parse(textBox2.Text);
 
                        z = double.Parse(textBox3.Text);

                        v = double.Parse(textBox4.Text);
                        break;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Вводите только целые числа");
                        break;
                    }
                }
                while (true);

                double q = min(x, y);
                double w = min(z, v);
                double res = min(q, w);

                richTextBox1.Text += res;
            }
        }
    }
}
