using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string path = @"D:\";
        public static string faculty = string.Empty, deans_name= string.Empty, abbreviation = string.Empty;


        private void button1_Click(object sender, EventArgs e)
        {
           
            int index = textBox4.Text.IndexOf(".txt");
            if (index != -1)
            {
                MessageBox.Show(index.ToString());
                string path2 = path + $"{textBox4.Text}";
                File.AppendAllText(path2, $"Факультет:{faculty}" + Environment.NewLine);
                File.AppendAllText(path2, $"Декан:{deans_name}" + Environment.NewLine);
                File.AppendAllText(path2, $"Аббревиатура:{abbreviation}" + Environment.NewLine);
                File.AppendAllText(path2, "---------------------------------------" + Environment.NewLine);
                path2 = path;

            }
            else
            {
                MessageBox.Show("Неверный формат");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = faculty;
            textBox2.Text = deans_name;
            textBox3.Text = abbreviation;
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            Form2.check = 1;
            form.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void deansNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            Form2.check = 2;
            form.Show();
            this.Hide();
        }

        private void abbrevitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            Form2.check = 3;
            form.Show();
            this.Hide();
        }
    }
}
