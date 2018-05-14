using StakeBot.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StakeBot
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.DoLogin(txtUserName.Text, txtPassword.Text, txt2FA.Text);
           
        }

        private void rbMines_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMines.Checked)
            {
                if (pnlGame.Controls.Count >= 1) pnlGame.Controls.RemoveAt(0);
                Mines mines = new Mines();
                pnlGame.Controls.Add(mines);

            }
        }
    }
}
