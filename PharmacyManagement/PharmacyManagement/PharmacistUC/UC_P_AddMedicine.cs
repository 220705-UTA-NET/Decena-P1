using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {

        //Function fn = new Function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMedId.Text!= "" && txtMedName.Text!="" && txtMedDescription.Text!="" && txtMedAmount.Text!="" && txtMedTablets.Text!="" && txtMedPrice.Text!="")
            {
                String mid = txtMedId.Text;
                String mname = txtMedName.Text;
                String mdescription = txtMedDescription.Text;
                String mamount = txtMedAmount.Text;
                String mtablets = txtMedTablets.Text;
                String mprice = txtMedPrice.Text;

                query = "insert into Medications (mid, mname, mdescription, mdamount, mtablets, mprice) values ('"+mid+"', '"+mname+"', '"+mdescription+"', '"+mamount+"', '"+mtablets+"', '"+mprice+"')";
                

            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
