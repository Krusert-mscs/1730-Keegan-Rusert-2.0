
namespace exif
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCanada = new System.Windows.Forms.Button();
            this.btnUK = new System.Windows.Forms.Button();
            this.btnJapan = new System.Windows.Forms.Button();
            this.btnEurope = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtUSDollars = new System.Windows.Forms.TextBox();
            this.txtTotalUS = new System.Windows.Forms.TextBox();
            this.lblEquation = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picCanada = new System.Windows.Forms.Button();
            this.picCanadaDim = new System.Windows.Forms.Button();
            this.picUK = new System.Windows.Forms.Button();
            this.picUKDim = new System.Windows.Forms.Button();
            this.picJapan = new System.Windows.Forms.Button();
            this.picJapanDim = new System.Windows.Forms.Button();
            this.picEurope = new System.Windows.Forms.Button();
            this.picEuropeDim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCanada
            // 
            this.btnCanada.Location = new System.Drawing.Point(12, 12);
            this.btnCanada.Name = "btnCanada";
            this.btnCanada.Size = new System.Drawing.Size(130, 97);
            this.btnCanada.TabIndex = 0;
            this.btnCanada.Text = "Canadian Dollar";
            this.btnCanada.UseVisualStyleBackColor = true;
            this.btnCanada.Click += new System.EventHandler(this.btnCanada_Click);
            // 
            // btnUK
            // 
            this.btnUK.Location = new System.Drawing.Point(148, 12);
            this.btnUK.Name = "btnUK";
            this.btnUK.Size = new System.Drawing.Size(130, 97);
            this.btnUK.TabIndex = 1;
            this.btnUK.Text = "British Pound";
            this.btnUK.UseVisualStyleBackColor = true;
            this.btnUK.Click += new System.EventHandler(this.btnUK_Click);
            // 
            // btnJapan
            // 
            this.btnJapan.Location = new System.Drawing.Point(284, 12);
            this.btnJapan.Name = "btnJapan";
            this.btnJapan.Size = new System.Drawing.Size(130, 97);
            this.btnJapan.TabIndex = 2;
            this.btnJapan.Text = "Japanese yen";
            this.btnJapan.UseVisualStyleBackColor = true;
            this.btnJapan.Click += new System.EventHandler(this.btnJapan_Click);
            // 
            // btnEurope
            // 
            this.btnEurope.Location = new System.Drawing.Point(420, 12);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(130, 97);
            this.btnEurope.TabIndex = 3;
            this.btnEurope.Text = "Euro";
            this.btnEurope.UseVisualStyleBackColor = true;
            this.btnEurope.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.Location = new System.Drawing.Point(12, 162);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.ReadOnly = true;
            this.lblCurrency.Size = new System.Drawing.Size(100, 20);
            this.lblCurrency.TabIndex = 4;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(148, 161);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(151, 20);
            this.txtCurrency.TabIndex = 5;
            this.txtCurrency.Text = "0.00";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(148, 200);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(151, 20);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "0.00";
            // 
            // txtUSDollars
            // 
            this.txtUSDollars.Location = new System.Drawing.Point(148, 241);
            this.txtUSDollars.Name = "txtUSDollars";
            this.txtUSDollars.ReadOnly = true;
            this.txtUSDollars.Size = new System.Drawing.Size(151, 20);
            this.txtUSDollars.TabIndex = 7;
            this.txtUSDollars.Text = "0.00";
            // 
            // txtTotalUS
            // 
            this.txtTotalUS.Location = new System.Drawing.Point(148, 280);
            this.txtTotalUS.Name = "txtTotalUS";
            this.txtTotalUS.ReadOnly = true;
            this.txtTotalUS.Size = new System.Drawing.Size(151, 20);
            this.txtTotalUS.TabIndex = 8;
            this.txtTotalUS.Text = "0.00";
            // 
            // lblEquation
            // 
            this.lblEquation.Location = new System.Drawing.Point(12, 260);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(100, 59);
            this.lblEquation.TabIndex = 9;
            this.lblEquation.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(320, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(224, 353);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(475, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picCanada
            // 
            this.picCanada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCanada.BackgroundImage")));
            this.picCanada.Image = ((System.Drawing.Image)(resources.GetObject("picCanada.Image")));
            this.picCanada.Location = new System.Drawing.Point(12, 353);
            this.picCanada.Name = "picCanada";
            this.picCanada.Size = new System.Drawing.Size(46, 43);
            this.picCanada.TabIndex = 13;
            this.picCanada.UseVisualStyleBackColor = true;
            // 
            // picCanadaDim
            // 
            this.picCanadaDim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCanadaDim.BackgroundImage")));
            this.picCanadaDim.Image = ((System.Drawing.Image)(resources.GetObject("picCanadaDim.Image")));
            this.picCanadaDim.Location = new System.Drawing.Point(66, 353);
            this.picCanadaDim.Name = "picCanadaDim";
            this.picCanadaDim.Size = new System.Drawing.Size(46, 43);
            this.picCanadaDim.TabIndex = 14;
            this.picCanadaDim.UseVisualStyleBackColor = true;
            // 
            // picUK
            // 
            this.picUK.Image = ((System.Drawing.Image)(resources.GetObject("picUK.Image")));
            this.picUK.Location = new System.Drawing.Point(118, 353);
            this.picUK.Name = "picUK";
            this.picUK.Size = new System.Drawing.Size(46, 43);
            this.picUK.TabIndex = 15;
            this.picUK.UseVisualStyleBackColor = true;
            // 
            // picUKDim
            // 
            this.picUKDim.Image = ((System.Drawing.Image)(resources.GetObject("picUKDim.Image")));
            this.picUKDim.Location = new System.Drawing.Point(170, 353);
            this.picUKDim.Name = "picUKDim";
            this.picUKDim.Size = new System.Drawing.Size(46, 43);
            this.picUKDim.TabIndex = 16;
            this.picUKDim.UseVisualStyleBackColor = true;
            // 
            // picJapan
            // 
            this.picJapan.Image = ((System.Drawing.Image)(resources.GetObject("picJapan.Image")));
            this.picJapan.Location = new System.Drawing.Point(305, 353);
            this.picJapan.Name = "picJapan";
            this.picJapan.Size = new System.Drawing.Size(46, 43);
            this.picJapan.TabIndex = 17;
            this.picJapan.UseVisualStyleBackColor = true;
            // 
            // picJapanDim
            // 
            this.picJapanDim.Image = ((System.Drawing.Image)(resources.GetObject("picJapanDim.Image")));
            this.picJapanDim.Location = new System.Drawing.Point(357, 353);
            this.picJapanDim.Name = "picJapanDim";
            this.picJapanDim.Size = new System.Drawing.Size(46, 43);
            this.picJapanDim.TabIndex = 18;
            this.picJapanDim.UseVisualStyleBackColor = true;
            // 
            // picEurope
            // 
            this.picEurope.Image = ((System.Drawing.Image)(resources.GetObject("picEurope.Image")));
            this.picEurope.Location = new System.Drawing.Point(409, 353);
            this.picEurope.Name = "picEurope";
            this.picEurope.Size = new System.Drawing.Size(46, 43);
            this.picEurope.TabIndex = 19;
            this.picEurope.UseVisualStyleBackColor = true;
            // 
            // picEuropeDim
            // 
            this.picEuropeDim.Image = ((System.Drawing.Image)(resources.GetObject("picEuropeDim.Image")));
            this.picEuropeDim.Location = new System.Drawing.Point(520, 304);
            this.picEuropeDim.Name = "picEuropeDim";
            this.picEuropeDim.Size = new System.Drawing.Size(46, 43);
            this.picEuropeDim.TabIndex = 20;
            this.picEuropeDim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "US Dollars:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picEuropeDim);
            this.Controls.Add(this.picEurope);
            this.Controls.Add(this.picJapanDim);
            this.Controls.Add(this.picJapan);
            this.Controls.Add(this.picUKDim);
            this.Controls.Add(this.picUK);
            this.Controls.Add(this.picCanadaDim);
            this.Controls.Add(this.picCanada);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.txtTotalUS);
            this.Controls.Add(this.txtUSDollars);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnEurope);
            this.Controls.Add(this.btnJapan);
            this.Controls.Add(this.btnUK);
            this.Controls.Add(this.btnCanada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCanada;
        private System.Windows.Forms.Button btnUK;
        private System.Windows.Forms.Button btnJapan;
        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.TextBox lblCurrency;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtUSDollars;
        private System.Windows.Forms.TextBox txtTotalUS;
        private System.Windows.Forms.Button lblEquation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button picCanada;
        private System.Windows.Forms.Button picCanadaDim;
        private System.Windows.Forms.Button picUK;
        private System.Windows.Forms.Button picUKDim;
        private System.Windows.Forms.Button picJapan;
        private System.Windows.Forms.Button picJapanDim;
        private System.Windows.Forms.Button picEurope;
        private System.Windows.Forms.Button picEuropeDim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

