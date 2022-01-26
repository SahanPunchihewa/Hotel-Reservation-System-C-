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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";

                string query = "INSERT INTO `customer` (`id`, `name`, `address`, `contact`) VALUES ('" + this.txt_id.Text + "', '" + this.txt_name.Text + "', '" + this.txt_address.Text + "', '" + this.txt_contact.Text + "');";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Customer Added Successful..!!!");

                txt_id.Text = "";
                txt_name.Text = "";
                txt_address.Text = "";
                txt_contact.Text = "";
                

                Myconn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_id.Text != "")
                {

                    string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";
                    string query = "SELECT * FROM `customer` WHERE id= '" + txt_id.Text + "'";
                    MySqlConnection Myconn = new MySqlConnection(MyConnection);
                    MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                    MySqlDataReader MyReader;
                    Myconn.Open();
                    MyReader = Mycommand.ExecuteReader();
                    Myconn.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(Mycommand);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    txt_name.Text = dt.Rows[0][1].ToString();
                    txt_address.Text = dt.Rows[0][2].ToString();
                    txt_contact.Text = dt.Rows[0][3].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Enter Value for ID");
                }

            }
            catch
            {

                MessageBox.Show("Error");
            }
        }
    }
}
