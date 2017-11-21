using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace New
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;
            DatabaseConnector DB = new DatabaseConnector();
            string query = "SELECT * FROM user WHERE username=@username AND password=@password";
            MySqlCommand command = new MySqlCommand(query, DB.Connection);
            command.Parameters.AddWithValue("@username", Username);
            command.Parameters.AddWithValue("@password", Password);

            try
            {
                DB.Connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    return;
                }
                MessageBox.Show("Username/Password Salah. Silahkan Coba lagi");
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DB.Connection.Close();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
