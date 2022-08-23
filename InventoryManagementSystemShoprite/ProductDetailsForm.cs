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
    public partial class ProductDetailsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rwkkr\Documents\IMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductDetailsForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            categorycmb.Items.Clear();
            cm = new SqlCommand("SELECT categoryname FROM categorytb", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                categorycmb.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closepicbox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
          
                if (MessageBox.Show("Do you really want to SAVE this Product?", "Saving Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Producttb(productname,quantity,price,description,category)VALUES(@productname, @quantity, @price, @description, @category)", con);
                    cm.Parameters.AddWithValue("@productname", productnametxt.Text);
                    cm.Parameters.AddWithValue("@quantity", Convert.ToInt16(quantitytxt.Text));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(pricetxt.Text));
                    cm.Parameters.AddWithValue("@description", descriptiontxt.Text);
                    cm.Parameters.AddWithValue("@category", categorycmb.Text);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been Saved Successfully!");
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
            productnametxt.Clear();
            quantitytxt.Clear();
            pricetxt.Clear();
            descriptiontxt.Clear();
            categorycmb.Text = "";
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Clear();
            savebtn.Enabled = true;
            updatebtn.Enabled = false;
        }

        private void productIDlbl_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (MessageBox.Show("Do you really want to UPDATE this Product?", "UPDATING Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Producttb SET productname = @productname, quantity = @quantity, price = @price, description = @description, category = @category WHERE productid LIKE '" + productIDlbl.Text + "' ", con);
                    cm.Parameters.AddWithValue("@productname", productnametxt.Text);
                    cm.Parameters.AddWithValue("@quantity", Convert.ToInt16(quantitytxt.Text));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(pricetxt.Text));
                    cm.Parameters.AddWithValue("@description", descriptiontxt.Text);
                    cm.Parameters.AddWithValue("@category", categorycmb.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been Updated Successfully!");
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
