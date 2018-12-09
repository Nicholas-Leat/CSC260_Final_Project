using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pass = true;

            int x = 0; 
            if(!Int32.TryParse(User_ID.Text, out x))
            {
                pass = false;
                MessageBox.Show("Invalid ID!");
            }
            else
            {
                String conn = ConfigurationManager.ConnectionStrings["Con1"].ConnectionString;
                SqlConnection con = new SqlConnection(conn);
                SqlDataAdapter sqa = new SqlDataAdapter("Select count (*) From Employees where ID = '" + x + "'", con);
                DataTable dt = new DataTable();
                sqa.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    SqlCommand commands = new SqlCommand("DELETE FROM Employees WHERE ID = " + x + " ", con);
                    commands.Parameters.AddWithValue("@ID", x);
                    try
                    {
                        con.Open();
                        commands.ExecuteNonQuery();
                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }


            if (pass)
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
