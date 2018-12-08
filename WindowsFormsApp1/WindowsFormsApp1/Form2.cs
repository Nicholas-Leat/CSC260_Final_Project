using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        { 
            InitializeComponent();
            listView1.Columns.Add("name", -2, HorizontalAlignment.Left);
            String conn = ConfigurationManager.ConnectionStrings["Con1"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sqa = new SqlCommand("Select name, ID from [Employees] order by name", con);
            using (SqlDataReader reader = sqa.ExecuteReader())
            {
                if (reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.SubItems[0].Text = reader["name"].ToString();
                    //lvItem.SubItems[0].Name = reader["ID"].ToString();
                    lvItem.SubItems.Add(reader["ID"].ToString());
                    listView1.Items.Add(lvItem);
                    //listBox2.Items.Add(new ListboxItem(reader["name"], reader["ID"]));
                    //listBox2.DataSource = reader;
                    //listBox2.GetItemText.da
                  //  Console.WriteLine(String.Format("{0}", reader["name"]));
                }
            }
            con.Close();
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser user = new AddUser();
            user.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveUser user = new RemoveUser();
            user.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String conn = ConfigurationManager.ConnectionStrings["Con1"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sqa = new SqlCommand("Select name from [Employees] order by name", con);
            using (SqlDataReader reader = sqa.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader["name"]));
                }
            }
            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var employee = new Employee();
            var employee_pay = new pay();
            var employee_PTO = new benifits();
            var employee_hours = new Hours();
        }

        private void ID_BOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void YTD_Hours_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IDs = 0;
            string id = ID_BOX.Text.ToString();
            int.TryParse(id, out IDs);

            String conn = ConfigurationManager.ConnectionStrings["Con1"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqa = new SqlDataAdapter("Select count (*) From Employees where ID = "+IDs+" ", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);


            con.Open();
            if(dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Button Works");
               // Employee_Name.Text.Insert(1,);
            }
        }
    }



    //*********************************************************************************************************************


    public class Employee
    {
        protected string E_name;
        protected int ID;
        protected int hours_worked;
        protected int year_hours;
        protected double YTD_pay;
        protected int PTO;
        protected int PTO_rate;
        protected double pay_rate;


        public Employee()
        {
            ID = 0;
            hours_worked = 0;
            year_hours = 0;
            YTD_pay = 0;
            PTO = 0;
            PTO_rate = 0;
            pay_rate = 0;
        }

        public void set_name(string x)
        {
            E_name = x;
        }
        public void set_id(int z)
        {
            ID = z;
        }
        public string get_name()
        {
            return E_name;
        }
        public int get_ID()
        {
            return ID;
        }
    }
    public class Hours : Employee
    {
  

        public Hours()
        {

        }

        public void working_hours(int h)
        {
            hours_worked = h;
            year_hours += hours_worked;
        }
    }
    public class pay : Employee
    {
        

        public pay()
        {

        }
        public void set_pay_rate(double z)
        {
            pay_rate = z;
        }
        public double get_pay_rate()
        {
            return pay_rate;
        }
        public double get_pay()
        {
            double x = 0.0;
            x = hours_worked * pay_rate;
            return x;
        }

    }
    public class benifits : Employee
    {

        public benifits()
        {

        }
        public void set_PTO_rate(int x)
        {
            PTO_rate = x;
        }
        public int get_pto_rate()
        {
            return PTO_rate;
        }
        public void PTO_inc(int x)
        {
            PTO += x;

        }
        public void PTO_Use(int x)
        {
            PTO = PTO - x;

        }
        public int Get_PTO()
        {
            return PTO;
        }
    }
}