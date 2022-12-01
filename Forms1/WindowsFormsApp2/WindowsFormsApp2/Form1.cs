using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int a = 0;
            {
                
                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        MessageBox.Show("Поле не заполнено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                a = Convert.ToInt32(textBox1.Text);
                if (a % 2 == 0)
                {
                        textBox2.Text = " четным";
                }
                    else
                    {
                            textBox2.Text = " нечетным";
                    
                    }
        }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // вводить можно лишь числовые значения
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }
    }
}
