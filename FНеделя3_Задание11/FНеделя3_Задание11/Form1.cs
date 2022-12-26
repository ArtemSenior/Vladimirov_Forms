using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FНеделя3_Задание11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            { 
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

                Point point = new Point(x, y);

                MessageBox.Show(point.showPoints());
            }
            catch
            {
                MessageBox.Show("Введите числовые значения");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Point point = new Point(x, y);

            MessageBox.Show(point.showCalculate());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            int a = int.Parse(textBox6.Text);
            int b = int.Parse(textBox5.Text);

            Point point = new Point(x, y);
            Point ab = new Point(a, b);

            MessageBox.Show(point.Moving(a, b));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox10.Text);
            int y = int.Parse(textBox9.Text);

            Point point = new Point(x, y);

            MessageBox.Show($"x = {point.X}  y = {point.Y}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox10.Text);
            int y = int.Parse(textBox9.Text);

            Point point = new Point(x, y);

            int scalar = int.Parse(textBox3.Text);
            point.SkalarX = scalar;
            point.SkalarY = scalar;

            MessageBox.Show(point.showPoints());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            MessageBox.Show(point.showPoints());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            MessageBox.Show(point.showCalculate());
        }

        private void button8_Click(object sender, EventArgs e)
        {

            int a = int.Parse(textBox8.Text);
            int b = int.Parse(textBox7.Text);


            MessageBox.Show ($"Координаты точки после перемещения на вектор (a,b) x: {a}, y: {b}");


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            MessageBox.Show($"x = {point.X}  y = {point.Y}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            int scalar = int.Parse(textBox4.Text);
            point.SkalarX = scalar;
            point.SkalarY = scalar;

            MessageBox.Show(point.showPoints());
        }
    }
}
