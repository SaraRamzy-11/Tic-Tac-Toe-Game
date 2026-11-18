using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Game_Project
{
    public partial class frmStartGame : Form
    {
        public frmStartGame()
        {
            InitializeComponent();
        }

       

        private void btnYes_Click(object sender, EventArgs e)
        {
            Form1 GameForm=new Form1();
            GameForm.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
