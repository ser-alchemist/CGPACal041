using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPACal041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void chem1115_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label22, " ");
            }
            else
            {
                errorProvider1.SetError(label22, "");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label23, " ");
            }
            else
            {
                errorProvider1.SetError(label23, "");
            }
        }

        private void chem1115_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phy1116_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label30, " ");
            }
            else
            {
                errorProvider1.SetError(label30, "");
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void cse1102_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label24, " ");
            }
            else
            {
                errorProvider1.SetError(label24, "");
            }
        }

        private void cse1108_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label25, " ");
            }
            else
            {
                errorProvider1.SetError(label25, "");
            }
        }

        private void hum1107_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label26, " ");
            }
            else
            {
                errorProvider1.SetError(label26, "");
            }
        }

        private void hum1108_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label27, " ");
            }
            else
            {
                errorProvider1.SetError(label27, "");
            }
        }

        private void math1115_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label28, " ");
            }
            else
            {
                errorProvider1.SetError(label28, "");
            }
        }

        private void phy1115_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label29, " ");
            }
            else
            {
                errorProvider1.SetError(label29, "");
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label34, " ");
            }
            else
            {
                errorProvider1.SetError(label34, "");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !e.KeyChar.Equals('.') && !e.KeyChar.Equals('-') && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(label35, " ");
            }
            else
            {
                errorProvider1.SetError(label35, "");
            }
        }
    }
}
