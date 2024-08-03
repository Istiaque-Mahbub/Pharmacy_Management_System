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
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        Function fn=new Function();
        String query;
        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select * from medic where eDate >= getdate()";
                setGridView(query,"Valid Medicines",Color.Green);
            }
            else if (txtCheck.SelectedIndex == 1)
            {

                query = "select * from medic where eDate < getdate()";
                setGridView(query, "Expried Medicines", Color.Red);

            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from medic";
                setGridView(query, "All Medicines", Color.Black);

            }
        }
        private void setGridView(String query, String labelname, Color col)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            setLabel.Text = labelname;
            setLabel.ForeColor = col;
        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }
    }
}
