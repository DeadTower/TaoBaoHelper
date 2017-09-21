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
    public partial class UCConfigurationInterface : UserControl
    {
        public UCConfigurationInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Visible)
                dataGridView2.Visible = false;
            dataGridView1.Visible = !dataGridView1.Visible;
            if (dataGridView1.Visible)
            {
                dataGridView1.Location = new System.Drawing.Point(304, 104);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible)
                dataGridView1.Visible = false;
            dataGridView2.Visible = !dataGridView2.Visible;
            if (dataGridView2.Visible)
            {
                dataGridView2.Location = new System.Drawing.Point(304, 184);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                radioButton1.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                radioButton4.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                radioButton3.Checked = false;
        }
    }
}
