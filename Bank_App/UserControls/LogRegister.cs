﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bank_App.User_Current_Accaunt;

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

        public static User user;
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
            else if (CheckPass() && CheckLog(out userName, out id))
            {
                user = new CurrentUser();
                try
                {
                    user.Initialize(id);
                    LogedIn = user.IsLogedIn;
                    MessageBox.Show($"You Loged In {userName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Wrong Login or Password");
                logPass.Text = "";
            }
        }


        private string userName = null;
        private int id = 0;
        private bool CheckPass()
        {
            FileInfo sqlPath = new FileInfo(@".\BankSQLserver.mdf");
            string strConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={sqlPath.FullName};Integrated Security=True";
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

        private bool CheckLog(out string name, out int id)
        {
            FileInfo sqlPath = new FileInfo(@".\BankSQLserver.mdf");
            string strConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={sqlPath.FullName};Integrated Security=True";
            string query = $@"SELECT [Id], [Login], [UserName] FROM [BankAccaunt]";
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
                        if (logLogin.Text.SequenceEqual((string)reader.GetValue(1)))
                        {
                            name = reader.GetString(2);
                            id = reader.GetInt32(0);
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
            id = 0;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(regLog.Text) && !string.IsNullOrEmpty(regPass.Text) && regPassRepeat.Text == regPass.Text && !string.IsNullOrEmpty(regName.Text) &&
               !string.IsNullOrEmpty(regSurName.Text) && !string.IsNullOrEmpty(regEmail.Text) && bankChecker.Text != "Banks")
            {
                FileInfo sqlPath = new FileInfo(@".\BankSQLserver.mdf");
                string strConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={sqlPath.FullName};Integrated Security=True";
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
            FileInfo sqlPath = new FileInfo(@".\BankSQLserver.mdf");
            string strConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={sqlPath.FullName};Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(strConnection))
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


        public string saveString = null;
        public byte prevTag = 0;
        public RichTextBox prevLine = null;
        public byte tag = 0;
        //TODO PlaceHolder Bug Fix
        private void _Click_PlaceHolder(object sender, EventArgs e)
        {
            if (sender is RichTextBox && tag != Convert.ToByte(((RichTextBox)sender).Tag))
            {
                tag = Convert.ToByte(((RichTextBox)sender).Tag);
                if (tag != prevTag && prevTag != 0)
                {
                    prevLine.ForeColor = Color.Gray;
                    prevLine.Text = saveString;
                }
                prevTag = tag;
                saveString = ((RichTextBox)sender).Text;
                prevLine = ((RichTextBox)sender);
                ((RichTextBox)sender).Text = "";
                ((RichTextBox)sender).ForeColor = Color.Black;
            }
            if (sender is ComboBox)
            {
                ((ComboBox)sender).Text = "";
                ((ComboBox)sender).ForeColor = Color.Black;
            }
        }
    }
}
