using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class UCMassLog : UserControl
    {
        public UCMassLog()
        {
            InitializeComponent();
        }

        private void ColorClear()
        {
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ColorClear();
            pictureBox5.Visible = true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            ColorClear();
            pictureBox6.Visible = true;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ColorClear();
            pictureBox7.Visible = true;
        }
    }
}
