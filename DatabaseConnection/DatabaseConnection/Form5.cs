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
    public partial class Form5 : Form
    {
        public string img;

        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "Images images (*.JPG,*.PNG)|*.JPG;*.PNG; |All files(*.*)|*.*";
            if(obj.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=new System.Drawing.Bitmap(obj.FileName);
                img=obj.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return; // Exit the method if conversion fails
            }

            string name = textBox2.Text;
            string phoneNumber = textBox3.Text.Trim(); // Trim leading and trailing whitespace

            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Please enter a 10-digit phone number.");
                return; // Exit the method if validation fails
            }

            int no = cs.add(id, name, phoneNumber);
            if (no > 0)
            {
                MessageBox.Show("Registered successfully");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox2.Text;

            // Check if input contains only numeric characters
            bool isValid = input.All(char.IsLetter);

            if (!isValid)
            {
                // Show a message box indicating invalid input
                MessageBox.Show("Invalid input! Please enter only  characters for the name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
    }
}
