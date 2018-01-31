using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetHearRateCalc_Class_Method
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a Valid Number");
            }

        }
         private void txtIntensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar ==(char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a Valid Number");
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            decimal rate = int.Parse(txtIntensity.Text);
            decimal maxHeartRate = 220 - age;
            decimal prct = rate / 100;
            decimal result = prct * maxHeartRate;
            decimal result2 = Math.Round(result, 000);
            string result3 = result2.ToString();
            string mxHR = maxHeartRate.ToString();
            lblHearRateTarget.Text = result3;
            lblMxHR.Text = mxHR;

            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about2 = new About();
            about2.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "For a moderate Work Out it is recommended to choose 50%-65% intensity" + Environment.NewLine + "For a vigorus and intense work out choose 65%-85% intensity" + Environment.NewLine + "The most you want to push yourself is 85% of your Maximum Heart Rate.";
            MessageBox.Show("This program is not intended to treat or diagnose anytype of illness or conditon. The developer is not responsible for any injury or death resulting in use of this software. Maximum heart rate is calculated based on user inputted age, actual maximum heart rate can vary be 10-20 beats per minute, higher or lower than the number calculated.", "Disclaimer", MessageBoxButtons.OK);
        }

        
    }
    
}
