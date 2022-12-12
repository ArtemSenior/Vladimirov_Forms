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

namespace FНеделя2_Задание6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button3.Enabled = false;
        }
        int[] arr;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox3.Text;
                string[] strings = s.Split(' ');
                arr = new int[strings.Length];
                for (int i = 0; i < strings.Length; i++)
                {
                    arr[i] = Convert.ToInt32(strings[i]);
                }
                richTextBox1.Clear();
                for (int i = 0; i < arr.Length; i++)
                {
                    richTextBox1.Text += ($"{arr[i]}\n");
                }
                button3.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(textBox2.Text);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < k)
                    {
                        arr[i] = k;
                    }
                }
                richTextBox1.Clear();
                for (int i = 0; i < arr.Length; i++)
                {
                    richTextBox1.Text += ($"{arr[i]}\n");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
