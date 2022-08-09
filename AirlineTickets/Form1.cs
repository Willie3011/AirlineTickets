using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string FirstName = "";
        public string LastName = "";
        public string Email = "";
        public string Depature = "";
        public string Destination = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtFirstName != null)
            {
                FirstName = txtFirstName.Text;
            }

            if(txtLastName != null)
            {
                LastName = txtLastName.Text;
            }

            if(txtEmail != null)
            {
                Email = txtEmail.Text;
            }

            if(cbDepature.SelectedItem != null)
            {
                Depature = cbDepature.SelectedItem.ToString();
            }
        }
    }
}
