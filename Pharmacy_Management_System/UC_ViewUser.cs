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
    public partial class UC_ViewUser : UserControl
    {
        Function fn = new Function();
        String query;
        String current_user="";
       
        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public String ID
        {

            set { current_user = value; }
        }


       
        private void UC_ViewUser_Load(object sender, EventArgs e)
        {

            query = "select * from users";

            DataSet ds = fn.getData(query);
            dataGridView1.DataSource=ds.Tables[0];
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query="select * from users where username like '"+txtUserName.Text+"%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
        String username;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception) 
            {
            

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (current_user != username)
                {

                    query = "delete from users where username='"+username+"'";
                    fn.setData(query, "User record deleted");
                    UC_ViewUser_Load(this,null);

                }
                else
                {
                    MessageBox.Show("You are trying to delete \n your own profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }
    }
}
