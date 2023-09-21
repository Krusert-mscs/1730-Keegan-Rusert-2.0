using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            average.Text=
            ((Convert.ToDecimal(test1.Text) + Convert.ToDecimal(test2.Text) + Convert.ToDecimal(test2.Text)) / 3).ToString("0.00");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            test1.Text = 0 .ToString("0");
            test2.Text = 0 .ToString("0");
            test3.Text = 0 .ToString("0");
            average.Text = 0.00 .ToString("0.00");
        }

        private void rageQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
