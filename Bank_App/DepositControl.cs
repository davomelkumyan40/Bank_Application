using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Bank_App
{
    public partial class DepositControl : UserControl
    {
        public DepositControl()
        {
            InitializeComponent();
            FillFromSQLToComboBox();
        }

        private void FillFromSQLToComboBox()
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

            using (SqlConnection connection = new SqlConnection(strconnect))
            {
                string query = @"SELECT [Name], [Percent] FROM [DepositList]";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        string percent = " - " + reader.GetByte(1) + " %";
                        depositChecker.Items.Add(name + percent);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }



        private void moneyCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
            else
            {
                base.OnKeyPress(e);
            }
        }

        private void moneyCount_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void checker_Click(object sender, EventArgs e)
        {
            ((ComboBox)sender).Text = "";
        }

        private void depositCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("afawfawfa");
        }
    }
}
