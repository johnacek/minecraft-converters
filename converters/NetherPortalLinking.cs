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
    public partial class NetherPortalLinking : Form
    {
        public NetherPortalLinking()
        {
            InitializeComponent();
        }

        private void bttConvert_Click(object sender, EventArgs e)
        {
            string xCo, zCo;
            int xNum, zNum;

            xCo = x.Text;
            zCo = z.Text;

            if (!int.TryParse(xCo, out xNum))
            {
                x.Text = ("This is not number.").ToString();
            } else
            {
                int xAns = xNum / 8;
                xOut.Text = xAns.ToString();
            }

            if (!int.TryParse(zCo, out zNum))
            {
                z.Text = ("This is not number.").ToString();
            } else
            {
                int zAns = zNum / 8;
                zOut.Text = zAns.ToString();
            }
        }

        private void NetherPortalLinking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
