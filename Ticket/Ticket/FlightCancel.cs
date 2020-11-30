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
    public partial class PkFlightCancel : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\Muhammad Aqib\Desktop\FirstDB.accdb");
        Flight_Cancle FC = new Flight_Cancle();
        public PkFlightCancel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Form1 form1 = new Form1();
            //form1.Show();

            FC.Button_1();
            this.Hide();
        }

        private void BusCancl_Click(object sender, EventArgs e)
        {

            //string name = PKC_Name.Text;
            //string nic = CNIC.Text;

            //con.Open();

            //OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from PK_FlightPessenger where Name ='" + name + "' and CNIC ='" + nic + "' ";
            //OleDbDataReader reader = cmd.ExecuteReader();
            //int count = 0;
            //while (reader.Read())
            //{
            //    count++;
            //}
            //if (count == 1)
            //{
            //    //cmd.CommandText = "delete from PK_FlightPessenger where Name = '" + name + "'  ";
            //    //MessageBox.Show("Ticket Cancel successfully");

            //    // connection for select..
            //    con.Close();

            //    // connection for delete
            //    con.Open();

            //    OleDbCommand cnd = con.CreateCommand();
            //    cnd.CommandType = CommandType.Text;
            //    // MessageBox.Show(choice, data);


            //    cnd.CommandText = "delete from PK_FlightPessenger where Name = '" + name + "'  ";
            //    cnd.ExecuteNonQuery();

            //    //con.Close();
            //    MessageBox.Show("Ticket Cancel successfully");
            //}
            //else if (count < 1)
            //    MessageBox.Show("Record Not Found");
            //else
            //    MessageBox.Show("Record Not Found");
            //con.Close();



            ////string name = PKC_Name.Text;
            ////con.Open();

            ////OleDbCommand cmd = con.CreateCommand();
            ////cmd.CommandType = CommandType.Text;
            ////// MessageBox.Show(choice, data);


            ////cmd.CommandText = "delete from Pk_FlightPessenger where Name = '" + name + "'  ";
            ////cmd.ExecuteNonQuery();

            ////con.Close();
            ////MessageBox.Show("Ticket Cancel successfully");

            string query = "select * from PK_FlightPessenger where Name ='" + PKC_Name.Text + "' and CNIC ='" + CNIC.Text + "' ";
            string del = "delete from Pk_FlightPessenger where Name = '" + PKC_Name.Text + "'  ";

            new Train_form().Cancel(query, del);
        }

        private void Back_Flight_Click(object sender, EventArgs e)
        {
            //TravelPak trp = new TravelPak();
            //trp.Show();

            FC.Back_Flight();
            this.Hide();
        }
    }
}
