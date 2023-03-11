using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchesToCentimetersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double CM_PER_INCH = 2.54;
            double inputInches;
            double convertedCM;

            inputInches = Double.Parse(txtInput.Text);
            convertedCM = inputInches * CM_PER_INCH;

            txtOutput.Text = convertedCM.ToString();

        }
    }
}
