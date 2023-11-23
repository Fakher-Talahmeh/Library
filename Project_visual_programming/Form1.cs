using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_visual_programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Register")
            {
                panel2.Visible = !panel2.Visible;
                panel5.Visible = !panel5.Visible;
                button1.Text = "Login";
            }
            else if (button1.Text == "Login")
            {
                panel2.Visible = !panel2.Visible;
                panel5.Visible = !panel5.Visible;
                button1.Text = "Register";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
