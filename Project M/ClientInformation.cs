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
    public partial class ClientInformation : Form
    {
        public ClientInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientPurchases purchases = new ClientPurchases();
            Client ID = new Client();
            Database db = new Database();

            string retrievePurchases = "Select * from purchase where ClientID = '" + ID.ClientID + "'";

            db.RetrievePurchases(retrievePurchases);

            //DataGridView purchaseList = new DataGridView();

            //DataGridViewTextBoxColumn PurchaseID = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn ProductName = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn ProductKind = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn ProductAmount = new DataGridViewTextBoxColumn();
            //DataGridViewTextBoxColumn PurchaseBalance = new DataGridViewTextBoxColumn();

            //PurchaseID.HeaderText = "Purchase Number";
            //ProductName.HeaderText = "Purchase Number";
            //ProductKind.HeaderText = "Purchase Number";
            //ProductAmount.HeaderText = "Purchase Number";
            //PurchaseBalance.HeaderText = "Purchase Number";           
        }

      
    }
}
