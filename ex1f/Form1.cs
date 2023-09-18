using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.76140989";
            lblCurrency.Text = btnCanada.Text + ":";
            txtCurrency.Focus();
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.76140989";
            lblCurrency.Text = btnCanada.Text + ":";
        }

        private void btnUK_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUK.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "1.1511001";
            lblCurrency.Text = btnUK.Text + ":";
        }

        private void btnJapan_Click(object sender, EventArgs e)
        {
            btnJapan.BackgroundImage = picJapan.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.007131922";
            lblCurrency.Text = btnJapan.Text + ":";
        }

        private void btnEurope_Click(object sender, EventArgs e)
        {
            btnEurope.BackgroundImage = picEurope.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            txtRate.Text = "0.99535511";
            lblCurrency.Text = btnEurope.Text + ":";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
            (Convert.ToDecimal(txtCurrency.Text) / Convert.ToDecimal(txtRate.Text))
            ).ToString("0.00");

        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtRate.SelectAll();
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;

            txtTotalUS.Text = (
                Convert.ToDecimal(txtTotalUS.Text) + Convert.ToDecimal(txtUSDollars.Text)
                ).ToString("0.00");
        }

        private void lblEquation_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            btnEurope.BackgroundImage = picEuropeDim.Image;
            txtRate.Text = "0.76140989";
            lblCurrency.Text = btnCanada.Text + ":";
            txtCurrency.Focus();
            txtTotalUS.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
        }
    }
}
