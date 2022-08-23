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
    public partial class CategoryDetailsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public CategoryDetailsForm()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to SAVE this Category?", "Saving Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO categorytb(categoryname,sectionnumber)VALUES(@categoryname,@sectionnumber)", con);
                    cm.Parameters.AddWithValue("@categoryname", nametxt.Text);
                    cm.Parameters.AddWithValue("@sectionnumber", sectiontxt.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been Saved Successfully!");
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            nametxt.Clear();
            sectiontxt.Clear();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Clear();
            savebtn.Enabled = true;
            updatebtn.Enabled = false;
        }

        private void closepicbox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to UPDATE this Category?", "UPDATING Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE categorytb SET categoryname = @categoryname, sectionnumber = @sectionnumber WHERE categoryid LIKE '" + catIDlbl.Text + "' ", con);
                    cm.Parameters.AddWithValue("@categoryname", nametxt.Text);
                    cm.Parameters.AddWithValue("@sectionnumber", sectiontxt.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been UPDATED Successfully!");
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
