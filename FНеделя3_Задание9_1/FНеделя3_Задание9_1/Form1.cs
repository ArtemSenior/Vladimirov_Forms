using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FНеделя3_Задание9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double readDouble()
        {
            //  ввод
            double result;
            bool parsed = double.TryParse(textBox1.Text, out result);
            if (parsed) return result;
            else
            {
                MessageBox.Show("Ошибка. Введите степень 3: ");
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";


            bool a = true;
            double s = 0;
            s = readDouble();
            if (s < 0)
            {
                richTextBox1.Text = "Введите корректную степень числа 3!";
                a = false;
            }
            while (a)
            {
                


                if (s != 0)
                {
                    using (StreamWriter sw = new StreamWriter(@"E:\ПРАКТИКА\Неделя 3\CНеделя3_Задание9_1\zad9.txt"))
                    {
                        for (double i = 0; i <= s; i++)
                        {
                            sw.WriteLine(i + ") " + Math.Pow(3, i));
                            
                        }
                    }
                    using (StreamReader sr = new StreamReader(@"E:\ПРАКТИКА\Неделя 3\CНеделя3_Задание9_1\zad9.txt"))
                    {
                        string str1;
                        str1 = sr.ReadToEnd();
                        string[] str = str1.Split('\n');

                        for (int i = 0; i < str.Length; i++)
                        {
                            if (i % 2 == 0)
                            {
                                richTextBox1.Text += str[i];
                            }
                        }
                        break;



                    }
                }
            }
        }
    }
}

