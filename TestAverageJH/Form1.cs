using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAverageJH
{
    public partial class testAverageJH : Form
    {
        public testAverageJH()
        {
            InitializeComponent();
        }

        private void calculateButtonJH_Click(object sender, EventArgs e)
        {
            try
            {
                double test1;   // To hold test score #1
                double test2;   // To hold test score #2
                double test3;   // To hold test score #3
                double average; // To hold the average test score

                // Get the three test scores.
                test1 = double.Parse(test1TextBoxJH.Text);
                test2 = double.Parse(test2TextBoxJH.Text);
                test3 = double.Parse(test3TextBoxJH.Text);

                // Calculate the average test score.
                average = (test1 + test2 + test3) / 3.0;

                // Display the average test score, with
                // the output rounded to 1 decimal point.
                averageLabelJH.Text = average.ToString("n1");
            }
            catch (Exception ex)
            {
                // Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButtonJH_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls.
            test1TextBoxJH.Text = "";
            test2TextBoxJH.Text = "";
            test3TextBoxJH.Text = "";
            averageLabelJH.Text = "";
        }

        private void exitButtonJH_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
