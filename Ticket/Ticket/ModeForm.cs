using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class ModeForm : Form
    {
        Mode_Travel md_trvl = new Mode_Travel();
        Mode_Form MD = new Mode_Form();
        public ModeForm()
        {
            InitializeComponent();
        }

        private void Bus_Click(object sender, EventArgs e)
        {
            MD.Bus_click();
            this.Hide();
        }

        private void Train_Click(object sender, EventArgs e)
        {

            MD.Train_Click();
            this.Hide();
        }

        private void Flight_Click(object sender, EventArgs e)
        {

            MD.Flight_Click();
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD.Button_1();
            this.Hide();
        }
    }
}
