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
              
            }


            if (pass)
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
        }
    }
}
