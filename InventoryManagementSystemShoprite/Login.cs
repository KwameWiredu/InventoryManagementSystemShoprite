using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemShoprite
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void shopritelbl_Click(object sender, EventArgs e)
        {

        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPasswordchk_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordchk.Checked == false)
                passwordtxt.UseSystemPasswordChar = true;
            else
                passwordtxt.UseSystemPasswordChar = false;
        }

        private void closepicbox_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Exit?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
