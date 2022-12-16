using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FНеделя3_Задание7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            StringBuilder sb = new StringBuilder(richTextBox1.Text);

            for (int i = 0; i < sb.Length - 1; i += 2)
            {
                if (sb[i] == ' ' || sb[i + 1] == ' ') // если пробел || если след. пробел то откат на 2 символа назад
                {
                    i -= 1;
                }
                else
                {
                    char buf = sb[i];
                    sb[i] = sb[i + 1];
                    sb[i + 1] = buf;
                }
            }
            richTextBox2.Text += sb;
        }
    }
}
