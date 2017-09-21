using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication8.TabPageControl;

namespace WindowsFormsApplication8
{
    public partial class FrmMain : Form
    {
        UCExplosionSharing uc1 = new UCExplosionSharing();
        UCConfigurationInterface uc2 = new UCConfigurationInterface();
        UCWordBoard uc3 = new UCWordBoard();
        UCMassLog uc4 = new UCMassLog();
        UCDataAnalysis uc5 = new UCDataAnalysis();
        UCBusiness uc6 = new UCBusiness();
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void ClearColor()
        {
            label3.ForeColor = Color.Black;
            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            label4.ForeColor = Color.Black;
            panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            label5.ForeColor = Color.Black;
            panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            label6.ForeColor = Color.Black;
            panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            label7.ForeColor = Color.Black;
            panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            label8.ForeColor = Color.Black;
            panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            uc1.Dock = DockStyle.Fill;
            panel8.Controls.Add(uc1);
            ClearColor();
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            uc2.Dock = DockStyle.Fill;
            panel8.Controls.Add(uc2);
            ClearColor();
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            uc3.Dock = DockStyle.Fill;
            panel8.Controls.Add(uc3);
            ClearColor();
            label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            uc4.Dock = DockStyle.Fill;
            panel8.Controls.Add(uc4);
            ClearColor();
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            uc5.Dock = DockStyle.Fill;
            panel8.Controls.Add(uc5);
            ClearColor();
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            uc6.Dock = DockStyle.Fill;
            panel8.Controls.Add(uc6);
            ClearColor();
            label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(159)))), ((int)(((byte)(191)))));
            panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
        }
    }
}
