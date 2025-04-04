﻿using Fallout4Launcher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fallout_4_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 frmstngs = new Form2();

        void StopAutorun()
        {
            timer1.Stop();
            lblTimer.Visible=false;
            lblTimer2.Visible=false;
            if (Settings1.Default.AutorunS) lblStop.Visible = true;
        }
        

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkGray;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkGray;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkGray;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled) StopAutorun();
            if (!File.Exists(Settings1.Default.btn1S))
            {
                MessageBox.Show("Can't find \""+ Settings1.Default.btn1S+ "\"\nSelect a File From the Settings", "Error");
            }
            else
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Settings1.Default.btn1S;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
                Environment.Exit(0);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) StopAutorun();
            if (!File.Exists(Settings1.Default.btn2S))
            {
                MessageBox.Show("Can't find \"" + Settings1.Default.btn2S + "\"\nSelect a File From the Settings", "Error");
            }
            else
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Settings1.Default.btn2S;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer2.Text = Convert.ToString(Convert.ToInt16(lblTimer2.Text)-1);

            if(lblTimer2.Text=="0")
            {
                label1_Click(sender, e);
            }
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkGray;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) StopAutorun();
            frmstngs.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Settings1.Default.label1S;
            label2.Text = Settings1.Default.label2S;

            if(Settings1.Default.AutorunS)
            {
                timer1.Enabled = true;
                lblTimer.Visible = true;
                lblTimer2.Visible = true;
                lblTimer2.Text = Settings1.Default.Counter.ToString();
            }
        }


        // MOVE BORDERLESS FORM
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
