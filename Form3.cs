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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        private int number_record;
        public void change()
        {
            textBox1.Text = liBox1.SelectedItem.ToString();
            textBox2.Text = liBox2.SelectedItem.ToString();
            textBox3.Text = liBox3.SelectedItem.ToString();
            richTextBox1.Text = liBox4.SelectedItem.ToString();

            number_record = liBox1.SelectedIndex;
        }
        

        Cream change_cream_us2 = new Cream();
        public ListBox liBox1;
        public ListBox liBox2;
        public ListBox liBox3;
        public ListBox liBox4;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите сохранить изменения?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                change_cream_us2.cream_name = textBox1.Text;
                change_cream_us2.price = textBox2.Text;
                change_cream_us2.cream_type = textBox3.Text;
                change_cream_us2.composition = richTextBox1.Text;

                liBox1.Items[number_record] = change_cream_us2.cream_name;
                liBox2.Items[number_record] = change_cream_us2.price;
                liBox3.Items[number_record] = change_cream_us2.cream_type;
                liBox4.Items[number_record] = change_cream_us2.composition;

            }    

            


        }
    }
}
