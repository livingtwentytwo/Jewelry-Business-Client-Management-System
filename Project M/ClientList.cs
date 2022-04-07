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
    public partial class ClientList : Form
    {
        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mcollectionsDataSet.clientinfo' table. You can move, or remove it, as needed.
            this.clientinfoTableAdapter.Fill(this.mcollectionsDataSet.clientinfo);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientinfoTableAdapter.FillBy(this.mcollectionsDataSet.clientinfo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientInformation clientInfo = new ClientInformation();

            Client ID = new Client();            

            clientInfo.lastName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            clientInfo.firstName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            clientInfo.address.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            clientInfo.company.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            clientInfo.contact.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ID.ClientID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

            clientInfo.Show();
        }

       
    }
}
