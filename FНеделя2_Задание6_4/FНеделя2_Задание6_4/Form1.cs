using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FНеделя2_Задание6_3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int onlyInt(int a)
        {
            do
            {
                try
                {
                    Convert.ToInt32(a);
                    return a;
                }
                catch
                {
                    MessageBox.Show("Вводите только целые числа! Введенное число: ");
                }

            } while (true);
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
            int a = Convert.ToInt32(textBox1.Text);

            string[] arr = null;
            string[] arr2 = null;
            int[][] myArray_1 = new int[a][];

            for (int i = 0; i < a; i++)
                myArray_1[i] = new int[a];

            for (int i = 0; i < a; i++)
            {
                arr = richTextBox2.Text.Split('\n');
                for (; i < a;)
                {
                    arr2 = arr[i].Split(' ');
                    break;
                }
                for (int j = 0; j < a; j++)
                {
                    myArray_1[i][j] = Convert.ToInt32(arr2[j]);
                }
            }




            int n = 0, m = 0;
            bool flag = true;

            while (flag)
            {
                n = onlyInt(a);
                m = n;
                if (n < 1 || m < 1)
                {
                    MessageBox.Show("Введите корректный размер массива!");
                }
                else flag = false;
            }


            int[] rez = new int[n];
            int min;
            for (int j = 0; j < n; j++)
            {
                min = 0;
                for (int i = 0; i < n; i++)
                {
                    if (myArray_1[min][j] > myArray_1[i][j])
                    {
                        min = i;
                    }
                }
                rez[j] = myArray_1[min][j];
            }
            int arzn = rez[n-1];

            richTextBox1.Text += ("Минимальные элементы: " + arzn);

        }
    }
}