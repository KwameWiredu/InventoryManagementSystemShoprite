using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemShoprite
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
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

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("You have");
            }
            else if (cmbRole.SelectedItem.ToString() == "Admin")
            {
                cm = new SqlCommand("SELECT * from Admintb WHERE email=@email AND password=@password", con);
                cm.Parameters.AddWithValue("@email", emailtxt.Text);
                cm.Parameters.AddWithValue("@password", passwordtxt.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome Admin"  ", "PERMISSION GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm main = new MainForm();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid email or password! Are You Really an Admin?", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else if (cmbRole.SelectedItem.ToString() == "Attendant")
            {
                cm = new SqlCommand("SELECT * from Attendanttb WHERE email=@email AND password=@password", con);
                cm.Parameters.AddWithValue("@email", emailtxt.Text);
                cm.Parameters.AddWithValue("@password", passwordtxt.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome Attendant", "PERMISSION GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GeneralForm main = new GeneralForm();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid email or password! Are You Really an Attendant?", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            
            
        }

        private void adminattendantcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
