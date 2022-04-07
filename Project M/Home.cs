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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddClient newClient = new AddClient();

            newClient.Show();
        }

        private void clientList_Click(object sender, EventArgs e)
        {
            ClientList cList = new ClientList();

            cList.Show();
        }
    }
}
