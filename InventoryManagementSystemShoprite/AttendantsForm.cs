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
    public partial class AttendantsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public AttendantsForm()
        {
            InitializeComponent();
            LoadAttendant();
        }

        public void LoadAttendant()
        {
            int i = 0;
            attendantdgv.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Attendanttb", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                attendantdgv.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AttendantDetailsForm attendantDetails = new AttendantDetailsForm();
            attendantDetails.savebtn.Enabled = true;
            attendantDetails.updatebtn.Enabled = false;
            attendantDetails.ShowDialog();
            LoadAttendant();
        }

        private void attendantdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = attendantdgv.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AttendantDetailsForm attendantDetails = new AttendantDetailsForm();
                attendantDetails.emailtxt.Text = attendantdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                attendantDetails.fullnametxt.Text = attendantdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                attendantDetails.passwordtxt.Text = attendantdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                attendantDetails.contacttxt.Text = attendantdgv.Rows[e.RowIndex].Cells[4].Value.ToString();

                attendantDetails.savebtn.Enabled = false;
                attendantDetails.updatebtn.Enabled = true;
                attendantDetails.emailtxt.Enabled = false;
                attendantDetails.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Do you really want to DELETE this attendant?","Delete Details",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM Attendanttb WHERE email LIKE '" + attendantdgv.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been DELETED successfully!");
                }
            }
            LoadAttendant();
        }
    }
}
