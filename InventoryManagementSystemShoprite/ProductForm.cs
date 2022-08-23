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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }
        public void LoadProduct()
        {
            int i = 0;
            productdgv.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Producttb", con);
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
        private void addbtn_Click(object sender, EventArgs e)
        {
            ProductDetailsForm productDetailsForm = new ProductDetailsForm();
            productDetailsForm.savebtn.Enabled = true;
            productDetailsForm.updatebtn.Enabled = false;
            productDetailsForm.ShowDialog();
            LoadProduct();
       
        }

        private void productdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = productdgv.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductDetailsForm productDetails = new ProductDetailsForm();
                productDetails.productIDlbl.Text = productdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                productDetails.productnametxt.Text = productdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                productDetails.quantitytxt.Text = productdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                productDetails.pricetxt.Text = productdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                productDetails.descriptiontxt.Text = productdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                productDetails.categorycmb.Text = productdgv.Rows[e.RowIndex].Cells[6].Value.ToString();

                productDetails.savebtn.Enabled = false;
                productDetails.updatebtn.Enabled = true;
                productDetails.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Do you really want to DELETE this Product?", "Delete Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM Producttb WHERE productid LIKE '" + productdgv.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been DELETED successfully!");
                }
            }
            LoadProduct();
        }
    }
}
