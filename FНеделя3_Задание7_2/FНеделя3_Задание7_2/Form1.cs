using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FНеделя3_Задание7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            try
            {
                string a = Convert.ToString(richTextBox1.Text);

                int n = Convert.ToInt32(richTextBox2.Text);

                string[] nstring;
                nstring = a.Split(' ');
                for (int i = 0; i < nstring.Length; i++)
                {
                    if (nstring[i].Length > n)
                    {
                        richTextBox3.Text += ("");
                    }
                    else
                    {
                        richTextBox3.Text += ("Слово, которое меньше чем n: " + nstring[i] + "\n");
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Неверный формат");
            }
        }
    }
}
