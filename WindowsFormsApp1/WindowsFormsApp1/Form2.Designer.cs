namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Employee_Name = new System.Windows.Forms.TextBox();
            this.YTD_Hours = new System.Windows.Forms.TextBox();
            this.YTD_Pay = new System.Windows.Forms.TextBox();
            this.Pay_Rate = new System.Windows.Forms.TextBox();
            this.PTO_Earned = new System.Windows.Forms.TextBox();
            this.PTO_Used = new System.Windows.Forms.TextBox();
            this.Hours_Worked = new System.Windows.Forms.TextBox();
            this.Pay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PTO_Total = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.ID_BOX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pay Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "YTD Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "YTD Pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "PTO Earned";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "PTO Used";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hours Worked";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 631);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pay";
            // 
            // Employee_Name
            // 
            this.Employee_Name.Location = new System.Drawing.Point(355, 139);
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            this.Employee_Name.Size = new System.Drawing.Size(592, 38);
            this.Employee_Name.TabIndex = 8;
            this.Employee_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // YTD_Hours
            // 
            this.YTD_Hours.Location = new System.Drawing.Point(355, 218);
            this.YTD_Hours.Name = "YTD_Hours";
            this.YTD_Hours.ReadOnly = true;
            this.YTD_Hours.Size = new System.Drawing.Size(592, 38);
            this.YTD_Hours.TabIndex = 10;
            this.YTD_Hours.TextChanged += new System.EventHandler(this.YTD_Hours_TextChanged);
            // 
            // YTD_Pay
            // 
            this.YTD_Pay.Location = new System.Drawing.Point(355, 278);
            this.YTD_Pay.Name = "YTD_Pay";
            this.YTD_Pay.ReadOnly = true;
            this.YTD_Pay.Size = new System.Drawing.Size(592, 38);
            this.YTD_Pay.TabIndex = 11;
            // 
            // Pay_Rate
            // 
            this.Pay_Rate.Enabled = false;
            this.Pay_Rate.Location = new System.Drawing.Point(355, 349);
            this.Pay_Rate.Name = "Pay_Rate";
            this.Pay_Rate.ReadOnly = true;
            this.Pay_Rate.Size = new System.Drawing.Size(592, 38);
            this.Pay_Rate.TabIndex = 12;
            // 
            // PTO_Earned
            // 
            this.PTO_Earned.Location = new System.Drawing.Point(355, 421);
            this.PTO_Earned.Name = "PTO_Earned";
            this.PTO_Earned.ReadOnly = true;
            this.PTO_Earned.Size = new System.Drawing.Size(592, 38);
            this.PTO_Earned.TabIndex = 13;
            // 
            // PTO_Used
            // 
            this.PTO_Used.Location = new System.Drawing.Point(355, 491);
            this.PTO_Used.Name = "PTO_Used";
            this.PTO_Used.Size = new System.Drawing.Size(592, 38);
            this.PTO_Used.TabIndex = 14;
            // 
            // Hours_Worked
            // 
            this.Hours_Worked.Location = new System.Drawing.Point(355, 554);
            this.Hours_Worked.Name = "Hours_Worked";
            this.Hours_Worked.Size = new System.Drawing.Size(592, 38);
            this.Hours_Worked.TabIndex = 15;
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(355, 631);
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            this.Pay.Size = new System.Drawing.Size(592, 38);
            this.Pay.TabIndex = 16;
            this.Pay.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 818);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(525, 85);
            this.button1.TabIndex = 17;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(923, 818);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 86);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1234, 818);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 86);
            this.button3.TabIndex = 19;
            this.button3.Text = "Remove Employee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1354, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(1501, 297);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(664, 709);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualListSize = 1;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 703);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 32);
            this.label10.TabIndex = 26;
            this.label10.Text = "PTO Remaining";
            // 
            // PTO_Total
            // 
            this.PTO_Total.Location = new System.Drawing.Point(355, 697);
            this.PTO_Total.Name = "PTO_Total";
            this.PTO_Total.ReadOnly = true;
            this.PTO_Total.Size = new System.Drawing.Size(592, 38);
            this.PTO_Total.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1000, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 66);
            this.button4.TabIndex = 28;
            this.button4.Text = "Look Up ID";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ID_BOX
            // 
            this.ID_BOX.Location = new System.Drawing.Point(355, 66);
            this.ID_BOX.Name = "ID_BOX";
            this.ID_BOX.Size = new System.Drawing.Size(592, 38);
            this.ID_BOX.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2220, 1155);
            this.Controls.Add(this.ID_BOX);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PTO_Total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.Hours_Worked);
            this.Controls.Add(this.PTO_Used);
            this.Controls.Add(this.PTO_Earned);
            this.Controls.Add(this.Pay_Rate);
            this.Controls.Add(this.YTD_Pay);
            this.Controls.Add(this.YTD_Hours);
            this.Controls.Add(this.Employee_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "PayRoll";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Employee_Name;
        private System.Windows.Forms.TextBox YTD_Hours;
        private System.Windows.Forms.TextBox YTD_Pay;
        private System.Windows.Forms.TextBox Pay_Rate;
        private System.Windows.Forms.TextBox PTO_Earned;
        private System.Windows.Forms.TextBox PTO_Used;
        private System.Windows.Forms.TextBox Hours_Worked;
        private System.Windows.Forms.TextBox Pay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PTO_Total;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ID_BOX;
    }
}