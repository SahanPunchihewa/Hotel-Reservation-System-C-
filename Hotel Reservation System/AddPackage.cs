using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Reservation_System
{
    public partial class AddPackage : Form
    {
        public AddPackage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";

                string query = "INSERT INTO `package` (`id`, `name`, `numper`, `perperson`) VALUES ('" + this.txt_id.Text + "', '" + this.txt_name.Text + "', '" + this.txt_numper.Text + "', '" + this.txt_perperson.Text + "');";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Package Added Successful..!!!");

                txt_id.Text = "";
                txt_name.Text = "";
                txt_numper.Text = "";
                txt_perperson.Text = "";


                Myconn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
