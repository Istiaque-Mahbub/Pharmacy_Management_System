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
    public partial class SignIn_page : Form
    {
        Function fn=new Function();
        String query;
        DataSet ds;
        public SignIn_page()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();   
        }



        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            query ="select * from users";
             ds= fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if(textUserName.Text=="Admin" && textPassword.Text == "1234")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '" +textUserName.Text+"' and pass='"+textPassword.Text+"'";
                ds= fn.getData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role =="Adminstrator")
                    {
                        Adminstrator admin = new Adminstrator(textUserName.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(role == "Pharmacist")
                    {
                        Pharmacist phar = new Pharmacist(textUserName.Text);
                        phar.Show();
                        this.Hide();
                    }
                    else if (role == "Customer")
                    {
                       Customer customer = new Customer(textUserName.Text);
                        customer.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





            //if (textUserName.Text == "Admin" && textPassword.Text == "1234")
            //{
            //    Adminstrator am = new Adminstrator();
            //    am.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Customer_SignUp sign=new Customer_SignUp();
            sign.Show();
            this.Hide();
        }
    }
}
