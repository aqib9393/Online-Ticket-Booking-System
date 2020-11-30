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
    public partial class BusForms : Form
    {
        
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\Muhammad Aqib\Desktop\FirstDB.accdb");
        Bus_Form BF = new Bus_Form();
        public BusForms()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {

            BF.Main_Menu();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           BF.btn1();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             BF.btn2();
            this.Hide();
        }
        private void BusDone_Click(object sender, EventArgs e)
        {
            string query = "select * from BusPessenger where CNIC ='" + CNIC_bus.Text + "' ";
            string insert = "insert into BusPessenger(BusName, Name, CNIC, Adult, Child, Infactry) values('" + BusComb.Text + "', '" + Name_bus.Text + "', '" + CNIC_bus.Text + "', '" + AdultComb.Text + "', '" + ChildComb.Text + "', '" + InfntCombo.Text + "')";


            // new Bus_form().Done(BusComb.Text ,Name_bus.Text, CNIC_bus.Text, AdultComb.Text, ChildComb.Text, InfntCombo.Text );
            new Train_form().Bus_done(query, insert);
        }
        private void ViewBus_Click(object sender, EventArgs e)
        {
            string select = "select * from BusPessenger where Name='" + ViewText.Text + "'";

            //  new Bus_form().View_Bus(ViewText.Text, BusView);
            new Train_form().View_train(select, BusView);
        }
        private void BusForms_Load(object sender, EventArgs e)
        {
            //new Bus_form().Bus_Form_Load(BusComb);

            string select = "Select * from BusData";

            new Train_form().Load_form(select, BusComb);
        }
    }
}
