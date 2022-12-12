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

namespace FНеделя2_Задание6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 1 || Convert.ToInt32(textBox2.Text) < 0);
            }
            catch (Exception)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Вводите только числа!");
                return;
            }
            try
            {

                button2.Enabled = true;
                dataGridView1.Visible = true;
                int m = Convert.ToInt32(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                int[,] arr;
                arr = new int[m, n];
                dataGridView1.RowCount = m;
                dataGridView1.ColumnCount = n;

            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            try
            {
                int m = Convert.ToInt32(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                int r = Convert.ToInt32(textBox3.Text);
                int[,] arr;
                arr = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        richTextBox1.Text += ($"{arr[i, j]} ");
                    }
                    richTextBox1.AppendText("\n");
                }
                richTextBox1.AppendText("\n");

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i, j] < r)
                        {
                            arr[i, j] = r;
                        }
                    }
                }

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        richTextBox2.AppendText($"{arr[i, j]} ");
                    }
                    richTextBox2.AppendText("\n");
                }
                richTextBox2.AppendText("\n");
            }
            catch
            {
                MessageBox.Show("Вводите только числа!");
            }
        }
    }
}

