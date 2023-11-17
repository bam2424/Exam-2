using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Student ID : 5243843
namespace CIS200E2P3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.Text = "Exam 2";

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: 5243843");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {       
            if (string.IsNullOrWhiteSpace(textBox1.Text) == true)
            {
                MessageBox.Show("Enter a value");
            }
            else
            {                
                listBox1.Items.Add(textBox1.Text);              
                textBox1.Clear();
                textBox1.Focus();
            }
        }
        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}