using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmReset_Click(object sender, EventArgs e)
        {
            txtAmountA.Text = "0.00";
            txtAmountB.Text = "0.00";
            txtAmountC.Text = "0.00";
            txtAmountD.Text = "0.00";
            txtRateA.Text = "0.717976";
            txtRateB.Text = "0.0139831";
            txtRateC.Text = "0.00176122";
            txtRateD.Text = "1.15528";
            txtEquivA.Text = "0.00";
            txtEquivB.Text = "0.00";
            txtEquivC.Text = "0.00";
            txtEquivD.Text = "0.00";
            txtMoneyMoneyMoneyMoneyMoney.Text = "0.00";
            txtAmountA.Focus();

        }

        private void txtAmountB_TextChanged(object sender, EventArgs e)
        {
            txtEquivB.Text = (Convert.ToDecimal(txtAmountB.Text) * Convert.ToDecimal(txtRateB.Text)).ToString("0.00");
            txtMoneyMoneyMoneyMoneyMoney.Text = (Convert.ToDecimal(txtEquivA.Text) + Convert.ToDecimal(txtEquivB.Text) + Convert.ToDecimal(txtEquivC.Text) + Convert.ToDecimal(txtEquivD.Text)).ToString("0.00");
        }

        private void txtAmountA_TextChanged(object sender, EventArgs e)
        {
            txtEquivA.Text = (Convert.ToDecimal(txtAmountA.Text) * Convert.ToDecimal(txtRateA.Text)).ToString("0.00");
            txtMoneyMoneyMoneyMoneyMoney.Text = (Convert.ToDecimal(txtEquivA.Text) + Convert.ToDecimal(txtEquivB.Text) + Convert.ToDecimal(txtEquivC.Text) + Convert.ToDecimal(txtEquivD.Text)).ToString("0.00");
        }

        private void txtAmountC_TextChanged(object sender, EventArgs e)
        {
            txtEquivC.Text = (Convert.ToDecimal(txtAmountC.Text) * Convert.ToDecimal(txtRateC.Text)).ToString("0.00");
            txtMoneyMoneyMoneyMoneyMoney.Text = (Convert.ToDecimal(txtEquivA.Text) + Convert.ToDecimal(txtEquivB.Text) + Convert.ToDecimal(txtEquivC.Text) + Convert.ToDecimal(txtEquivD.Text)).ToString("0.00");
        }

        private void txtAmountD_TextChanged(object sender, EventArgs e)
        {
            txtEquivD.Text = (Convert.ToDecimal(txtAmountD.Text) * Convert.ToDecimal(txtRateD.Text)).ToString("0.00");
            txtMoneyMoneyMoneyMoneyMoney.Text = (Convert.ToDecimal(txtEquivA.Text) + Convert.ToDecimal(txtEquivB.Text) + Convert.ToDecimal(txtEquivC.Text) + Convert.ToDecimal(txtEquivD.Text)).ToString("0.00");
        }

        private void txtAmountB_TextChanged_1(object sender, EventArgs e)
        {
            txtEquivB.Text = (Convert.ToDecimal(txtAmountB.Text) * Convert.ToDecimal(txtRateB.Text)).ToString("0.00");
            txtMoneyMoneyMoneyMoneyMoney.Text = (Convert.ToDecimal(txtEquivA.Text) + Convert.ToDecimal(txtEquivB.Text) + Convert.ToDecimal(txtEquivC.Text) + Convert.ToDecimal(txtEquivD.Text)).ToString("0.00");
        }
    }
}
