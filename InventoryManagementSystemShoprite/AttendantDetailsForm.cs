using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystemShoprite
{
    public partial class AttendantDetailsForm : Form
    {

        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public AttendantDetailsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            savebtn.Enabled = true;
            updatebtn.Enabled = false;
        }

        public void Clear()
        {
            emailtxt.Clear();
            fullnametxt.Clear();
            passwordtxt.Clear();
            confpasswordtxt.Clear();
            contacttxt.Clear();
        }

        private void closepicbox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AttendantDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordtxt.Text != confpasswordtxt.Text)
                {
                    MessageBox.Show("Your Passwords do not match!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Do you really want to SAVE this Atendent?","Saving Details",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Attendanttb(email,fullname,password,contact)VALUES(@email,@fullname,@password,@contact)", con);
                    cm.Parameters.AddWithValue("@email", emailtxt.Text);
                    cm.Parameters.AddWithValue("@fullname", fullnametxt.Text);
                    cm.Parameters.AddWithValue("@password", passwordtxt.Text);
                    cm.Parameters.AddWithValue("@contact", contacttxt.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Attendant has been Saved Successfully!");
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordtxt.Text != confpasswordtxt.Text)
                {
                    MessageBox.Show("Your Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Do you really want to UPDATE this Atendent?", "UPDATING Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Attendanttb SET fullname = @fullname, password = @password, contact = @contact WHERE email LIKE '"+emailtxt.Text+"' ", con);
                    cm.Parameters.AddWithValue("@fullname", fullnametxt.Text);
                    cm.Parameters.AddWithValue("@password", passwordtxt.Text);
                    cm.Parameters.AddWithValue("@contact", contacttxt.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Attendant has been Updated Successfully!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
