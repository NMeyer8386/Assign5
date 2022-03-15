using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign5
{
    public partial class Form1 : Form
    {
        private string[] areaCode = {"236", "250", "778", "507", "780", "805", "403",
                                     "587", "825", "306", "639", "204", "432", "807",
                                     "249", "705", "226", "519", "548", "709"};
        private double[] rate = { .05, .05, .05, .03, .03, .03, .04, .06, .06, .06,
                                  .08, .08, .08, .09, .09, .09, .10, .10, .12, .14};

        private int[] minTime = { 3, 3, 3, 0, 0, 0, 5, 5, 5, 2,
                                  2, 2, 4, 4, 4, 6, 6, 6, 8, 9};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Shutdown the painting of the comboBox as items are added.
            comboBox1.BeginUpdate();

          
            //load comboBox with the area codes
            for (int i = 0; i < areaCode.Length; i++)
            {
                comboBox1.Items.Add(areaCode[i]);
            }
           


            // Allow the comboBox to repaint and display the new items.
            comboBox1.EndUpdate();
        }


        // comboBox was changed - calculate the charges for the phone call
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int parallelIndex = comboBox1.SelectedIndex;
            int total = 0;
            double callMin = Convert.ToDouble(minTime[parallelIndex]);
            double callRate = Convert.ToDouble(rate[parallelIndex]);

            minBox.Text = Convert.ToString(callMin);

            rateBox.Text = Convert.ToString(callRate);

            total = 
        }
    }
}
