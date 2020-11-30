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
    
    public partial class Admin : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\Muhammad Aqib\Desktop\FirstDB.accdb");
        public Admin()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            new admin().Signup(UserName.Text, Password.Text);
            this.Hide();

        }
    }
}
