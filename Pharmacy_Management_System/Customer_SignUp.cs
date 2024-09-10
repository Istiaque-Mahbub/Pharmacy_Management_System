using System;
using System.Collections;
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
    public partial class Customer_SignUp : Form
    {
        Function fn=new Function();
        String query;
        public Customer_SignUp()
        {
            InitializeComponent();
        }

        private void Customer_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn_page signIn_Page = new SignIn_page();
            signIn_Page.Show();
            this.Hide();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            try { query = "select * from users where username='" + txtUserName.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox2.ImageLocation = @"E:\C#_project\Images\yes.png";

            }
            else
            {
                pictureBox2.ImageLocation = @"E:\C#_project\Images\no.png";
            }}
            catch { }
            
        }

        private void btn_RESET_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtName.Clear();
            txtDOB.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;

        }

        private void btnSign_up_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text !="" && txtDOB.Text!="" && txtEmail.Text!="" && txtMobile.Text!="" && txtUserRole.Text!="" && txtPassword.Text!="" )
            {
                String role = txtUserRole.Text;
                String name = txtName.Text;
                String dob = txtDOB.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String email = txtEmail.Text;
                String username = txtUserName.Text;
                String password = txtPassword.Text;

                try
                {
                    query = "insert into users(userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + password + "')";
                    fn.setData(query, "SignUp successful.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Username already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Fill-up all the field first","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
