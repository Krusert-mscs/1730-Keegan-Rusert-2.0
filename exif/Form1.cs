using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            btnEurope.BackgroundImage = picEurope.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;
            txtRate.Text = "0.99535511";
            lblCurrency.Text = btnEurope.Text + ":";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
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
    }
}
