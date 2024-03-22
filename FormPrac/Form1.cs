using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button_Click(object sender, EventArgs e)
        {
            output1.Text = textBox1.Text.ToString();
            output2.Text = textBox2.Text.ToString();
            output3.Text = textBox3.Text.ToString();
            output1.Visible = true;
            output2.Visible = true;
            output3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
