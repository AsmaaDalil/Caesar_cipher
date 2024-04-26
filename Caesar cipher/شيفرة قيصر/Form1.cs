using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace شيفرة_قيصر
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = قيصر.Ceaser.Enc(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = قيصر.Ceaser.Dec(textBox2.Text);
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
         
        }

        
    }
}
