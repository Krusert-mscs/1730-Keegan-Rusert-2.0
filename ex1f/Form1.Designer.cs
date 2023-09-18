
namespace Ex1F
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picCanada = new System.Windows.Forms.Button();
            this.picUK = new System.Windows.Forms.Button();
            this.picJapan = new System.Windows.Forms.Button();
            this.picEurope = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtUSDollars = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtTotalUS = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.TextBox();
            this.picCanadaDim = new System.Windows.Forms.Button();
            this.picUKDim = new System.Windows.Forms.Button();
            this.picJapanDim = new System.Windows.Forms.Button();
            this.picEuropeDim = new System.Windows.Forms.Button();
            this.btnCanada = new System.Windows.Forms.Button();
            this.btnUK = new System.Windows.Forms.Button();
            this.btnJapan = new System.Windows.Forms.Button();
            this.btnEurope = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEquation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // picCanada
            // 
            this.picCanada.Image = ((System.Drawing.Image)(resources.GetObject("picCanada.Image")));
            this.picCanada.Location = new System.Drawing.Point(12, 393);
            this.picCanada.Name = "picCanada";
            this.picCanada.Size = new System.Drawing.Size(72, 54);
            this.picCanada.TabIndex = 0;
            this.picCanada.Text = "Canadian Dollar";
            this.picCanada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picCanada.UseVisualStyleBackColor = true;
            this.picCanada.Visible = false;
            // 
            // picUK
            // 
            this.picUK.Image = ((System.Drawing.Image)(resources.GetObject("picUK.Image")));
            this.picUK.Location = new System.Drawing.Point(193, 395);
            this.picUK.Name = "picUK";
            this.picUK.Size = new System.Drawing.Size(70, 52);
            this.picUK.TabIndex = 1;
            this.picUK.Text = "British Pound";
            this.picUK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picUK.UseVisualStyleBackColor = true;
            this.picUK.Visible = false;
            // 
            // picJapan
            // 
            this.picJapan.Image = ((System.Drawing.Image)(resources.GetObject("picJapan.Image")));
            this.picJapan.Location = new System.Drawing.Point(419, 399);
            this.picJapan.Name = "picJapan";
            this.picJapan.Size = new System.Drawing.Size(47, 52);
            this.picJapan.TabIndex = 2;
            this.picJapan.Text = "Yen";
            this.picJapan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picJapan.UseVisualStyleBackColor = true;
            this.picJapan.Visible = false;
            // 
            // picEurope
            // 
            this.picEurope.Image = ((System.Drawing.Image)(resources.GetObject("picEurope.Image")));
            this.picEurope.Location = new System.Drawing.Point(553, 399);
            this.picEurope.Name = "picEurope";
            this.picEurope.Size = new System.Drawing.Size(47, 48);
            this.picEurope.TabIndex = 3;
            this.picEurope.Text = "Euro";
            this.picEurope.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picEurope.UseVisualStyleBackColor = true;
            this.picEurope.Visible = false;
            this.picEurope.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "US Dollars:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(211, 248);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(189, 23);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.Click += new System.EventHandler(this.txtCurrency_Enter);
            this.txtRate.TextChanged += new System.EventHandler(this.calcUSD);
            // 
            // txtUSDollars
            // 
            this.txtUSDollars.Location = new System.Drawing.Point(211, 306);
            this.txtUSDollars.Name = "txtUSDollars";
            this.txtUSDollars.ReadOnly = true;
            this.txtUSDollars.Size = new System.Drawing.Size(189, 23);
            this.txtUSDollars.TabIndex = 7;
            this.txtUSDollars.Text = "0.00";
            this.txtUSDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(211, 189);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(189, 23);
            this.txtCurrency.TabIndex = 8;
            this.txtCurrency.Text = "0.00";
            this.txtCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCurrency.Click += new System.EventHandler(this.txtCurrency_Enter);
            this.txtCurrency.TextChanged += new System.EventHandler(this.calcUSD);
            this.txtCurrency.Enter += new System.EventHandler(this.txtCurrency_Enter);
            // 
            // txtTotalUS
            // 
            this.txtTotalUS.Location = new System.Drawing.Point(211, 362);
            this.txtTotalUS.Name = "txtTotalUS";
            this.txtTotalUS.ReadOnly = true;
            this.txtTotalUS.Size = new System.Drawing.Size(189, 23);
            this.txtTotalUS.TabIndex = 9;
            this.txtTotalUS.Text = "0.00";
            this.txtTotalUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(325, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(713, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCurrency.Location = new System.Drawing.Point(55, 189);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.ReadOnly = true;
            this.lblCurrency.Size = new System.Drawing.Size(100, 23);
            this.lblCurrency.TabIndex = 12;
            this.lblCurrency.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // picCanadaDim
            // 
            this.picCanadaDim.Image = ((System.Drawing.Image)(resources.GetObject("picCanadaDim.Image")));
            this.picCanadaDim.Location = new System.Drawing.Point(101, 393);
            this.picCanadaDim.Name = "picCanadaDim";
            this.picCanadaDim.Size = new System.Drawing.Size(72, 54);
            this.picCanadaDim.TabIndex = 13;
            this.picCanadaDim.Text = "Canadian Dollar";
            this.picCanadaDim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picCanadaDim.UseVisualStyleBackColor = true;
            this.picCanadaDim.Visible = false;
            // 
            // picUKDim
            // 
            this.picUKDim.Image = ((System.Drawing.Image)(resources.GetObject("picUKDim.Image")));
            this.picUKDim.Location = new System.Drawing.Point(269, 397);
            this.picUKDim.Name = "picUKDim";
            this.picUKDim.Size = new System.Drawing.Size(70, 52);
            this.picUKDim.TabIndex = 14;
            this.picUKDim.Text = "British Pound";
            this.picUKDim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picUKDim.UseVisualStyleBackColor = true;
            this.picUKDim.Visible = false;
            // 
            // picJapanDim
            // 
            this.picJapanDim.Image = ((System.Drawing.Image)(resources.GetObject("picJapanDim.Image")));
            this.picJapanDim.Location = new System.Drawing.Point(472, 399);
            this.picJapanDim.Name = "picJapanDim";
            this.picJapanDim.Size = new System.Drawing.Size(47, 52);
            this.picJapanDim.TabIndex = 15;
            this.picJapanDim.Text = "Yen";
            this.picJapanDim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picJapanDim.UseVisualStyleBackColor = true;
            this.picJapanDim.Visible = false;
            // 
            // picEuropeDim
            // 
            this.picEuropeDim.Image = ((System.Drawing.Image)(resources.GetObject("picEuropeDim.Image")));
            this.picEuropeDim.Location = new System.Drawing.Point(606, 401);
            this.picEuropeDim.Name = "picEuropeDim";
            this.picEuropeDim.Size = new System.Drawing.Size(47, 48);
            this.picEuropeDim.TabIndex = 16;
            this.picEuropeDim.Text = "Euro";
            this.picEuropeDim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.picEuropeDim.UseVisualStyleBackColor = true;
            this.picEuropeDim.Visible = false;
            // 
            // btnCanada
            // 
            this.btnCanada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCanada.Location = new System.Drawing.Point(55, 22);
            this.btnCanada.Name = "btnCanada";
            this.btnCanada.Size = new System.Drawing.Size(135, 103);
            this.btnCanada.TabIndex = 17;
            this.btnCanada.Text = "Canadian Dollar";
            this.btnCanada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCanada.UseVisualStyleBackColor = true;
            this.btnCanada.Click += new System.EventHandler(this.btnCanada_Click);
            // 
            // btnUK
            // 
            this.btnUK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUK.Location = new System.Drawing.Point(223, 22);
            this.btnUK.Name = "btnUK";
            this.btnUK.Size = new System.Drawing.Size(135, 103);
            this.btnUK.TabIndex = 18;
            this.btnUK.Text = "British Pound";
            this.btnUK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUK.UseVisualStyleBackColor = true;
            this.btnUK.Click += new System.EventHandler(this.btnUK_Click);
            // 
            // btnJapan
            // 
            this.btnJapan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJapan.Location = new System.Drawing.Point(393, 22);
            this.btnJapan.Name = "btnJapan";
            this.btnJapan.Size = new System.Drawing.Size(135, 103);
            this.btnJapan.TabIndex = 19;
            this.btnJapan.Text = "Japanese Yen";
            this.btnJapan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJapan.UseVisualStyleBackColor = true;
            this.btnJapan.Click += new System.EventHandler(this.btnJapan_Click);
            // 
            // btnEurope
            // 
            this.btnEurope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEurope.Location = new System.Drawing.Point(564, 22);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(135, 103);
            this.btnEurope.TabIndex = 20;
            this.btnEurope.Text = "Euro";
            this.btnEurope.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEurope.UseVisualStyleBackColor = true;
            this.btnEurope.Click += new System.EventHandler(this.btnEurope_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(419, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 34);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEquation
            // 
            this.lblEquation.Location = new System.Drawing.Point(55, 329);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(135, 56);
            this.lblEquation.TabIndex = 22;
            this.lblEquation.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblEquation.UseVisualStyleBackColor = true;
            this.lblEquation.Click += new System.EventHandler(this.lblEquation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEurope);
            this.Controls.Add(this.btnJapan);
            this.Controls.Add(this.btnUK);
            this.Controls.Add(this.btnCanada);
            this.Controls.Add(this.picEuropeDim);
            this.Controls.Add(this.picJapanDim);
            this.Controls.Add(this.picUKDim);
            this.Controls.Add(this.picCanadaDim);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtTotalUS);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtUSDollars);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picEurope);
            this.Controls.Add(this.picJapan);
            this.Controls.Add(this.picUK);
            this.Controls.Add(this.picCanada);
            this.Name = "Form1";
            this.Text = "Currency Exchange";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button picCanada;
        private System.Windows.Forms.Button picUK;
        private System.Windows.Forms.Button picJapan;
        private System.Windows.Forms.Button picEurope;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtUSDollars;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtTotalUS;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox lblCurrency;
        private System.Windows.Forms.Button picCanadaDim;
        private System.Windows.Forms.Button picUKDim;
        private System.Windows.Forms.Button picJapanDim;
        private System.Windows.Forms.Button picEuropeDim;
        private System.Windows.Forms.Button btnCanada;
        private System.Windows.Forms.Button btnUK;
        private System.Windows.Forms.Button btnJapan;
        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button lblEquation;
    }
}

