using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App
{
    public partial class LogRegister : UserControl
    {
        private bool LogedIn = false;
        private string adminpass = "admin";
        private string adminlog = "admin";

        public LogRegister()
        {
            InitializeComponent();
            FillBankSql();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(logLogin.Text) || string.IsNullOrEmpty(logPass.Text))
            {
                MessageBox.Show("Password or Login is Empty");
            }
            else if (logPass.Text == adminpass && logLogin.Text == adminlog)
            {
                MessageBox.Show("Admin has successfully loged in !");
            }
            else if (CheckPass() && CheckLog(out userName))
            {
                LogedIn = true;
                MessageBox.Show($"You Loged In {userName}");
            }
        }


        private string userName = null;
        private bool CheckPass()
        {
            string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davom\source\repos\Bank_App\Bank_App\BankSQLserver.mdf;Integrated Security=True";
            string query = "SELECT [Password] FROM [BankAccaunt]";
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (logPass.Text.SequenceEqual((string)reader.GetValue(0)))
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        private bool CheckLog(out string name)
        {
            string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davom\source\repos\Bank_App\Bank_App\BankSQLserver.mdf;Integrated Security=True";
            string query = $@"SELECT [Login], [UserName] FROM [BankAccaunt]";
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (logLogin.Text.SequenceEqual((string)reader.GetValue(0)))
                        {
                            name = reader.GetString(1);
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            name = null;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(regLog.Text) && !string.IsNullOrEmpty(regPass.Text) && regPassRepeat.Text == regPass.Text && !string.IsNullOrEmpty(regName.Text) &&
               !string.IsNullOrEmpty(regSurName.Text) && !string.IsNullOrEmpty(regEmail.Text) && bankChecker.Text != "Banks")
            {
                string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davom\source\repos\Bank_App\Bank_App\BankSQLserver.mdf;Integrated Security=True";
                string query = $@"INSERT INTO BankAccaunt VALUES('{regName.Text}', '{regSurName.Text}', '{regEmail.Text}' ,{0} , {bankChecker.SelectedIndex + 1}, NULL, NULL, NULL, '{regLog.Text}', '{regPass.Text}')";
                using (SqlConnection connection = new SqlConnection(strConnection))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Accaunt Created Thank You Form Being With Us !");
                    regName.Text = "";
                    regSurName.Text = "";
                    regLog.Text = "";
                    regPass.Text = "";
                    regPassRepeat.Text = "";
                    regEmail.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }
        }

        private void FillBankSql()
        {
            string strconnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davom\source\repos\Bank_App\Bank_App\BankSQLserver.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(strconnect))
            {
                string query = @"SELECT Name FROM [BankList]";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        bankChecker.Items.Add(name);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void bankChecker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
