using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordgenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool specialCharachter = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string character = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuopasdfghjklizxcvbnm123456789";
            string character2 = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuopasdfghjklizxcvbnm123456789/*-+.";
            string crate = ("");
            if (specialCharachter)
            {
                for (int i = 0; i < Int32.Parse(textBox1.Text); i++)
                {
                    crate += character2[random.Next(character2.Length)];
                    textBox2.Text = crate;
                }
            }
            else
            {
                for (int i = 0; i < Int32.Parse(textBox1.Text); i++)
                {
                    crate += character[random.Next(character.Length)];
                    textBox2.Text = crate;
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                specialCharachter = true;
            }
            else
            {
                specialCharachter = false;
            }
        }
    }
}
