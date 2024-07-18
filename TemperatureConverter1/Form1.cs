using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double c, f, k;
            if (rbC2F.Checked == true)
            {
                c = Double.Parse(txtValue.Text);
                f = (c * 9 / 5) + 32;
                txtResult.Text = Convert.ToString(f);
            }
            if (rbF2C.Checked == true)
            {
                f = Double.Parse(txtValue.Text);
                c = (f - 32) * 5 / 9;
                txtResult.Text = Convert.ToString(c);
            }
            if (rbC2K.Checked == true)
            {
                c = Double.Parse(txtValue.Text);
                k = (c + 253);
                txtResult.Text = Convert.ToString(k);
            }
            if (rbF2K.Checked == true)
            {
                f = Double.Parse(txtValue.Text);
                k = (f - 32) * (5 / 9) + 273.15;
                txtResult.Text = Convert.ToString(k);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtValue.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
