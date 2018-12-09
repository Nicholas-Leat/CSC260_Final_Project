using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool pass = true;
            string name = Employee_Add_Name.Text.ToString();
            string PayRate = Employee_Pay.Text.ToString();
            double rate = 0;
            string PTO = Employee_PTO.Text.ToString();
            int pto_rate = -1;
            int.TryParse(PTO, out pto_rate);
         
            var employee = new Employee();
            var employee_pay = new pay(employee);
            var employee_PTO = new benifits(employee);
            var employee_hours = new Hours(employee);
            
            try
            {
                rate = Double.Parse(PayRate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must Enter Valid Pay Rate!");
                pass = false;
            }
            if (!string.IsNullOrEmpty(name))
            {
                employee.set_name(name);
                employee_pay.set_pay_rate(rate);
                employee_PTO.set_PTO_rate(pto_rate);
            }
            else
            {
                MessageBox.Show("Employee Name is Required!");
                pass = false;
            }
                  
            if(pto_rate == -1)
            {
                MessageBox.Show("Must Enter Valid PTO Rate");
                pass = false;
            }
            bool g = false;

            while (g == false)
            {
                int random_ID;
                Random rnd = new Random();
                random_ID = rnd.Next(1000, 9999);

                String conn = ConfigurationManager.ConnectionStrings["Con1"].ConnectionString;
                SqlConnection con = new SqlConnection(conn);
                SqlDataAdapter sqa = new SqlDataAdapter("Select count (*) From Employees where ID = '" + random_ID + "'", con);
                DataTable dt = new DataTable();
                sqa.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    employee.set_id(random_ID);
                    g = true;
                }
            }

            if (pass)
            {
                using (SqlConnection cons = new SqlConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString))
                using (SqlCommand cmd = new SqlCommand("insert into Employees (Name, PayRate, PTORate, ID) values ('" + employee.get_name() + "', " + employee_pay.get_pay_rate() + ", " + employee_PTO.get_pto_rate() + ", " +employee.get_ID()+"); SELECT SCOPE_IDENTITY(); ", cons))

                {
                    cons.Open();                 
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }

                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
            }
        //Not Used
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
