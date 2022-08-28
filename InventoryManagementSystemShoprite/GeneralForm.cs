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
    public partial class GeneralForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public GeneralForm()
        {
            InitializeComponent();
            LoadGeneral();
        }

        public void LoadGeneral()
        {
            int i = 0;
            generaldgv.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Generaltb", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                generaldgv.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            GeneralDetailsForm generalDetailsForm = new GeneralDetailsForm();
            generalDetailsForm.ShowDialog();
            LoadGeneral();
        }

        private void attendantdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = generaldgv.Columns[e.ColumnIndex].Name;
            
            if (colName == "Delete")
            {
                if (MessageBox.Show("Do you really want to DELETE this order?", "Delete Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM Generaltb WHERE orderid LIKE '" + generaldgv.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been DELETED successfully!");

                    cm = new SqlCommand("UPDATE Producttb SET quantity=(@quantity+@quantity) WHERE productid LIKE '" + generaldgv.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", con);
                    cm.Parameters.AddWithValue("@quantity", Convert.ToInt16(generaldgv.Rows[e.RowIndex].Cells[4].Value.ToString()));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                }
            }
            LoadGeneral();
        }

        private void closepicbox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
