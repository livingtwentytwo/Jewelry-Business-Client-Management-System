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
    public partial class ClientPurchases : Form
    {
        public ClientPurchases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            NewPurchase newPurchase = new NewPurchase();

            newPurchase.dateToday.Text = today.ToShortDateString();
            newPurchase.frequency.Visible = false;
            newPurchase.datePicker.Visible = false;
            newPurchase.datePicker2.Visible = false;

            newPurchase.startDate.Format = DateTimePickerFormat.Custom;
            newPurchase.startDate.CustomFormat = "MMMM dd";
            newPurchase.endDate.Format = DateTimePickerFormat.Custom;
            newPurchase.endDate.CustomFormat = "MMMM dd";

            newPurchase.Show();
        }

        private void ClientPurchases_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mcollectionsDataSet1.purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.mcollectionsDataSet1.purchase);

        }
    }
}
