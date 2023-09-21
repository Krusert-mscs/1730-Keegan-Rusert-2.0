
namespace ex1e
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.rageQuit = new System.Windows.Forms.Button();
            this.test1 = new System.Windows.Forms.TextBox();
            this.test2 = new System.Windows.Forms.TextBox();
            this.test3 = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(108, 18);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Caculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(108, 55);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // rageQuit
            // 
            this.rageQuit.Location = new System.Drawing.Point(108, 169);
            this.rageQuit.Name = "rageQuit";
            this.rageQuit.Size = new System.Drawing.Size(75, 23);
            this.rageQuit.TabIndex = 7;
            this.rageQuit.Text = "Rage Quit";
            this.rageQuit.UseVisualStyleBackColor = true;
            this.rageQuit.Click += new System.EventHandler(this.rageQuit_Click);
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(61, 18);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(41, 20);
            this.test1.TabIndex = 1;
            this.test1.Text = "0";
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(61, 52);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(41, 20);
            this.test2.TabIndex = 2;
            this.test2.Text = "0";
            // 
            // test3
            // 
            this.test3.Location = new System.Drawing.Point(61, 86);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(41, 20);
            this.test3.TabIndex = 3;
            this.test3.Text = "0";
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(72, 143);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(46, 20);
            this.average.TabIndex = 4;
            this.average.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 195);
            this.Controls.Add(this.average);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.rageQuit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button rageQuit;
        private System.Windows.Forms.TextBox test1;
        private System.Windows.Forms.TextBox test2;
        private System.Windows.Forms.TextBox test3;
        private System.Windows.Forms.TextBox average;
    }
}

