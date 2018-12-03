namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.SubmitPayRoll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.PayType = new System.Windows.Forms.TextBox();
            this.YTDHours = new System.Windows.Forms.TextBox();
            this.YTDPay = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PayRate = new System.Windows.Forms.TextBox();
            this.Hours = new System.Windows.Forms.TextBox();
            this.PayBtax = new System.Windows.Forms.TextBox();
            this.Tax = new System.Windows.Forms.Label();
            this.Taxes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PayAtax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PTOUsed = new System.Windows.Forms.TextBox();
            this.PTOEarned = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitPayRoll
            // 
            this.SubmitPayRoll.Location = new System.Drawing.Point(257, 890);
            this.SubmitPayRoll.Name = "SubmitPayRoll";
            this.SubmitPayRoll.Size = new System.Drawing.Size(475, 81);
            this.SubmitPayRoll.TabIndex = 0;
            this.SubmitPayRoll.Text = "Submit Pay Roll Info";
            this.SubmitPayRoll.UseVisualStyleBackColor = true;
            this.SubmitPayRoll.Click += new System.EventHandler(this.SubmitPayRoll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salary or Hourly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "YTD HOURS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "YTD Pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hourly Pay Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hours Worked";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1649, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Employee List";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(409, 104);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(300, 38);
            this.EmployeeName.TabIndex = 9;
            // 
            // PayType
            // 
            this.PayType.Location = new System.Drawing.Point(409, 179);
            this.PayType.Name = "PayType";
            this.PayType.Size = new System.Drawing.Size(300, 38);
            this.PayType.TabIndex = 10;
            // 
            // YTDHours
            // 
            this.YTDHours.Location = new System.Drawing.Point(409, 248);
            this.YTDHours.Name = "YTDHours";
            this.YTDHours.Size = new System.Drawing.Size(300, 38);
            this.YTDHours.TabIndex = 11;
            // 
            // YTDPay
            // 
            this.YTDPay.Location = new System.Drawing.Point(409, 314);
            this.YTDPay.Name = "YTDPay";
            this.YTDPay.Size = new System.Drawing.Size(300, 38);
            this.YTDPay.TabIndex = 12;
            // 
            // PayRate
            // 
            this.PayRate.Location = new System.Drawing.Point(409, 429);
            this.PayRate.Name = "PayRate";
            this.PayRate.Size = new System.Drawing.Size(300, 38);
            this.PayRate.TabIndex = 13;
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(409, 481);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(300, 38);
            this.Hours.TabIndex = 14;
            // 
            // PayBtax
            // 
            this.PayBtax.Location = new System.Drawing.Point(409, 544);
            this.PayBtax.Name = "PayBtax";
            this.PayBtax.Size = new System.Drawing.Size(300, 38);
            this.PayBtax.TabIndex = 15;
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(143, 639);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(62, 32);
            this.Tax.TabIndex = 16;
            this.Tax.Text = "Tax";
            // 
            // Taxes
            // 
            this.Taxes.Location = new System.Drawing.Point(409, 639);
            this.Taxes.Name = "Taxes";
            this.Taxes.Size = new System.Drawing.Size(300, 38);
            this.Taxes.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 731);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "After Tax Total";
            // 
            // PayAtax
            // 
            this.PayAtax.Location = new System.Drawing.Point(409, 731);
            this.PayAtax.Name = "PayAtax";
            this.PayAtax.Size = new System.Drawing.Size(300, 38);
            this.PayAtax.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "PTO Earned";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 589);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "PTO Used";
            // 
            // PTOUsed
            // 
            this.PTOUsed.Location = new System.Drawing.Point(409, 589);
            this.PTOUsed.Name = "PTOUsed";
            this.PTOUsed.Size = new System.Drawing.Size(300, 38);
            this.PTOUsed.TabIndex = 22;
            // 
            // PTOEarned
            // 
            this.PTOEarned.Location = new System.Drawing.Point(409, 378);
            this.PTOEarned.Name = "PTOEarned";
            this.PTOEarned.Size = new System.Drawing.Size(300, 38);
            this.PTOEarned.TabIndex = 23;
            this.PTOEarned.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1957, 1030);
            this.Controls.Add(this.PTOEarned);
            this.Controls.Add(this.PTOUsed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PayAtax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Taxes);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.PayBtax);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.PayRate);
            this.Controls.Add(this.YTDPay);
            this.Controls.Add(this.YTDHours);
            this.Controls.Add(this.PayType);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitPayRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitPayRoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox PayType;
        private System.Windows.Forms.TextBox YTDHours;
        private System.Windows.Forms.TextBox YTDPay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox PayRate;
        private System.Windows.Forms.TextBox Hours;
        private System.Windows.Forms.TextBox PayBtax;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.TextBox Taxes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PayAtax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PTOUsed;
        private System.Windows.Forms.TextBox PTOEarned;
    }
}

