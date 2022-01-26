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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void txt_Rnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";

                string query = "INSERT INTO `room` (`id`, `Rnumber`, `Rtype`, `type`, `amount`) VALUES ('" + this.txt_id.Text + "', '" + this.txt_Rnumber.Text + "', '" + this.txt_Rtype.Text + "', '" + this.txt_type.Text + "', '"+this.txt_amount+"');";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Room Details Added Successful..!!!");

                txt_id.Text = "";
                txt_Rnumber.Text = "";
                txt_Rtype.Text = "";
                txt_type.Text = "";
                txt_amount.Text = "";


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
                    string query = "SELECT * FROM `room` WHERE id= '" + txt_id.Text + "'";
                    MySqlConnection Myconn = new MySqlConnection(MyConnection);
                    MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                    MySqlDataReader MyReader;
                    Myconn.Open();
                    MyReader = Mycommand.ExecuteReader();
                    Myconn.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(Mycommand);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    txt_Rnumber.Text = dt.Rows[0][1].ToString();
                    txt_Rtype.Text = dt.Rows[0][2].ToString();
                    txt_type.Text = dt.Rows[0][3].ToString();
                    txt_amount.Text = dt.Rows[0][4].ToString();

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";

                string query = "UPDATE `room` SET `id` = '" + this.txt_id.Text + "', `Rnumber` = '" + this.txt_Rnumber.Text + "', `Rtype` ='" + this.txt_Rtype.Text + "', `type`= '" + this.txt_type.Text + "', `amount` = '"+this.txt_amount+"' WHERE `id`= '" + this.txt_id.Text + "'";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Room Details Successfully Updated!");
                while (MyReader.Read())

                txt_id.Text = "";
                txt_Rnumber.Text = "";
                txt_Rtype.Text = "";
                txt_type.Text = "";
                txt_amount.Text = "";


                Myconn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";
                string query = "DELETE FROM `room` WHERE id = '" + this.txt_id.Text + "'";

                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Room Successfully Deleted!");

                txt_id.Text = "";
                txt_Rnumber.Text = "";
                txt_Rtype.Text = "";
                txt_type.Text = "";
                txt_amount.Text = "";

                Myconn.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
