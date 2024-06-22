using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ContactusForm
{
    public partial class Form1 : Form
    {
        string emailPattern = @"^[a-zA-Z0-9._%±]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void txt(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Please fill the name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(char.IsLetter(ch)==true)
            {
                e.Handled = false;
            }
            else if (ch== 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, emailPattern)==false)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Invalid Email");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox1.Text) == true)
            {
                richTextBox1.Focus();
                errorProvider3.SetError(this.richTextBox1, "Message length should be greater than 10");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Please fill the name");
            }
            else if (Regex.IsMatch(textBox2.Text, emailPattern) == false)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Invalid Email");
            }
            else if (String.IsNullOrEmpty(richTextBox1.Text) == true)
            {
                richTextBox1.Focus();
                errorProvider3.SetError(this.richTextBox1, "Message length should be greater than 10");
            }
            else
            {
                MessageBox.Show("Message send successfully!!!");
            }
        }
    }
}
