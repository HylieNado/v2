using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check == 1)
            {
                Form1 form = new Form1();
                Form1.faculty = textBox1.Text;
                form.Show();
                this.Close();
            }
            else if (check == 2)
            {
                Form1 form = new Form1();
                Form1.deans_name = textBox1.Text;
                form.Show();
                this.Close();

            }
            else
            {
                Form1 form = new Form1();
                Form1.abbreviation = textBox1.Text;
                form.Show();
                this.Close();
            }
        }
        public static int check;
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (check == 2)
                label1.Text = "New Dean's Name";
            else
                label1.Text = "New abbreviation";

        }
    }
}
