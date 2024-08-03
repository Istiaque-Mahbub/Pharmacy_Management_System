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
    
    public partial class Adminstrator : Form
    {
        String user = "";
        public Adminstrator()
        {
            InitializeComponent();
        }
        public String ID
        {
            get { return user.ToString(); }
        }
        public Adminstrator(String name)
        {
            InitializeComponent();
            usernameLabel.Text = name;
            this.user = name;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID=ID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SignIn_page signIn_Page = new SignIn_page();
            signIn_Page.Show();
            this.Hide();
        }

        private void Display_Username_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible=false;
            uC_AddUser1.Visible=false;
            uC_ViewUser1.Visible=false;
            uC_Profile1.Visible=false;
            btn_DashBoard.PerformClick();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btn_viewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
          uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }
    }
}
