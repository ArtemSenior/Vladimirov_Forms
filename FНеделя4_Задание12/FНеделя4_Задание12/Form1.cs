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

namespace FНеделя4_Задание12
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
                MessageBox.Show("Введите целочисленные значения");
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

            int a = int.Parse(textBox8.Text);
            int b = int.Parse(textBox7.Text);

            Point point = new Point(x, y);

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
            int a = int.Parse(textBox6.Text);
            int b = int.Parse(textBox5.Text);


            MessageBox.Show($"Координаты точки после перемещения на вектор (a,b) x: {a}, y: {b}");
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

        private void button11_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Point point = new Point(x, y);

            MessageBox.Show($"Обращение по индексу x: {point[0]} y: {point[1]}");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Point point = new Point(x, y);

            point++;
            MessageBox.Show($"При ++ значение увеличивается на 1 x: {point.X} y: {point.Y}");

            point--;
            MessageBox.Show($"При -- значение координат уменьшается на 1 x: {point.X} y: {point.Y}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Point point = new Point(x, y);

            if (point)
                MessageBox.Show("X и Y равны");
            else
                MessageBox.Show("X и Y неравны");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox10.Text);
            int y = int.Parse(textBox9.Text);

            Point point = new Point(x, y);

            try
            {
                int scalar = int.Parse(textBox3.Text);
                point.SkalarX = scalar;
                point.SkalarY = scalar;


                point = point + scalar;
                MessageBox.Show($"При + значение увеличивается на скаляр: x = {point.X} y = {point.Y}");
            }
            catch
            {
                MessageBox.Show("Введите значение скаляра!!!");
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Point point = new Point(x, y);

            string str = (string)point;
            MessageBox.Show($"Преобразование из point в string: {str}");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            Point point = new Point(x, y);

            string str = (string)point;
            point = (Point)str;
            MessageBox.Show($"Преобразование из string в point x: {point.X} y: {point.Y}");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            MessageBox.Show($"Обращение по индексу x: {point[0]} y: {point[1]}");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            point++;
            MessageBox.Show($"При ++ значение увеличивается на 1 x: {point.X} y: {point.Y}");

            point--;
            MessageBox.Show($"При -- значение координат уменьшается на 1 x: {point.X} y: {point.Y}");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            if (point)
                MessageBox.Show("X и Y равны");
            else
                MessageBox.Show("X и Y неравны");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            try
            {
                int scalar = int.Parse(textBox4.Text);
                point.SkalarX = scalar;
                point.SkalarY = scalar;

                MessageBox.Show(point.showPoints());

                point = point + scalar;
                MessageBox.Show($"При + значение увеличивается на скаляр: x = {point.X} y = {point.Y}");
            }
            catch
            {
                MessageBox.Show("Введите значение скаляра!!!");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            string str = (string)point;
            MessageBox.Show($"Преобразование из point в string: {str}");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            string str = (string)point;
            point = (Point)str;
            MessageBox.Show($"Преобразование из string в point x: {point.X} y: {point.Y}");
        }
    }
}
