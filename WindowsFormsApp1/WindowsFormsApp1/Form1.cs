using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            byte age = byte.Parse(txtAge.Text);
            if (age >= 18)
            {
                lblResult.Text = "Congrates!!!...You are elligible for  Vote";
            }
            else
            {
                lblResult.Text = "Sorry !!!...You are not elligible for  Vote";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtName.Text = "";
            lblResult.Text = "";
            txtName.Focus();
        }
    }
}
