using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ticket
{
    public partial class BusCancel : Form
    {
        //string query = ();
       OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\Muhammad Aqib\Desktop\FirstDB.accdb");
        bus_cancle BC = new bus_cancle();
        public BusCancel()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            BC.button_Click();
            this.Hide();
        }

        private void BusCancl_Click(object sender, EventArgs e)
        {

            //con.Open();

            //OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from BusPessenger where Name ='" + C_Name.Text + "' and CNIC ='" + CNIC.Text + "' ";
            //OleDbDataReader reader = cmd.ExecuteReader();
            //int count = 0;
            //while (reader.Read())
            //{
            //    count++;
            //}
            //if (count == 1)
            //{
            //    // connection for select..
            //    con.Close();

            //    // connection for delete
            //    con.Open();

            //    OleDbCommand cnd = con.CreateCommand();
            //    cnd.CommandType = CommandType.Text;
            //    cnd.CommandText = "delete from BusPessenger where Name = '" + C_Name.Text + "'and CNIC ='" + CNIC.Text + "'  ";
            //    cnd.ExecuteNonQuery();

            //    //con.Close();
            //    MessageBox.Show("Ticket Cancel successfully");
            //}
            //else if (count < 1)
            //    MessageBox.Show("Record Not Found");
            //else
            //    MessageBox.Show("Record Not Found");
            //con.Close();

            string query  = "select * from BusPessenger where Name ='" + C_Name.Text + "' and CNIC ='" + CNIC.Text + "' ";
            string del  = "delete from BusPessenger where Name = '" + C_Name.Text + "'  ";


            new Train_form().Cancel(query, del);


        }

        private void BusBack_Click(object sender, EventArgs e)
        {
            BC.bus_back();
            this.Hide();
        }
    }
}
