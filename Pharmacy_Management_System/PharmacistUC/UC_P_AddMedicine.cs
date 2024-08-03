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
    
    public partial class UC_P_AddMedicine : UserControl
    {
        Function fn= new Function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMediName.Text!="" && txtMediId.Text!="" && txtMediNumber.Text!="" && txtManufacturingDate.Text!="" && txtExpireDate.Text!="" && txtQuantity.Text!="" && txtPricePerUnit.Text!="")
            {
                String mid=txtMediId.Text;
                String mname=txtMediName.Text;
                String mnumber=txtMediNumber.Text;
                String mdate=txtManufacturingDate.Text;
                String edate=txtExpireDate.Text;    
                Int64 quantity=Int64.Parse(txtQuantity.Text);
                Int64 perunit=Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic (mid, mname, mnumber, mDate, eDate,quantity, perUnit) values('"+ mid + "','"+ mname + "', '"+ mnumber + "', '"+mdate+"', '"+edate+"',"+quantity+","+perunit+")";
                fn.setData(query, "Medicine Added to DataBase");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Fill-up all the data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtManufacturingDate.ResetText();
            txtExpireDate.ResetText();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();

        }
    }
}
