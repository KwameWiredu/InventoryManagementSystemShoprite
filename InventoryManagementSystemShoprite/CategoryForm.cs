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
    public partial class CategoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            int i = 0;
            categorydgv.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM categorytb", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                categorydgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void categorydgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = categorydgv.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryDetailsForm categoryDetailsForm = new CategoryDetailsForm();
                categoryDetailsForm.catIDlbl.Text = categorydgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryDetailsForm.nametxt.Text = categorydgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                categoryDetailsForm.sectiontxt.Text = categorydgv.Rows[e.RowIndex].Cells[3].Value.ToString();

                categoryDetailsForm.savebtn.Enabled = false;
                categoryDetailsForm.updatebtn.Enabled = true;
                categoryDetailsForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Do you really want to DELETE this Category?", "Delete Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM categorytb WHERE categoryid LIKE '" + categorydgv.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been DELETED successfully!");
                }
            }
            LoadCategory();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm categoryDetailsForm = new CategoryDetailsForm();
            categoryDetailsForm.savebtn.Enabled = true;
            categoryDetailsForm.updatebtn.Enabled = false;
            categoryDetailsForm.ShowDialog();
            LoadCategory();
        }
    }
}
