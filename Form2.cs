using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fallout4Launcher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        static string Search()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe|Shortcuts (*.lnk)|*.lnk";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else return string.Empty;
        }

        static void DEFAULTS()
        {
            Settings1.Default.AutorunS = true;
            Settings1.Default.label1S="PLAY";
            Settings1.Default.label2S = "Open Launcher";
            Settings1.Default.btn1S = "Game File";
            Settings1.Default.btn2S = "Launcher File";
            Settings1.Default.Counter = 15;
            Settings1.Default.Save();
        }
        void Current()
        {
            textBox1.Text = Settings1.Default.label1S;
            textBox2.Text = Settings1.Default.label2S;
            richTextBox1.Text = Settings1.Default.btn1S;
            richTextBox2.Text = Settings1.Default.btn2S;
            chkAutorun.Checked = Settings1.Default.AutorunS;
            txtCount.Text = Settings1.Default.Counter.ToString();
            txtCount.ReadOnly = !Settings1.Default.AutorunS;
        }

        string path1=Settings1.Default.btn1S;
        string path2=Settings1.Default.btn2S;
        bool autorun = Settings1.Default.AutorunS;

        private void Form2_Load(object sender, EventArgs e)
        {
            Current();
        }



        private void chkAutorun_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutorun.Checked)
            {
                autorun = true;
                txtCount.ReadOnly = false;
            }
            else
            {
                autorun = false;
                txtCount.ReadOnly = true;
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Current();
            this.Hide();
            e.Cancel = true;
        }

        private void btndefault_Click(object sender, EventArgs e)
        {
            DEFAULTS();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Environment.Exit(0);
        }

        private void btnSelectfile1_Click(object sender, EventArgs e)
        {
            string path= Search();
            if (path == "") MessageBox.Show("No Path Selected","Cancelled");
            else path1 = path;
            richTextBox1.Text = path;
        }

        private void btnSelectFile2_Click(object sender, EventArgs e)
        {
            string path = Search();
            if (path == "") MessageBox.Show("No Path Selected","Cancelled");
            else path2 = path;
            richTextBox2.Text = path;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            int cdT = Convert.ToInt16(txtCount.Text);
            if (cdT < 3 || cdT > 30)
            {
                MessageBox.Show("Interval for countdown is 3-30 seconds", "Warning");
                return;
            }
            else
            {
                Settings1.Default.label1S = textBox1.Text;
                Settings1.Default.label2S = textBox2.Text;
                Settings1.Default.btn1S = path1;
                Settings1.Default.btn2S = path2;
                Settings1.Default.AutorunS = autorun;
                Settings1.Default.Counter = Convert.ToInt16(txtCount.Text);
                Settings1.Default.Save();
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Environment.Exit(0);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 13;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 13;
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            txtCount.MaxLength = 2;
        }
    }
}
