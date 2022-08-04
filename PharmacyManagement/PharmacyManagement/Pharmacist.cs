using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            btnAddMedicine.PerformClick();
            //uC_Dashboard1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            uC_P_AddMedicine1.Visible = false;
            //uC_AddUser1.Visible = false;
            btnDashboard.PerformClick();
            

        }

       

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //uC_AddUser1.Visible = true;
            //uC_AddUser1.BringToFront();
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
            
            

        }

       /* private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            //uC_AddUser1.Visible = true;
            //uC_AddUser1.BringToFront();

            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();



        }*/

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
