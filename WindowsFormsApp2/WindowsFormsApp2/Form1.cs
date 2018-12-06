using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitPayRoll_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
class Employee
{
    public string Employee_Name = "abcdefghijklmnopqrstuvwxyz";
    public int years;

    public Employee()
    {
        years = 0;
     
        //Default Constructor
    }
    
    public void set_name(string name)
    {
        Employee_Name = name;
    }
    public void set_years(int x)
    {
        years = x;
    }

}
class pay : Employee
{
    public bool hourly;

    public pay()
    {
        hourly = true;
    }

    public void salary()
    {
        hourly = false;
    }
}
class YTD : Employee
{
    private double Year_Earnings = 0;
    private int Year_Hours = 0;

    public YTD()
    {

    }
    public double earnings(double earn)
    {

        Year_Earnings += earn;

        return Year_Earnings;
    }

    public int hours(int worked)
    {
        Year_Hours += worked; 

        return Year_Hours;
    }
}
class benifits:Employee
{
    public int PTO_H;
    public benifits()
    {

    }

    public void Use_Pto(int used)
    {
        PTO_H = PTO_H - used;
    }

    public void Gain_Pto(int gain)
    {
        PTO_H += gain;
    }
}