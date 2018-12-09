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
            listView1.Columns.Add("Employee", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("ID Number", -2, HorizontalAlignment.Left);
            String conn = ConfigurationManager.ConnectionStrings["Con1"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sqa = new SqlCommand("Select name, ID from [Employees] order by name", con);
            using (SqlDataReader reader = sqa.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem lvItem = new ListViewItem();
                    var item1 = new ListViewItem(new[] { reader["name"].ToString(), reader["ID"].ToString() });
                    listView1.Items.Add(item1);
                }
            }
            con.Close();
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        //Not Used
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
        //Not Used
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total_hours = 0;
            int.TryParse(YTD_Hours.Text, out int YTD_h);
            int.TryParse(Hours_Worked.Text, out int hours_c);
            total_hours = YTD_h + hours_c;
            double total_pay = 0;
            double.TryParse(YTD_Pay.Text, out double YTD_P);
            double.TryParse(Pay.Text, out double pay_c);
            total_pay = pay_c + YTD_P;

            String conn = ConfigurationManager.ConnectionStrings["Con1"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand sqa = new SqlCommand("Update Employees set YTDHours = "+total_hours.ToString()+", YTDPay = "+total_pay.ToString()+", CurrentPTO = "+PTO_Total.Text+", Pay = "+Pay.Text+" where ID = "+ID_BOX.Text, con);
            sqa.ExecuteNonQuery();
            con.Close();

            ID_BOX.Text = "";
            Employee_Name.Text = "";
            YTD_Hours.Text = "";
            YTD_Pay.Text = "";
            PTO_Earned.Text = "";
            PTO_Used.Text = "";
            Hours_Worked.Text = "";
            Pay.Text = "";
            PTO_Total.Text = "";
            Pay_Rate.Text = "";

        }
        //Not Used
        private void ID_BOX_TextChanged(object sender, EventArgs e)
        {

        }
        //Not Used
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        //Not Used
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
            con.Open();
            SqlCommand sqa = new SqlCommand("Select name, YTDHours, YTDPay, PayRate,PTORate from [Employees] where ID = " + IDs , con);
            using (SqlDataReader reader = sqa.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee_Name.Text = reader["name"].ToString();
                    YTD_Hours.Text = reader["YTDHours"].ToString();
                    YTD_Pay.Text = reader["YTDPay"].ToString();
                    Pay_Rate.Text = reader["PayRate"].ToString();
                    PTO_Earned.Text = reader["PTORate"].ToString();
                }
            }
   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var employee = new Employee();
            var employee_pay = new pay(employee);
            var employee_PTO = new benifits(employee);
            var employee_hours = new Hours(employee);

            int z = 0;
            int use_PTO = 0;
            double x = 0;
            double d = 0;
            int PTO_r = 0;
            if (!string.IsNullOrEmpty(Hours_Worked.Text)) 
            {
                if(double.TryParse(Hours_Worked.Text, out d))
                {
                    double.TryParse(Pay_Rate.Text, out x);
                    int.TryParse(Hours_Worked.Text, out z);
                    int.TryParse(PTO_Used.Text, out use_PTO);
                    int.TryParse(PTO_Earned.Text, out PTO_r);

                    employee_pay.set_pay_rate(x);
                    employee_pay.working_hour(z);
                    employee_PTO.PTO_Use(use_PTO);
                    employee_PTO.PTO_inc(PTO_r);
                    Pay.Text = employee_pay.get_pay().ToString();
                    PTO_Total.Text = employee_PTO.Get_PTO().ToString();

                }
            }
        }
    }



    //*********************************************************************************************************************


    public class Employee
    {
        public string E_name;
        public int ID;
        public int hours_worked;
        public int year_hours;
        public double YTD_pay;
        public int PTO;
        public int PTO_rate;
        public double pay_rate;
        public int PTO_used;


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
        public Hours(Employee employee)
        {
            this.hours_worked = employee.hours_worked;
            this.year_hours = employee.year_hours;
        }

        public void working_hours(int h)
        {
            hours_worked = h;
            year_hours += hours_worked;
        }
       
    }
    public class pay : Employee
    {
        

        public pay(Employee employee)
        {
            this.hours_worked = employee.hours_worked;
            this.pay_rate = employee.pay_rate;
            this.PTO_used = employee.PTO_used;
        }
        public void set_pay_rate(double z)
        {
            pay_rate = z;
        }
        public double get_pay_rate()
        {
            return pay_rate;
        }
        public void working_hour(int h)
        {
            hours_worked = h;
            year_hours += hours_worked;
        }
        public int get_hours()
        {
            return hours_worked;
        }
        public double get_pay()
        {
            double x = 0.0;
            x = hours_worked * pay_rate;
            x += PTO_used * pay_rate;
            return x;
        }

    }
    public class benifits : Employee
    {

        public benifits(Employee employee)
        {
            this.PTO = employee.PTO;
            this.PTO_used = employee.PTO_used;
            this.PTO_rate = employee.PTO_rate;
        }
        public void used_pto(int PTO_U)
        {
            PTO_used = PTO_U;
            PTO -= PTO_U;
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