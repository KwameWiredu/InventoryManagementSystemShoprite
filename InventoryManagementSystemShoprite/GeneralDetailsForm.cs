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
        int quantity = 0;

    

        private void productdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productidtxt.Text = productdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            productnametxt.Text = productdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            pricetxt.Text = productdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (productidtxt.Text == "")
                {
                    MessageBox.Show("Select Product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Do you really want to INSERT this Product?", "Saving Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Generaltb(date,productid,quantity,price,total)VALUES(@date,@productid,@quantity,@price,@total)", con);
                    cm.Parameters.AddWithValue("@date", generaldate.Value);
                    cm.Parameters.AddWithValue("@productid", Convert.ToInt16(productidtxt.Text));
                    cm.Parameters.AddWithValue("@quantity", Convert.ToInt16(quantitynud.Value));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(pricetxt.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt16(totaltxt.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been Inserted Successfully :)");
                    

                    cm = new SqlCommand("UPDATE Producttb SET quantity=(@quantity-@quantity) WHERE productid LIKE '" + productidtxt.Text + "' ", con);
                    cm.Parameters.AddWithValue("@quantity", Convert.ToInt16(quantitynud.Text));
                    
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            productidtxt.Clear();
            productnametxt.Clear();

            pricetxt.Clear();
            quantitynud.Value = 0;
            totaltxt.Clear();
            generaldate.Value = DateTime.Now;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void quantitynud_ValueChanged(object sender, EventArgs e)
        {

            GetQuantity();
            if (Convert.ToInt16(quantitynud.Value) > quantity)
            {
                MessageBox.Show("Quantity of selected product is more than what is available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantitynud.Value = quantitynud.Value - 1;
                return;
            }
            if (Convert.ToInt16(quantitynud.Value) > 0)
            {
                int total = Convert.ToInt16(pricetxt.Text) * Convert.ToInt16(quantitynud.Value);
                totaltxt.Text = total.ToString();
            }
        }

        private void productnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        public void GetQuantity()
        {
           
            cm = new SqlCommand("SELECT quantity FROM Producttb WHERE productid='"+ productidtxt.Text +"'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                quantity = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

       
    }
}
