namespace Project_M
{
    partial class NewPurchase
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
            this.name = new System.Windows.Forms.TextBox();
            this.kind = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentAmount = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.savePurchase = new System.Windows.Forms.Button();
            this.dateToday = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.GroupBox();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.frequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(131, 102);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 2;
            // 
            // kind
            // 
            this.kind.Location = new System.Drawing.Point(131, 137);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(100, 20);
            this.kind.TabIndex = 3;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(131, 174);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 4;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(131, 213);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kind";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Product Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Payment Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Frequency of Payment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Twice/Week",
            "Twice/Month",
            "Everyday"});
            this.comboBox1.Location = new System.Drawing.Point(386, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFrequency);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount Per Payment";
            // 
            // paymentAmount
            // 
            this.paymentAmount.Location = new System.Drawing.Point(386, 254);
            this.paymentAmount.Name = "paymentAmount";
            this.paymentAmount.Size = new System.Drawing.Size(100, 20);
            this.paymentAmount.TabIndex = 15;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(131, 254);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(100, 20);
            this.notes.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Notes";
            // 
            // savePurchase
            // 
            this.savePurchase.Location = new System.Drawing.Point(511, 356);
            this.savePurchase.Name = "savePurchase";
            this.savePurchase.Size = new System.Drawing.Size(75, 23);
            this.savePurchase.TabIndex = 18;
            this.savePurchase.Text = "Save";
            this.savePurchase.UseVisualStyleBackColor = true;
            this.savePurchase.Click += new System.EventHandler(this.savePurchase_Click);
            // 
            // dateToday
            // 
            this.dateToday.AutoSize = true;
            this.dateToday.Location = new System.Drawing.Point(57, 27);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(28, 13);
            this.dateToday.TabIndex = 19;
            this.dateToday.Text = "date";
            // 
            // frequency
            // 
            this.frequency.Controls.Add(this.datePicker2);
            this.frequency.Controls.Add(this.datePicker);
            this.frequency.Location = new System.Drawing.Point(260, 137);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(247, 100);
            this.frequency.TabIndex = 20;
            this.frequency.TabStop = false;
            // 
            // datePicker2
            // 
            this.datePicker2.Location = new System.Drawing.Point(26, 60);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(200, 20);
            this.datePicker2.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(26, 34);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 0;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(264, 289);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(69, 13);
            this.start.TabIndex = 21;
            this.start.Text = "Starting Date";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(267, 319);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(66, 13);
            this.end.TabIndex = 22;
            this.end.Text = "Ending Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(386, 287);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 23;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(386, 313);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 24;
            // 
            // NewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.savePurchase);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.paymentAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.name);
            this.Name = "NewPurchase";
            this.Text = " ";
            this.frequency.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox kind;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox paymentAmount;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button savePurchase;
        public System.Windows.Forms.Label dateToday;
        public System.Windows.Forms.GroupBox frequency;
        public System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label end;
        public System.Windows.Forms.DateTimePicker datePicker2;
        public System.Windows.Forms.DateTimePicker startDate;
        public System.Windows.Forms.DateTimePicker endDate;
    }
}