using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemShoprite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void attendantBtn2_Click(object sender, EventArgs e)
        {
            openChildForm(new AttendantsForm());
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm !=null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendantBtn1_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }
    }
}
