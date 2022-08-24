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
    public partial class GeneralDetailsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public GeneralDetailsForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void closepicbox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadProduct()
        {
            int i = 0;
            productdgv.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Producttb WHERE CONCAT(productid,productname,price,description,category) LIKE '%" +productsearchtxt.Text+ "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                productdgv.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void productsearchtxt_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void productdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productidtxt.Text = productdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            productnametxt.Text = productdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            pricetxt.Text = productdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
           
        }

        private void quantitynud_ValueChanged(object sender, EventArgs e)
        {
            int total = Convert.ToInt16(pricetxt.Text) * Convert.ToInt16(quantitynud.Value);
            totaltxt.Text = total.ToString(); 
        }
    }
}
