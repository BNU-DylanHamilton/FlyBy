using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlyBy
{
    public partial class Form1 : Form
    {
        const int MAX = 8;                  // there are 8 images
        Image[] images = new Image[MAX];    // set up an array to hold them
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadForm(object sender, EventArgs e)
        {
            // store all the images in the array
            for(int i = 0; i < MAX; i++)
            {
                images[i] = Image.FromFile("horsey" + i +".gif");
            }

        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method changes the image in the picture box
        /// as the timer ticks on.
        /// </summary>
        private void animateButterfly(object sender, EventArgs e)
        {
            if (count != 8)
            {
                horseyPictureBox.Image = images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void startTimer(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stopTimer(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void checkTime(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString(); //pick up date and convert
            timeLabel.Text = DateTime.Now.ToLongTimeString(); //pick up time and convert
        }
    }
}