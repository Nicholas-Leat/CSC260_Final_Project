﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet.tblLogin' table. You can move, or remove it, as needed.
            this.tblLoginTableAdapter.Fill(this.loginDBDataSet.tblLogin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nickl\Source\Repos\CSC260_Final_Project\WindowsFormsApp1\WindowsFormsApp1\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count (*) From tblLogin where Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                MessageBox.Show("Username/Password is incorrect. Please try again!");
            }
        }
    }
}