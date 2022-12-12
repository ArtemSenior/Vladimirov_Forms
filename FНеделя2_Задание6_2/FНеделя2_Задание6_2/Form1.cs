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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FНеделя2_Задание6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        void printIlement(double[] a, double min)
        {

            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == min)
                {
                    richTextBox2.Text += $"Элемент по номером {i} является минимальным!\n";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            try
            {
                string s = textBox1.Text;
                string[] strings = s.Split(' ');
                double[] arr = new double[strings.Length];
                for (int i = 0; i < strings.Length; i++)
                {
                    arr[i] = Convert.ToDouble(strings[i]);
                }
                richTextBox1.Clear();
                for (int i = 0; i < arr.Length; i++)
                {
                    richTextBox1.Text += ($"{arr[i]}\n");
                }


                double min = arr[0];
                for (int i = 1; i < arr.Length; ++i)
                    if (arr[i] < min) min = arr[i];

                printIlement(arr, min);
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
