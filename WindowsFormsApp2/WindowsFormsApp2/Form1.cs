using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            do
            {
                if (int.TryParse(textBox1.Text, out n))
                {
                    if (n >= 1 && n <= 12)
                        break;
                    else
                    {
                        MessageBox.Show("Вводите числа от 1 до 12");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Вводите только целые числа!");
                    return;
                }
            }
            while (true);
            

            switch (n)
            {
                case 1:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 2:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 3:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 4:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 5:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 6:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 7:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 8:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 9:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 10:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 11:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
                case 12:
                    label2.Text = "Осталось месяцев до конца года:" + (12 - n);
                    break;
            }

        }
    }
}
