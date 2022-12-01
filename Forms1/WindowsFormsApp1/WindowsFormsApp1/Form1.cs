using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p, s;
            try
            {
                p = Convert.ToDouble(textBox1.Text);
                s = Math.Pow(p, 2) * Math.Sqrt(3) / 36;
                textBox2.Text = "" + s;
            }
            catch(Exception)
            {
                MessageBox.Show("Вводи только числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
    }
}
