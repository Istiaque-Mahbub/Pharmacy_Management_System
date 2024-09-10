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
    public partial class UC_Dashboard : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole='Adminstrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLable);

            query = "select count(userRole) from users where userRole='Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, PharmaLable);

            query = "select count(userRole) from users where userRole='Customer'";
            ds = fn.getData(query);
            setLabel(ds, CustomerLable);
        }
        private void setLabel(DataSet ds, Label lbl) 
        {

            if (ds.Tables[0].Rows.Count!=0) 
            {

                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }

        private void PharmaLable_Click(object sender, EventArgs e)
        {

        }
    }
}
