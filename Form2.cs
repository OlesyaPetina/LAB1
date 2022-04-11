using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LABcr;

namespace LAB1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
       
        }
        Cream cream_us2 = new Cream();
        Cream change_cream_us2 = new Cream();
        public ListBox lBox1;
        public ListBox lBox2;
        public ListBox lBox3;
        public ListBox lBox4;

        

        private void button1_Click(object sender, EventArgs e)
        {
            cream_us2.cream_name = textBox1.Text;
            cream_us2.price = textBox2.Text;
            cream_us2.cream_type = textBox3.Text;
            cream_us2.composition = richTextBox1.Text;

            lBox1.Items.Add(cream_us2.cream_name);
            lBox2.Items.Add(cream_us2.price);
            lBox3.Items.Add(cream_us2.cream_type);
            lBox4.Items.Add(cream_us2.composition);


            //using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Users\\Олеся\\Desktop\\visual\\LAB1\\name.txt"))

            //using (System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\Users\\Олеся\\Desktop\\visual\\LAB1\\name.txt"))

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = lBox1.SelectedItem.ToString();
        }
    }
}
