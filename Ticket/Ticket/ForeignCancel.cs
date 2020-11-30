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
    public partial class ForeignCancel : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\Muhammad Aqib\Desktop\FirstDB.accdb");
        Foreign_Cancel FC = new Foreign_Cancel();
        public ForeignCancel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FC.Button_1();
            this.Hide();
        }

        private void ForeignCancl_Click(object sender, EventArgs e)
        {

           string query = "select * from Foreign_FlightPessenger where Name ='" + C_Name.Text + "' and CNIC ='" + CNIC + "' ";
            string del = "delete from Foreign_FlightPessenger where Name = '" + C_Name.Text + "'  ";

            new Train_form().Cancel(query, del);


        }

        private void Back_Flight_Click(object sender, EventArgs e)
        {
            FC.Back_Flight();
            this.Hide();
            
        }
    }
}
