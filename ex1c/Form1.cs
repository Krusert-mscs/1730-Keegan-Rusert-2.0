using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1c
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDiggidyDog.Text =
                (4.0m * Convert.ToDecimal(txtHotDog.Text)).ToString("0.00");
            txtBorgorOfHam.Text =
                (5.0m * Convert.ToDecimal(txtBurger.Text)).ToString("0.00");
            txtOhNo.Text =
                (Convert.ToDecimal(txtHotDiggidyDog.Text) + Convert.ToDecimal(txtBorgorOfHam.Text)).ToString("0.00");
            txtITSTHEIRS.Text =
               (0.06875m * Convert.ToDecimal(txtOhNo.Text)).ToString("0.00");
            //(Convert.ToDecimal(txtOhNo) + 1).ToString("0.00");

            txtTotal.Text =
                (Convert.ToDecimal(txtITSTHEIRS.Text) + Convert.ToDecimal(txtOhNo.Text)).ToString("0.00");
                
              //  (Convert.ToDecimal(txtOhNo.Text) + Convert.ToDecimal(txtITSTHEIRS.Text)).ToString("0.00");
          
            btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDog.Text = "0";
            txtBurger.Text = "0";
            txtHotDiggidyDog.Text = "";
            txtBorgorOfHam.Text = "";
            txtOhNo.Text = "";
            txtITSTHEIRS.Text = "";
            txtTotal.Text = "";

            txtHotDog.Focus();
        }
    }
}
