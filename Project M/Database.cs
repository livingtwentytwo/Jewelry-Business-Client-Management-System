using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project_M
{
    public class Database
    {
        public MySqlConnection connection;
        DataSet dataSet = new DataSet();
        private string server;
        private string database;
        private string uid;
        private string password;

        public Database()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "127.0.0.1";
            database = "mcollections";
            uid = "root";
            password = "meow";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {                
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(string query)
        {
            //string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (connection.State == ConnectionState.Open)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                            

            }
            else
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
            }

        }

        public void RetrievePurchases(string query)
        {
            OpenConnection();
            
            if (connection.State == ConnectionState.Open)
            {
                ClientPurchases purchases = new ClientPurchases();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                Client ID = new Client();

                if(reader.HasRows)
                {
                    string retrievePurchases = "Select * from purchase full outer join product on purchase.ProductID = product.ProductID where ClientID = '" + ID.ClientID + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(retrievePurchases, connection);
                    adapter.Fill(dataSet);
                    connection.Close();
                    purchases.purchaseList.DataSource = dataSet;
                }
                else
                {
                    purchases.Show();
                    purchases.groupBox1.Show();
                    purchases.message.Text = "No purchases to show.";
                    purchases.purchaseList.Visible = false;
                }
            }
        }
    }
}
