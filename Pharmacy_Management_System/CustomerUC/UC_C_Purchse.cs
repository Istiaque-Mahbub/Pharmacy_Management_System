using DGVPrinterHelper;
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

namespace Pharmacy_Management_System.CustomerUC
{
    public partial class UC_C_Purchse : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        public UC_C_Purchse()
        {
            InitializeComponent();
        }

        private void UC_C_Purchse_Load(object sender, EventArgs e)
        {
            try
            {listBoxMedicine.Items.Clear();
            query = "select mname from medic where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            }
            catch { }
            
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_C_Purchse_Load(this,null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxMedicine.Items.Clear();
            query = "select mname from medic where mname like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicine.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            }
            catch { }
            
        }

        private void listBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtNumberofUnit.Clear();
            String name = listBoxMedicine.GetItemText(listBoxMedicine.SelectedItem);
            txtMediName.Text = name;

            query = "select mid,eDate,perUnit from medic where mname='" + name + "'";
            ds = fn.getData(query);
            txtMediId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();

            }
            catch { }
            
        }

        private void txtNumberofUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNumberofUnit.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 numberOfUnits = Int64.Parse(txtNumberofUnit.Text);
                Int64 totalAmount = unitPrice * numberOfUnits;

                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }

            }
            catch {
                MessageBox.Show("Select medicine frist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
            
        }
        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMediId.Text != "")
                {
                    query = "select quantity  from medic where mid='" + txtMediId.Text + "'";
                    ds = fn.getData(query);

                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity - Int64.Parse(txtNumberofUnit.Text);

                    if (newQuantity >= 0)
                    {

                        n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = txtMediId.Text;
                        dataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                        dataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                        dataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                        dataGridView1.Rows[n].Cells[4].Value = txtNumberofUnit.Text;
                        dataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                        totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                        TotalLabel.Text = "TK. " + totalAmount.ToString();

                        query = "update medic set quantity=" + newQuantity + " where mid='" + txtMediId.Text + "' ";
                        fn.setData(query, "Medicine Added");
                    }
                    else
                    {
                        MessageBox.Show("Medicine is out of Stock \n Only " + quantity + " left", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    clearAll();
                    UC_C_Purchse_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Select medicine first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch { }
            
        }
        int valueAmount;
        String valueId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                numberOfUnit = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != "")
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medic where mid='" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + numberOfUnit;

                    query = "update medic set quantity ='" + newQuantity + "' where mid='" + valueId + "'";
                    fn.setData(query, "Medicine removed ");
                    totalAmount = totalAmount - valueAmount;
                    TotalLabel.Text = "TK. " + totalAmount.ToString();
                }
                UC_C_Purchse_Load(this, null);
            }
        }

        private void btnPurchase_Print_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[n].Cells[1].Value.ToString() != "")
                {

                    if (MessageBox.Show("Are you paid the bill?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        DGVPrinter printer = new DGVPrinter();
                        printer.Title = "Medicine Bill";
                        printer.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
                        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                        printer.PageNumbers = true;
                        printer.PageNumberInHeader = false;
                        printer.PorportionalColumns = true;
                        printer.HeaderCellAlignment = StringAlignment.Near;
                        printer.Footer = "Total Payable amount : " + TotalLabel.Text;
                        printer.FooterSpacing = 15;
                        printer.PrintDataGridView(dataGridView1);
                        totalAmount = 0;
                        TotalLabel.Text = "TK. 00";
                        dataGridView1.DataSource = 0;
                    }
                    else
                    {
                        MessageBox.Show("Frist pay the bill", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Add medicines to the cart  first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected Int64 numberOfUnit;


        private void clearAll()
        {
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNumberofUnit.Clear();
            txtTotalPrice.Clear();
            txtMediId.Clear();
            txtMediId.Clear();
            txtMediName.Clear();
        }

        
    }
}
