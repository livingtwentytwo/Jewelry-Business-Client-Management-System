namespace Project_M
{
    partial class ClientInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.company = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(237, 254);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Purchases";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(92, 39);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 7;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(92, 65);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 8;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(92, 91);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 9;
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(92, 117);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(100, 20);
            this.company.TabIndex = 10;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(92, 143);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(100, 20);
            this.contact.TabIndex = 11;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(92, 193);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(100, 20);
            this.balance.TabIndex = 12;
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(92, 283);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(75, 23);
            this.payment.TabIndex = 13;
            this.payment.Text = "Receive Payment";
            this.payment.UseVisualStyleBackColor = true;
            // 
            // ClientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.company);
            this.Controls.Add(this.address);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.update);
            this.Name = "ClientInformation";
            this.Text = "ClientInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox lastName;
        public System.Windows.Forms.TextBox firstName;
        public System.Windows.Forms.TextBox address;
        public System.Windows.Forms.TextBox company;
        public System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button payment;
    }
}