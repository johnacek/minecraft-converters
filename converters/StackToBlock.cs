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
    public partial class StackToBlock : Form
    {
        public StackToBlock()
        {
            InitializeComponent();
        }

        private void StackToBlock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void bttBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void bttConvert_Click(object sender, EventArgs e)
        {
            int ans, num;
            string inp;
            inp = input.Text;
            if (!int.TryParse(inp, out num))
            {
                output.Text = ("This is not number.").ToString();
            } else
            {
                ans = num * 64;
                output.Text = ans.ToString() + " blocks.";            }
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttConvert_Click(this, new EventArgs());
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
