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
    public partial class FlightForm : Form
    {
        Flight_Form FF = new Flight_Form();
        public FlightForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            FF.Main_Menu();
            this.Hide();
           
            
        }

        private void TravelPakistan_Click(object sender, EventArgs e)
        {
            FF.Travel_Pakistan();
            this.Hide();
            
           
        }

        private void TavelForeign_Click(object sender, EventArgs e)
        {
            FF.Travel_Foreign();
            this.Hide();
            
        }
    }
}
