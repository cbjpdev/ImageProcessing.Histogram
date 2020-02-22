namespace ImageProcessing.Histogram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.button1 = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox11 = new System.Windows.Forms.PictureBox();
            this.picBox22 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.tbval = new System.Windows.Forms.TextBox();
            this.dOpen = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox1
            // 
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox1.Location = new System.Drawing.Point(40, 56);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(256, 200);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox2.Location = new System.Drawing.Point(40, 372);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(256, 200);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 2;
            this.picBox2.TabStop = false;
            // 
            // picBox11
            // 
            this.picBox11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBox11.Location = new System.Drawing.Point(460, 56);
            this.picBox11.Name = "picBox11";
            this.picBox11.Size = new System.Drawing.Size(256, 200);
            this.picBox11.TabIndex = 3;
            this.picBox11.TabStop = false;
            // 
            // picBox22
            // 
            this.picBox22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picBox22.Location = new System.Drawing.Point(460, 372);
            this.picBox22.Name = "picBox22";
            this.picBox22.Size = new System.Drawing.Size(256, 200);
            this.picBox22.TabIndex = 4;
            this.picBox22.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Get Histogram";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(108, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Contrast Streching";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(340, 461);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "Get Histogram";
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Enabled = false;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(40, 278);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(256, 45);
            this.trackBar.TabIndex = 8;
            this.trackBar.Value = 65;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbval
            // 
            this.tbval.Location = new System.Drawing.Point(40, 332);
            this.tbval.Name = "tbval";
            this.tbval.Size = new System.Drawing.Size(50, 20);
            this.tbval.TabIndex = 9;
            this.tbval.Text = "65";
            // 
            // dOpen
            // 
            this.dOpen.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "100";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(749, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbval);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picBox22);
            this.Controls.Add(this.picBox11);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox11;
        private System.Windows.Forms.PictureBox picBox22;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox tbval;
        private System.Windows.Forms.OpenFileDialog dOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        #endregion
    }
}

