using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_M
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            string addClient = "INSERT INTO clientinfo (LastName, FirstName, Address, Company, Contact) VALUES('" + lastName.Text + "', '" + firstName.Text + "', '" + address.Text + "', '" + company.Text + "', '" + contact.Text + "')";

            db.Insert(addClient);

            MessageBox.Show("Success");
        }
    }
}
