
namespace Fallout4Launcher
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTXT1 = new System.Windows.Forms.Label();
            this.lblTXT2 = new System.Windows.Forms.Label();
            this.chkAutorun = new System.Windows.Forms.CheckBox();
            this.btndefault = new System.Windows.Forms.Button();
            this.lblBTN1 = new System.Windows.Forms.Label();
            this.lblBTN2 = new System.Windows.Forms.Label();
            this.btnSelectfile1 = new System.Windows.Forms.Button();
            this.btnSelectFile2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblTXT1
            // 
            this.lblTXT1.AutoSize = true;
            this.lblTXT1.Location = new System.Drawing.Point(93, 50);
            this.lblTXT1.Name = "lblTXT1";
            this.lblTXT1.Size = new System.Drawing.Size(76, 15);
            this.lblTXT1.TabIndex = 3;
            this.lblTXT1.Text = "Button 1 Text";
            // 
            // lblTXT2
            // 
            this.lblTXT2.AutoSize = true;
            this.lblTXT2.Location = new System.Drawing.Point(93, 123);
            this.lblTXT2.Name = "lblTXT2";
            this.lblTXT2.Size = new System.Drawing.Size(76, 15);
            this.lblTXT2.TabIndex = 4;
            this.lblTXT2.Text = "Button 2 Text";
            // 
            // chkAutorun
            // 
            this.chkAutorun.AutoSize = true;
            this.chkAutorun.Location = new System.Drawing.Point(75, 197);
            this.chkAutorun.Name = "chkAutorun";
            this.chkAutorun.Size = new System.Drawing.Size(115, 19);
            this.chkAutorun.TabIndex = 6;
            this.chkAutorun.Text = "Autorun Enabled";
            this.chkAutorun.UseVisualStyleBackColor = true;
            this.chkAutorun.CheckedChanged += new System.EventHandler(this.chkAutorun_CheckedChanged);
            // 
            // btndefault
            // 
            this.btndefault.Location = new System.Drawing.Point(462, 247);
            this.btndefault.Name = "btndefault";
            this.btndefault.Size = new System.Drawing.Size(100, 26);
            this.btndefault.TabIndex = 8;
            this.btndefault.Text = "Restore Defaults";
            this.btndefault.UseVisualStyleBackColor = true;
            this.btndefault.Click += new System.EventHandler(this.btndefault_Click);
            // 
            // lblBTN1
            // 
            this.lblBTN1.AutoSize = true;
            this.lblBTN1.Location = new System.Drawing.Point(271, 50);
            this.lblBTN1.Name = "lblBTN1";
            this.lblBTN1.Size = new System.Drawing.Size(122, 15);
            this.lblBTN1.TabIndex = 9;
            this.lblBTN1.Text = "Button 1 File Location";
            // 
            // lblBTN2
            // 
            this.lblBTN2.AutoSize = true;
            this.lblBTN2.Location = new System.Drawing.Point(271, 122);
            this.lblBTN2.Name = "lblBTN2";
            this.lblBTN2.Size = new System.Drawing.Size(122, 15);
            this.lblBTN2.TabIndex = 10;
            this.lblBTN2.Text = "Button 2 File Location";
            // 
            // btnSelectfile1
            // 
            this.btnSelectfile1.Location = new System.Drawing.Point(399, 46);
            this.btnSelectfile1.Name = "btnSelectfile1";
            this.btnSelectfile1.Size = new System.Drawing.Size(75, 23);
            this.btnSelectfile1.TabIndex = 11;
            this.btnSelectfile1.Text = "Select File";
            this.btnSelectfile1.UseVisualStyleBackColor = true;
            this.btnSelectfile1.Click += new System.EventHandler(this.btnSelectfile1_Click);
            // 
            // btnSelectFile2
            // 
            this.btnSelectFile2.Location = new System.Drawing.Point(399, 119);
            this.btnSelectFile2.Name = "btnSelectFile2";
            this.btnSelectFile2.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile2.TabIndex = 12;
            this.btnSelectFile2.Text = "Select File";
            this.btnSelectFile2.UseVisualStyleBackColor = true;
            this.btnSelectFile2.Click += new System.EventHandler(this.btnSelectFile2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(271, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(291, 24);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(271, 148);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(291, 24);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(12, 247);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(100, 26);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Apply Settings";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(399, 195);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(115, 23);
            this.txtCount.TabIndex = 16;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(271, 198);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(113, 15);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "Time to Countdown";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(574, 282);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSelectFile2);
            this.Controls.Add(this.btnSelectfile1);
            this.Controls.Add(this.lblBTN2);
            this.Controls.Add(this.lblBTN1);
            this.Controls.Add(this.btndefault);
            this.Controls.Add(this.chkAutorun);
            this.Controls.Add(this.lblTXT2);
            this.Controls.Add(this.lblTXT1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTXT1;
        private System.Windows.Forms.Label lblTXT2;
        public System.Windows.Forms.CheckBox chkAutorun;
        private System.Windows.Forms.Button btndefault;
        private System.Windows.Forms.Label lblBTN1;
        private System.Windows.Forms.Label lblBTN2;
        private System.Windows.Forms.Button btnSelectfile1;
        private System.Windows.Forms.Button btnSelectFile2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
    }
}