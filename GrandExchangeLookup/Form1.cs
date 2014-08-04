using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrandExchangeLookup
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayInfo();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                displayInfo();
            }
        }

        private void displayInfo()
        {
            button1.Enabled = false; //disable the button to prevent people spamclicking it


            int ItemID;
            if (int.TryParse(textBox1.Text, out ItemID))
            {
                GEItem item = Methods.Lookup(ItemID);

                if (item != null)
                {
                    NameLabel.Text = "Item name: " + item.item.name;
                    PriceLabel.Text = "Current price: " + Methods.getIntPrice(item) + " gp";
                    ChangeTodayLabel.Text = "Change today: " + item.item.today.price + " gp";
                    Day30TrendLabel.Text = "1 month change: " + item.item.day30.change;
                    Day90TrendLabel.Text = "3 month change: " + item.item.day90.change;
                    Day180TrendLabel.Text = "6 month change: " + item.item.day180.change;
                    
                    pictureBox1.Load(item.item.icon_large);
                    MembersIcon.Visible = item.item.members == "true";
                    MembersTextLabel.Visible = item.item.members == "true";

                    NameLabel.ForeColor = item.item.members == "true"? Color.Gold: Color.Silver;
                }

                else
                {
                    NameLabel.Text = "Item name: Invalid item id";
                }
            }

            button1.Enabled = true;
        }
    }
}
