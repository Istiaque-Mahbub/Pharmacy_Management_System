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
    public partial class UC_Profile : UserControl
    {
        Function fn =new Function();
        String query;
        public UC_Profile()
        {
            InitializeComponent();
        }
        public String ID
        {
            set { userNameLabel.Text = value; }
        }

        

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this,null);    
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role=txtuserRole.Text;
            String name=txtname.Text;
            String dob= txtDOB.Text;
            Int64 mobile=Int64.Parse(txtMobile.Text);   
            String email=txtEmail.Text;
            String username=userNameLabel.Text;
            String password=txtPassword.Text;

            query = "update users set userRole='" + role + "', name='" + name + "', dob='" + dob + "',mobile="+mobile+",email='"+email+"',pass='"+password+ "' where username='"+username+"'";
            fn.setData(query, "Profile updation successfull");
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            query = "select * from users where username='" + userNameLabel.Text + "'";
            DataSet ds = fn.getData(query);
            txtuserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDOB.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }
    }
}
