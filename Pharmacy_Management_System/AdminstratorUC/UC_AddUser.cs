using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.AdminstratorUC
{
    public partial class UC_AddUser : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_up_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUserRole.Text!="" && txtUserName.Text!="" && txtDOB.Text!="" && txtMobile.Text!="" && txtEmail.Text!="" && txtPassword.Text!="" && txtUserName.Text!="" )
                {String role = txtUserRole.Text;
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

                    MessageBox.Show("Fill-up all fields first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch {

                
            }
            

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

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='"+txtUserName.Text+"'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"E:\C#_project\Images\yes.png";

            }
            else {
                pictureBox1.ImageLocation = @"E:\C#_project\Images\no.png";
            }
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
