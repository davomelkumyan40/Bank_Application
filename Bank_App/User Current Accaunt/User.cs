using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_App.User_Current_Accaunt
{
    public abstract class User
    {
        public abstract bool IsLogedIn { get; set; }
        public abstract int Id { get; set; }
        public abstract void Initialize(int id);
    }


    class CurrentUser : User
    {
        public override bool IsLogedIn { get; set; }
        public override int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string UserEmail { get; set; }
        public decimal UserBalace { get; set; }
        public int BankId { get; set; }
        public int DepositId { get; set; }
        public string CardCode { get; set; }
        public string CardPIN { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public override void Initialize(int id)
        {
            string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davom\source\repos\Bank_App\Bank_App\BankSQLserver.mdf;Integrated Security=True";
            string query = $@"SELECT * FROM BankAccaunt WHERE [Id] = {id}";
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    reader.Read();
                    Id = id;
                    UserName = reader.GetString(1);
                    UserSurName = reader.GetString(2);
                    UserEmail = reader.GetString(3);
                    UserBalace = reader.GetDecimal(4);
                    BankId = reader.GetInt32(5);
                    DepositId = reader.GetInt32(6);
                    CardCode = reader.GetString(7);
                    CardPIN = reader.GetString(8);
                    Login = reader.GetString(9);
                    Password = reader.GetString(10);
                    reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable To Connect to User Accaunt");
                }
            }
        }
    }
}
