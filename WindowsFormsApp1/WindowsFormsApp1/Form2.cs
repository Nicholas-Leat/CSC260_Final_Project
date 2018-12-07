using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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