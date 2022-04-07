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
    public partial class NewPurchase : Form
    {
        public NewPurchase()
        {
            InitializeComponent();
        }

       
        private void savePurchase_Click(object sender, EventArgs e)
        {

        }

        
        private void comboBoxFrequency(object sender, EventArgs e)
        {
           if(comboBox1.Text == "Weekly")
            {
                datePicker.Format = DateTimePickerFormat.Custom;
                datePicker.CustomFormat = "dddd";
                datePicker.Visible = true;

                //Label label = new Label { Text = "Add Day of Week" };
                //TextBox text = new TextBox();

                //frequency.Controls.Add(label);
                //frequency.Controls.Add(text);
                //label.Location = new Point(20, 20);
                //text.Location = new Point(120, 20);
                //frequency.Visible = true;

            }
           else if(comboBox1.Text == "Twice/Week")
            {
                datePicker.Format = DateTimePickerFormat.Custom;
                datePicker.CustomFormat = "dddd";
                datePicker.Visible = true;

                datePicker2.Format = DateTimePickerFormat.Custom;
                datePicker2.CustomFormat = "dddd";
                datePicker2.Visible = true;

                //Label label = new Label { Text = "Add Day of Week" };
                //TextBox text = new TextBox();
                //Label label2 = new Label { Text = "Add Day of Week" };
                //TextBox text2 = new TextBox();

                //frequency.Controls.Add(label);
                //frequency.Controls.Add(text);
                //label.Location = new Point(20, 20);
                //text.Location = new Point(120, 20);

                //frequency.Controls.Add(label2);
                //frequency.Controls.Add(text2);
                //label.Location = new Point(20, 50);
                //text.Location = new Point(120, 50);
                //frequency.Visible = true;
            }
           else if(comboBox1.Text == "Twice/Month")
            {
                datePicker.Format = DateTimePickerFormat.Custom;
                datePicker.CustomFormat = "dd";
                datePicker.Visible = true;

                datePicker2.Format = DateTimePickerFormat.Custom;
                datePicker2.CustomFormat = "dd";
                datePicker2.Visible = true;

                //Label label = new Label { Text = "Add Day of Month" };
                //TextBox text = new TextBox();
                //Label label2 = new Label { Text = "Add Day of Month" };
                //TextBox text2 = new TextBox();

                //frequency.Controls.Add(label);
                //frequency.Controls.Add(text);
                //label.Location = new Point(20, 20);
                //text.Location = new Point(120, 20);

                //frequency.Controls.Add(label2);
                //frequency.Controls.Add(text2);
                //label.Location = new Point(20, 50);
                //text.Location = new Point(120, 50);
                //frequency.Visible = true;
            }
           else if(comboBox1.Text == "Monthly")
            {
                datePicker.Format = DateTimePickerFormat.Custom;
                datePicker.CustomFormat = "dd";
                datePicker.Visible = true;

                //Label label = new Label { Text = "Add Day of Month" };
                //TextBox text = new TextBox();

                //frequency.Controls.Add(label);
                //frequency.Controls.Add(text);
                //label.Location = new Point(20, 20);
                //text.Location = new Point(120, 20);
                //frequency.Visible = true;
            }
           else if(comboBox1.Text == "Everyday")
            {
                TextBox text = new TextBox { Text = "Everyday" };
                text.Visible = false;
            }          

        }       
    }
}
