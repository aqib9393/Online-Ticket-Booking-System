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
    public partial class AdminEdit : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\Muhammad Aqib\Desktop\FirstDB.accdb");
        Admin_Edit AE = new Admin_Edit();
        public AdminEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AE.Button_1();
            this.Hide();
        }

        private void AddBus_Click(object sender, EventArgs e)
        {

            new admin().add(AdminCombo.Text, Data.Text, Departure.Text, Arrive.Text, Time.Text);

        }  

        private void ViewBus_Click(object sender, EventArgs e)
        {
            new admin().view_Bus(AdminCombo.Text, Data.Text, Time.Text, dataGridView1);

        }

        private void DeleteBus_Click(object sender, EventArgs e)
        {
            new admin().Delete_admin(AdminCombo.Text, Data.Text, Time.Text);
        }

        private void UpdateBus_Click(object sender, EventArgs e)
        {
           
            new admin().Update_admin(AdminCombo.Text, Data.Text, Time.Text);

        }
    }
}
