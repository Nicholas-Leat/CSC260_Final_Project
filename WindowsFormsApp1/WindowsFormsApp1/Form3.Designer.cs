namespace WindowsFormsApp1
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Employee_Add_Name = new System.Windows.Forms.TextBox();
            this.Employee_Pay = new System.Windows.Forms.TextBox();
            this.Employee_PTO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pay Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "PTO Rate";
            // 
            // Employee_Add_Name
            // 
            this.Employee_Add_Name.Location = new System.Drawing.Point(497, 128);
            this.Employee_Add_Name.Name = "Employee_Add_Name";
            this.Employee_Add_Name.Size = new System.Drawing.Size(688, 38);
            this.Employee_Add_Name.TabIndex = 4;
            // 
            // Employee_Pay
            // 
            this.Employee_Pay.Location = new System.Drawing.Point(497, 226);
            this.Employee_Pay.Name = "Employee_Pay";
            this.Employee_Pay.Size = new System.Drawing.Size(688, 38);
            this.Employee_Pay.TabIndex = 6;
            this.Employee_Pay.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Employee_PTO
            // 
            this.Employee_PTO.Location = new System.Drawing.Point(497, 321);
            this.Employee_PTO.Name = "Employee_PTO";
            this.Employee_PTO.Size = new System.Drawing.Size(688, 38);
            this.Employee_PTO.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 84);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(805, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 84);
            this.button2.TabIndex = 10;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 703);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Employee_PTO);
            this.Controls.Add(this.Employee_Pay);
            this.Controls.Add(this.Employee_Add_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "PayRoll - Add User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Employee_Add_Name;
        private System.Windows.Forms.TextBox Employee_Pay;
        private System.Windows.Forms.TextBox Employee_PTO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}