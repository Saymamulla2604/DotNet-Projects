using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            int id = Convert.ToInt32(textBox1.Text);
            int age = Convert.ToInt32(textBox4.Text);
            if (age < 18)
            {
                MessageBox.Show("age must be greater than 18");
            }
            float attendance=(float)Convert.ToDouble(textBox5.Text);
            int no = cs.add_data(id, textBox2.Text, textBox3.Text,age,attendance,textBox6.Text,textBox7.Text);
            if(no>0)
            {
                MessageBox.Show("data added successfully");
            }
            else
            {
                MessageBox.Show("something wrong");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Class1 cs = new Class1();
            ds = cs.show_data();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            int id = Convert.ToInt32(textBox1.Text);
            int age = Convert.ToInt32(textBox4.Text);
            float attendance = (float)Convert.ToInt32(textBox5.Text);
            int no = cs.update_data(id, textBox2.Text, textBox3.Text, age, attendance, textBox6.Text, textBox7.Text);
            if (no > 0)
            {
                MessageBox.Show("data updated successfully");
            }
            else
            {
                MessageBox.Show("something wrong");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int id;
            if(comboBox1.SelectedIndex>0)
            {
                id = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                Class1 cs = new Class1();
                DataSet ds = new DataSet();
                ds = cs.show_id_data(id);

                DataRow dr = ds.Tables[0].Rows[0];
                textBox1.Text = dr["id"].ToString();
                textBox2.Text = dr["username"].ToString();
                textBox3.Text = dr["password"].ToString();
            }*/       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Class1 cs = new Class1();
            
            int no = cs.show_id();
            textBox1.Text = no.ToString();
            
            /*label4.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
            DataSet ds = new DataSet();
            Class1 cs = new Class1();
            ds = cs.show_data();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            int id = Convert.ToInt32(textBox1.Text);
            int no = cs.delete_data(id);
            if(no>0)
            {
                MessageBox.Show("data deleted successfully");
            }
            else
            {
                MessageBox.Show("something wrong");
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {/*
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Check if input contains only numeric characters
            bool isValid = input.All(char.IsDigit);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only numeric characters for the prn.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox2.Text;

            // Check if input contains only alphabetic characters
            bool isValid = input.All(char.IsLetter);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only alphabetic characters for the first name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string input = textBox3.Text;

            // Check if input contains only alphabetic characters
            bool isValid = input.All(char.IsLetter);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only alphabetic characters for the last name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string input = textBox4.Text;

            // Check if input contains only numeric characters
            bool isValid = input.All(char.IsDigit);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only numeric characters for the age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string input = textBox5.Text;

            // Check if input contains only numeric characters
            bool isValid = input.All(char.IsDigit);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only numeric characters for the percentage.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string input = textBox6.Text;

            // Check if input contains only alphabetic characters
            bool isValid = input.All(char.IsLetter);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only alphabetic characters for the gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string input = textBox7.Text;

            // Check if input contains only alphabetic characters
            bool isValid = input.All(char.IsLetter);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only alphabetic characters for the fees paid.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
