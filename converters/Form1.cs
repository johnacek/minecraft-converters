using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttConvert_Click(object sender, EventArgs e)
        {
            int divisor, blocks, num;
            string dividend;
            dividend = input.Text;
            if (!int.TryParse(dividend, out num))
            {
                output.Text = ("This is not number.").ToString();
            }
            else
            {
                divisor = 64;
                int stack = Math.DivRem(num, divisor, out blocks);
                output.Text = stack.ToString() + " stacks and " + blocks + " blocks.";
            }       
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttConvert_Click(this, new EventArgs());
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
