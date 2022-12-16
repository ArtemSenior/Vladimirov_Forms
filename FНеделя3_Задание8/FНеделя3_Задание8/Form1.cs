using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FНеделя3_Задание8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;;
            string words = textBox1.Text;
            Regex regex = new Regex(@"\b" + words + @"\b", RegexOptions.IgnoreCase);

            if (regex.IsMatch(a))
            {
                richTextBox2.Text = ("\nСообщение содержит заданное слово");
            }
            else
            {
                richTextBox2.Text = ("\nСообщение не содержит заданное слово");
            }
        }
    }
}
