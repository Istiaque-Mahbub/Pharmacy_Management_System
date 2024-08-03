using Pharmacy_Management_System.PharmacistUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Pharmacist : Form
    {
        String user = "";
        public Pharmacist()
        {
            InitializeComponent();
        }
        public String ID
        {
            get { return user.ToString(); }
        }
        public Pharmacist(String name)
        {
            InitializeComponent();
            usernameLabel.Text = name;
            this.user = name;
            uC_P_Profile1.ID = ID;
           
        }
            

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SignIn_page sing = new SignIn_page();
            sing.Show();
            this.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible=true;
            uC_P_Dashboard1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
           uC_P_AddMedicine1.Visible=false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_UpdateMedicine1.Visible=false;
            uC_P_MedicineValidityCheck1.Visible=false;
            uC_P_SellMedicine1.Visible= false;
            uC_P_Profile1.Visible=false;
            btnDashBoard.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible=true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicine1.Visible = true;
            uC_P_ViewMedicine1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_P_UpdateMedicine1.Visible= true;
            uC_P_UpdateMedicine1.BringToFront();
        }

        private void btnMediValidityCheck_Click(object sender, EventArgs e)
        {
            uC_P_MedicineValidityCheck1.Visible=true;
            uC_P_MedicineValidityCheck1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicine1.Visible = true;
            uC_P_SellMedicine1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_P_Profile1.Visible=true;
            uC_P_Profile1.BringToFront();
        }
    }
}
