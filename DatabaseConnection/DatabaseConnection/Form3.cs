using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text; // Assuming usernameTextBox is the TextBox for entering username
            string password = textBox2.Text; // Assuming passwordTextBox is the TextBox for entering password

            // Call the check_login method to validate the credentials
            Class1 obj1=new Class1();
            obj1.check_login(username, password);
            if(obj1.check_login(username, password)==true)
            {
                MessageBox.Show("Login Successfully");
                Form1 obj = new Form1();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
           
         }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
