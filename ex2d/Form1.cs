using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setP_Click(object sender, EventArgs e)
        {
            in1.Text = "Frank";
            in2.Text = "";
            in3.Text = "2.3";
            in4.Text = "false";
            in5a.Text = "2";
            in5b.Text = "2";
            in6.Text = "xyz";
            in7.Text = "1";
            in8a.Text = "1";
            in8b.Text = "2";
            in9.Text = "500";
            in10a.Text = "2";
            in10b.Text = "3";
        }

        private void setF_Click(object sender, EventArgs e)
        {
            in1.Text = "xyz";
            in2.Text = "xyz";
            in3.Text = "2.4";
            in4.Text = "true";
            in5a.Text = "2";
            in5b.Text = "3";
            in6.Text = "Jones";
            in7.Text = "0";
            in8a.Text = "1";
            in8b.Text = "1";
            in9.Text = "499";
            in10a.Text = "4";
            in10b.Text = "3";
        }

        private void LeaveAggressively_Click(object sender, EventArgs e)
        {
            this.Close();
            //but in a very aggressive manner
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            a1.Text = "Fail";
            a2.Text = "Fail";
            a3.Text = "Fail";
            a4.Text = "Fail";
            a5.Text = "Fail";
            a6.Text = "Fail";
            a7.Text = "Fail";
            a8.Text = "Fail";
            a9.Text = "Fail";
            a10.Text = "Fail";

            b1.Text = "Success";
            b2.Text = "Success";
            b3.Text = "Success";
            b4.Text = "Success";
            b5.Text = "Success";
            b6.Text = "Success";
            b7.Text = "Success";
            b8.Text = "Success";
            b9.Text = "Success";
            b10.Text = "Success";

            decimal val3 = Convert.ToDecimal(in3.Text);
            decimal val5a = Convert.ToDecimal(in5a.Text);
            decimal val5b = Convert.ToDecimal(in5b.Text);
            decimal val7 = Convert.ToDecimal(in7.Text);
            decimal val8a = Convert.ToDecimal(in8a.Text);
            decimal val8b = Convert.ToDecimal(in8b.Text);
            decimal val10a = Convert.ToDecimal(in10a.Text);
            decimal val10b = Convert.ToDecimal(in10b.Text);

            if (in1.Text == "Frank")
                a1.Text = "Success";
            if (in1.Text != "Frank")
                b1.Text = "Fail";

            if (in2.Text == "")
                a2.Text = "Success";
            if (in2.Text != "")
                b2.Text = "Fail";

            if (val3 == 2.3m)
                a3.Text = "Success";
            if (val3 != 2.3m)
                b3.Text = "Fail";

            if (in4.Text == "false")
                a4.Text = "Success";
            if (in4.Text != "false")
                b4.Text = "Fail";

            if (val5a == 2m)
                if (val5b == 2m)
                    a5.Text = "Success";
            if (val5a == 2m)
                if (val5b != 2m)
                    b5.Text = "Fail";

            if (in6.Text == "xyz")
                a6.Text = "Success";
            if (in6.Text != "xyz")
                b6.Text = "Fail";

            if (val7 == 1m)
                a7.Text = "Success";
            if (val7 != 1m)
                b7.Text = "Fail";

            if (val8a == 1m)
                if (val8b == 2m)
                    a8.Text = "Success";
            if (val8a == 1m)
                if (val8b != 2m)
                    b8.Text = "Fail";

            if (in9.Text == "500")
                a9.Text = "Success";
            if (in9.Text != "500")
                b9.Text = "Fail";

            if (val10a == 2m)
                if (val10b == 3m)
                {
                    a10.Text = "Success";
                }
            if (val10a != 2m)
                if (val10b == 3m)
                {
                    b10.Text = "Fail";
                }

            //cool thing
            //bool val4 = Convert.ToBoolean(in4.Text);
            //if (val4 == false)
            //(don't need weird stuff to specify I guess)
        }
    }
}
