using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing.Histogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Opening";
            if (dOpen.ShowDialog() != DialogResult.OK) return;
            picBox1.Image = new Bitmap(dOpen.OpenFile(), true);
            filepath = dOpen.FileName;
            picBox11.Image = null;
            picBox2.Image = null;
            picBox22.Image = null;
            button3.Enabled = false;
            toolStripStatusLabel1.Text = "Click Get Histogram";
            //statusStrip1.ResumeLayout (false);
            //statusStrip1.PerformLayout ();
            //ResumeLayout (false);
            //PerformLayout ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Computing";
            try
            {

                long[] myValues = GetHistogram(new Bitmap(picBox1.Image));

                //maxVal = (int)myValues[0];
                double tempMax = myValues[0];
                int.TryParse(Math.Round(tempMax).ToString(), out maxVal);

                for (int i = 1; i < myValues.Length; i++)
                {
                    if (myValues[i] > maxVal)
                    {
                        tempMax = myValues[i];
                        int.TryParse(Math.Round(tempMax).ToString(), out maxVal);
                        //maxVal = (int)myValues[i];
                    }
                }

                drawHistro(myValues, 1);
                button3.Enabled = true;
                toolStripStatusLabel1.Text = "Click Contrast Streching";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                long[] myValues = GetHistogram(new Bitmap(picBox2.Image));
                drawHistro(myValues, 2);
                toolStripStatusLabel1.Text = "Ready";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tbval.Text = "" + trackBar.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setContrast();
            picBox22.Image = null;
            button4.Enabled = true;
            toolStripStatusLabel1.Text = "Click Get Histogram";
        }
    }
}
