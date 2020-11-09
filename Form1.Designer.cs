namespace Countdown
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl_timeLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_timeLeft
            // 
            this.lbl_timeLeft.BackColor = System.Drawing.Color.Black;
            this.lbl_timeLeft.Font = new System.Drawing.Font("Trebuchet MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeLeft.ForeColor = System.Drawing.Color.White;
            this.lbl_timeLeft.Location = new System.Drawing.Point(3, 113);
            this.lbl_timeLeft.Name = "lbl_timeLeft";
            this.lbl_timeLeft.Size = new System.Drawing.Size(341, 386);
            this.lbl_timeLeft.TabIndex = 0;
            this.lbl_timeLeft.Text = "2 years, 11 months, 20 days, 20 hours, 10 minutes, 30 seconds";
            this.lbl_timeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_timeLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_timeLeft_MouseDown);
            this.lbl_timeLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_timeLeft_MouseMove);
            this.lbl_timeLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_timeLeft_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(348, 613);
            this.Controls.Add(this.lbl_timeLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Countdown";
            this.TransparencyKey = System.Drawing.SystemColors.MenuHighlight;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_timeLeft;
        private System.Windows.Forms.Timer timer1;
    }
}

