using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

                int n;
                int b = 60;
                int i = 0;
                do
                {
                    try
                    {
                        n = Convert.ToInt32(textBox1.Text);
                        if (n >= 1 && n <= 25)
                        {
                            break;
                        }
                        MessageBox.Show("Введите числа от 1 до 25");
                    return; 
                    }
                    catch (Exception)
                    {
                    MessageBox.Show("Введите целые числа!");
                    return;
                }
                }
                while (true);
            richTextBox1.Text += "for";

                for (; i <= n; b = b - 2, i++)
                {
                richTextBox1.Text += "\nОперация№" + i + "  " + b;

                }

            richTextBox1.Text += "\nwhile";

                i = 0;
                b = 60;
                while (i <= n)
                {
                richTextBox1.Text += "\nОперация№" + i + "  " + b;

                i++;
                    b = b - 2;
                }

            richTextBox1.Text += "\ndo while";

                i = 0;
                b = 60;
                do
                {
                richTextBox1.Text += "\nОперация№" + i + "  " + b;
                i++;
                    b = b - 2;
                }
                while (i <= n);
            
        }
    }
}