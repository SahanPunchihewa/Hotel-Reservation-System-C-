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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_id.Text != "")
                {

                    string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";
                    string query = "SELECT * FROM `package` WHERE id= '" + txt_id.Text + "'";
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
                    txt_numper.Text = dt.Rows[0][2].ToString();
                    txt_perperson.Text = dt.Rows[0][3].ToString();

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

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard open_dashboard = new Dashboard();
            open_dashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";

                string query = "UPDATE `package` SET `id` = '" + this.txt_id.Text + "', `name` = '" + this.txt_name.Text + "', `numper` ='" + this.txt_numper.Text + "', `perperson`= '" + this.txt_perperson.Text + "' WHERE `id`= '" + this.txt_id.Text + "'";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Package Details Successfully Updated!");
                while (MyReader.Read())

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=hotelsystem";
                string query = "DELETE FROM `package` WHERE id = '" + this.txt_id.Text + "'";

                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Package Successfully Deleted!");

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
