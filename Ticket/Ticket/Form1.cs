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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\Muhammad Aqib\Desktop\FirstDB.accdb");
        Form_1 F1 = new Form_1();
        public Form1()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            string hi = "this.Hide()";
            new Sign().LogIn(UserName.Text, Password.Text);
            
        }

        private void singup_Click(object sender, EventArgs e)
        {
            F1.Sign_Up();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F1.Button_1();
            this.Hide();
        }
    }
}