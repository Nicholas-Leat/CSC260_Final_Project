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
            string x = ""; 
            InitializeComponent();
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
                    lvItem.SubItems.Add(reader["ID"].ToString() + "asdfasdfasdfas");
                    listView1.Items.Add(lvItem);
                    //listBox2.Items.Add(new ListboxItem(reader["name"], reader["ID"]));
                    //listBox2.DataSource = reader;
                    //listBox2.GetItemText.da
                  //  Console.WriteLine(String.Format("{0}", reader["name"]));
                }
            }
            con.Close();
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
            foreach(var z as listView1.selectedIndices)
            {

            }
            MessageBox.Show(listView1.SelectedIndices.ToString());
        }
    }



    //*********************************************************************************************************************


    public class Employee
    {
        protected string E_name;
        protected int ID;
        public Employee()
        {

        }

        public void set_name(string x)
        {
            E_name = x;
        }
        public void set_id(int z)
        {
            ID = z;
        }
    }
    public class Hours : Employee
    {
        protected int hours_worked;
        protected int year_hours;

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
        protected double YTD_pay;

        protected pay()
        {

        }

    }
    public class benifits : Employee
    {
        protected double PTO;

        protected benifits()
        {

        }
    }
}