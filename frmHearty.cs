using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hearty_Application
{
    public partial class frmHearty : Form
    {

        public frmHearty()
        {
            InitializeComponent();
        }

        //The declaring of variable integer.
        int myMoney;

        //The initialization of all controls.
        private void RefreshAll(bool Bol)
        {
            LabelCredit.Text = "0";

            //The numeric up down button code.
            nud1.Enabled = Bol;
            nud2.Enabled = Bol;
            nud3.Enabled = Bol;
            nud4.Enabled = Bol;
            nud5.Enabled = Bol;
            nud6.Enabled = Bol;
            nud7.Enabled = Bol;
            nud8.Enabled = Bol;
            nud9.Enabled = Bol;
            nud10.Enabled = Bol;
            nud11.Enabled = Bol;
            nud12.Enabled = Bol;
            nud13.Enabled = Bol;
            nud14.Enabled = Bol;
            nud15.Enabled = Bol;
            nud16.Enabled = Bol;
            nud17.Enabled = Bol;
            nud18.Enabled = Bol;
            nud19.Enabled = Bol;
            nud20.Enabled = Bol;
            nud21.Enabled = Bol;
            nud22.Enabled = Bol;
            nud23.Enabled = Bol;
            nud24.Enabled = Bol;
            nud25.Enabled = Bol;
            nud26.Enabled = Bol;
            nud27.Enabled = Bol;
            nud28.Enabled = Bol;
            nud29.Enabled = Bol;
            nud30.Enabled = Bol;

            nud1.Value = 0;
            nud2.Value = 0;
            nud3.Value = 0;
            nud4.Value = 0;
            nud5.Value = 0;
            nud6.Value = 0;
            nud7.Value = 0;
            nud8.Value = 0;
            nud9.Value = 0;
            nud10.Value = 0;
            nud11.Value = 0;
            nud12.Value = 0;
            nud13.Value = 0;
            nud14.Value = 0;
            nud15.Value = 0;
            nud16.Value = 0;
            nud17.Value = 0;
            nud18.Value = 0;
            nud19.Value = 0;
            nud20.Value = 0;
            nud21.Value = 0;
            nud22.Value = 0;
            nud23.Value = 0;
            nud24.Value = 0;
            nud25.Value = 0;
            nud26.Value = 0;
            nud27.Value = 0;
            nud28.Value = 0;
            nud29.Value = 0;
            nud30.Value = 0;

            //The remaining credit code.
            GroupBoxEnterCredit.Enabled = true;
            GroupBoxEnterCredit.Visible = true;

            GroupBoxRunningCredit.Enabled = false;
            GroupBoxRunningCredit.Visible = false;

            //The arrow gif appearing when dispersing the items.
            pictureArrow.Visible = false;
        }

        private void frmHearty_Load(object sender, EventArgs e)
        {
            RefreshAll(false);
        }

        private void textboxBill_TextChanged(object sender, EventArgs e)
        {
            if (textboxBill.Text == "")
                return;
            myMoney = int.Parse(textboxBill.Text);
        }

        //The error handler.
        private void textboxBill_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) 
        {
            if (e.KeyChar != 8)
            {
                if ((e.KeyChar) < 48 | (e.KeyChar) > 57)
                    e.Handled = true;
            }
        }

        //The message box that shows when an order is placed.
        private void btnNext_Click(Object sender, EventArgs e)
        {
            if (textboxBill.Text == "" | textboxBill.Text == "0")
            {
                MessageBox.Show("Please enter money on the cash slot! ❤", "Hearty Vending Machine");
                RefreshAll(false);
            }
            else if (int.Parse(textboxBill.Text) > 0 && int.Parse(textboxBill.Text) <= 100)
            {
                RefreshAll(true);
                GroupBoxRunningCredit.Enabled = true;
                GroupBoxRunningCredit.Visible = true;
                LabelCredit.Text = myMoney.ToString();
            }
            else if (int.Parse(textboxBill.Text) > 100)
            {
                MessageBox.Show("Maximum of 100 AED only! ❤", "Hearty Vending Machine");
                RefreshAll(false);
            }
        }

        //The cancellation of order.
        private void btnCancel_Click(System.Object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Cancel transaction? ❤", "Hearty Vending Machine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Removing your cash... Please wait! ❤", "Hearty Vending Machine");
                RefreshAll(false);
                textboxBill.Text = "0";
                GroupBoxRunningCredit.Visible = false;
            }
        }

        private void ComputeGoods()
        {
            //The declaration of remaining credits.
            int myRemainingCredit;
            int myRemainingCredit2;
            int myCredit;

            myRemainingCredit = (Convert.ToInt32(nud1.Value) * 2) + (Convert.ToInt32(nud2.Value) * 2) + (Convert.ToInt32(nud3.Value) * 2) + (Convert.ToInt32(nud4.Value) * 2) + (Convert.ToInt32(nud5.Value) * 2) + (Convert.ToInt32(nud6.Value) * 2) + (Convert.ToInt32(nud7.Value) * 2) + (Convert.ToInt32(nud8.Value) * 2) + (Convert.ToInt32(nud9.Value) * 2) + (Convert.ToInt32(nud10.Value) * 2) + (Convert.ToInt32(nud11.Value) * 1) + (Convert.ToInt32(nud12.Value) * 1) + (Convert.ToInt32(nud13.Value) * 1) + (Convert.ToInt32(nud14.Value) * 1) + (Convert.ToInt32(nud15.Value) * 1) + (Convert.ToInt32(nud16.Value) * 1) + (Convert.ToInt32(nud17.Value) * 1) + (Convert.ToInt32(nud18.Value) * 1) + (Convert.ToInt32(nud19.Value) * 1) + (Convert.ToInt32(nud20.Value) * 1) + (Convert.ToInt32(nud21.Value) * 4) + (Convert.ToInt32(nud22.Value) * 4) + (Convert.ToInt32(nud23.Value) * 4) + (Convert.ToInt32(nud24.Value) * 4) + (Convert.ToInt32(nud25.Value) * 4) + (Convert.ToInt32(nud26.Value) * 4) + (Convert.ToInt32(nud27.Value) * 4) + (Convert.ToInt32(nud28.Value) * 4) + (Convert.ToInt32(nud29.Value) * 4) + (Convert.ToInt32(nud30.Value) * 4);
            myRemainingCredit2 = myMoney - myRemainingCredit;
            
            //The popup message that shows when not enough money is inserted.
            if (myRemainingCredit2 < 0)
            {
                MessageBox.Show("You do not have enough balance! Remove item(s) in your cart and select other items! ❤", "Hearty Vending Machine");
                myRemainingCredit2 = int.Parse(LabelCredit.Text);
                return;
            }

            LabelCredit.Text = (myMoney - myRemainingCredit).ToString();
            myCredit = myMoney - myRemainingCredit;

            //The popup message that shows when all credits are spent.
            if (myCredit == 0) 
            {
                if (MessageBox.Show("You do not have enough balance!  Proceed in buying all the items? ❤", "Hearty Vending Machine", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //The popup message that shows when items are being dispersed.
                    pictureArrow.Visible = true;
                    MessageBox.Show("Dispersing your item(s)... Please wait! ❤", "Hearty Vending Machince");
                    RefreshAll(false);
                    textboxBill.Text = "0";
                    GroupBoxRunningCredit.Visible = false;
                }
            }
        }

        //Hearty Treats Computation Events <3 <3 <3 <3 <3 <3 <3 <3

        private void nud1_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud2_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud3_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud4_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud5_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud6_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud7_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud8_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud9_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud10_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        //Hearty Beverages Computation Events <3 <3 <3 <3 <3 <3 <3 

        private void nud11_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud12_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud13_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud14_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud15_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud16_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud17_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud18_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud19_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud20_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        //Hearty Luncheon Computation Events <3 <3 <3 <3 <3 <3 <3 <3

        private void nud21_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud22_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud23_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud24_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud25_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud26_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud27_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud28_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud29_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        private void nud30_ValueChanged(object sender, EventArgs e)
        {
            ComputeGoods();
        }

        //The text that shows when money is inserted.
        private void btnFinalNext_Click(object sender, EventArgs e)
        {
            if (textboxBill.Text == LabelCredit.Text)
            {
                MessageBox.Show("Please select an item to purchase ❤", "Hearty Vending Machince");
                return;
            }

            if (MessageBox.Show("Proceed in buying the items? ❤", "Hearty Vending Machine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               //The text seen if there's a change left from your credit.
                if (int.Parse(LabelCredit.Text) > 0)
                {
                    pictureArrow.Visible = true;
                    MessageBox.Show("Dispersing your item(s)... Please get your change of " + LabelCredit.Text + " AED on the Cash Bin and click OK. ❤", "Hearty Vending Machince");
                    RefreshAll(false);
                    textboxBill.Text = "0";
                    GroupBoxRunningCredit.Visible = false;
                }
            }
        }
    }
}
