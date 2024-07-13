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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cs = new Class1();
            
            int no = cs.add_data_register(textBox1.Text, textBox2.Text);
            if (no > 0)
            {
                MessageBox.Show("Registered successfully");
            }
            else
            {
                MessageBox.Show("something wrong");
            }
            Form3 obj = new Form3();
            obj.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
