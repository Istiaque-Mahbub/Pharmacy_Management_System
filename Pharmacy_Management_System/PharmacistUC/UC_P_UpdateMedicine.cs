using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_UpdateMedicine : UserControl
    {
        Function fn=new Function();
        String query;
        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
                if (txtMedicineID.Text != "")
                {
                    query = "select * from medic where mid='" + txtMedicineID.Text + "'";
                    DataSet ds = fn.getData(query);
                    if (ds.Tables[0].Rows.Count != 0)
                    {

                        txtMediName.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtMediNumber.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtmDate.Text = ds.Tables[0].Rows[0][4].ToString();
                        txteDate.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtavailQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                        txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No medicine with ID: " + txtMedicineID.Text + " exitst", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    ClearAll();
                }
            }
            catch { }
            
        }
        private void ClearAll()
        {
            txtMedicineID.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtmDate.ResetText();
            txteDate.ResetText();
            txtavailQuantity.Clear();
            txtPricePerUnit.Clear();
            if(txtAddQuantity.Text!="0")
            {
                txtAddQuantity.Text="0";
            }
            else
            {

                txtAddQuantity.Text = "0";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {String name=txtMediName.Text;
            String number=txtMediNumber.Text;
            String mdate=txtmDate.Text;
            String edate=txteDate.Text;
            Int64 availQuantity=Int64.Parse(txtavailQuantity.Text);
            Int64 addQuantity=Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtAddQuantity.Text);

            totalQuantity = availQuantity + addQuantity;
            //mid, mname, mnumber, mDate, eDate,quantity, perUnit
            query = "update medic set mname='"+ name + "',mnumber='"+ number + "',mDate='"+ mdate + "',eDate='"+ edate + "',quantity="+ totalQuantity + ",perUnit="+ unitprice + " where mid='"+txtMedicineID.Text+"'";
            fn.setData(query, "Medicine Details Updated");

            }
            catch {

                MessageBox.Show("Fill-up all the field first","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
