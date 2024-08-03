﻿using System;
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
    public partial class Customer : Form
    {
        String user = "";
        public Customer()
        {
            InitializeComponent();
        }
        public Customer(String name)
        {
            InitializeComponent();
            usernameLabel.Text = name;
        }

            private void btnLogOut_Click(object sender, EventArgs e)
        {
            SignIn_page sing = new SignIn_page();
            sing.Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            uC_C_Purchse1.Visible = false;
            btnPurchaseMedicine.PerformClick();
        }

        private void btnPurchaseMedicine_Click(object sender, EventArgs e)
        {
            uC_C_Purchse1.Visible = true;
            uC_C_Purchse1.BringToFront();
        }
    }
}