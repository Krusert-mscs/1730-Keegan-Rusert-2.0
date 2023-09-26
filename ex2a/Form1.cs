using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DAmount.Text =
            //    (Convert.ToDecimal(Subtotal.Text) * Convert.ToDecimal(DPercent.Text) / 100).ToString("0.00");
            //Total.Text =
            //    (Convert.ToDecimal(Subtotal.Text) - Convert.ToDecimal(DAmount.Text)).ToString("0.00");
            int Division = 100;
            int SSubtotal = Convert.ToInt32(Subtotal.Text);
            int SDPercent = Convert.ToInt32(DPercent.Text);
            

            decimal SDAmount = SSubtotal * SDPercent / Division;
            DAmount.Text = SDPercent.ToString("0.00");

            decimal STotal = SSubtotal - SDAmount;
            Total.Text = STotal.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
