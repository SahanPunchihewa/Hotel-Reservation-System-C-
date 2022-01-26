using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer open_addcustomer = new AddCustomer();
            open_addcustomer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPackage open_addpackage = new AddPackage();
            open_addpackage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRoom open_addroom = new AddRoom();
            open_addroom.Show();
            this.Hide();
        }
    }
}
