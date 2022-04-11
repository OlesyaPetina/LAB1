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
using LAB1;

namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (System.IO.StreamReader sr = new System.IO.StreamReader
                ("name.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
            using (System.IO.StreamReader sr = new System.IO.StreamReader
                ("price.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox2.Items.Add(sr.ReadLine());
                }
            }
            using (System.IO.StreamReader sr = new System.IO.StreamReader
                ("type.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox3.Items.Add(sr.ReadLine());
                }
            }
            using (System.IO.StreamReader sr = new System.IO.StreamReader
                ("composition.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox4.Items.Add(sr.ReadLine());
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.lBox1 = listBox1;
            F2.lBox2 = listBox2;
            F2.lBox3 = listBox3;
            F2.lBox4 = listBox4;
            F2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3
            {
                liBox1 = listBox1,
                liBox2 = listBox2,
                liBox3 = listBox3,
                liBox4 = listBox4,
            };
            F3.Show();
            F3.change();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number_but;
            number_but = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(number_but);
            listBox2.Items.RemoveAt(number_but);
            listBox3.Items.RemoveAt(number_but);
            listBox4.Items.RemoveAt(number_but);
            button2.Enabled=false;
            button3.Enabled=false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int number;
            number = listBox1.SelectedIndex;
            listBox2.SelectedIndex = number;
            listBox3.SelectedIndex = number;
            listBox4.SelectedIndex = number;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        //private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int number;
        //    number = listBox2.SelectedIndex;
        //    listBox1.SelectedIndex = number;
        //    listBox3.SelectedIndex = number;
        //    listBox4.SelectedIndex = number;
        //    button2.Enabled = true;
        //    button3.Enabled = true;
        //}

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter("name.txt"))
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                        sw.WriteLine(listBox1.Items[i].ToString());
                }
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter("price.txt"))
                {
                    for (int i = 0; i < listBox2.Items.Count; i++)
                        sw.WriteLine(listBox2.Items[i].ToString());
                }
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter("type.txt"))
                {
                    for (int i = 0; i < listBox3.Items.Count; i++)
                        sw.WriteLine(listBox3.Items[i].ToString());
                }
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter("composition.txt"))
                {
                    for (int i = 0; i < listBox4.Items.Count; i++)
                        sw.WriteLine(listBox4.Items[i].ToString());
                }

               
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {

            }
            else e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e); 
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }
        
    }
}
