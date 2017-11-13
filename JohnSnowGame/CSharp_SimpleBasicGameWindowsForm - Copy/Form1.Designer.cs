namespace CSharp_SimpleBasicGameWindowsForm
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
            this.fireTimer = new System.Windows.Forms.Timer(this.components);
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.pausedTimer = new System.Windows.Forms.Timer(this.components);
            this.timerDisp = new System.Windows.Forms.Label();
            this.coin02 = new System.Windows.Forms.PictureBox();
            this.fire3 = new System.Windows.Forms.PictureBox();
            this.fire2 = new System.Windows.Forms.PictureBox();
            this.fire1 = new System.Windows.Forms.PictureBox();
            this.fire = new System.Windows.Forms.PictureBox();
            this.JohnSnow = new System.Windows.Forms.PictureBox();
            this.coinTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coin02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JohnSnow)).BeginInit();
            this.SuspendLayout();
            // 
            // fireTimer
            // 
            this.fireTimer.Enabled = true;
            this.fireTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(13, 465);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(100, 23);
            this.healthBar.TabIndex = 5;
            this.healthBar.Value = 100;
            // 
            // pausedTimer
            // 
            this.pausedTimer.Interval = 1000;
            this.pausedTimer.Tick += new System.EventHandler(this.pausedTimer_Tick);
            // 
            // timerDisp
            // 
            this.timerDisp.AutoSize = true;
            this.timerDisp.Location = new System.Drawing.Point(718, 465);
            this.timerDisp.Name = "timerDisp";
            this.timerDisp.Size = new System.Drawing.Size(13, 13);
            this.timerDisp.TabIndex = 6;
            this.timerDisp.Text = "5";
            // 
            // coin02
            // 
            this.coin02.Image = global::CSharp_SimpleBasicGameWindowsForm.Properties.Resources.CoinFront1;
            this.coin02.Location = new System.Drawing.Point(704, 410);
            this.coin02.Name = "coin02";
            this.coin02.Size = new System.Drawing.Size(27, 27);
            this.coin02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coin02.TabIndex = 9;
            this.coin02.TabStop = false;
            this.coin02.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // fire3
            // 
            this.fire3.Image = global::CSharp_SimpleBasicGameWindowsForm.Properties.Resources.fireCorrectSize;
            this.fire3.Location = new System.Drawing.Point(335, 162);
            this.fire3.Name = "fire3";
            this.fire3.Size = new System.Drawing.Size(30, 44);
            this.fire3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fire3.TabIndex = 4;
            this.fire3.TabStop = false;
            // 
            // fire2
            // 
            this.fire2.Image = global::CSharp_SimpleBasicGameWindowsForm.Properties.Resources.fireCorrectSize;
            this.fire2.Location = new System.Drawing.Point(335, 112);
            this.fire2.Name = "fire2";
            this.fire2.Size = new System.Drawing.Size(30, 44);
            this.fire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fire2.TabIndex = 3;
            this.fire2.TabStop = false;
            // 
            // fire1
            // 
            this.fire1.Image = global::CSharp_SimpleBasicGameWindowsForm.Properties.Resources.fireCorrectSize;
            this.fire1.Location = new System.Drawing.Point(335, 62);
            this.fire1.Name = "fire1";
            this.fire1.Size = new System.Drawing.Size(30, 44);
            this.fire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fire1.TabIndex = 2;
            this.fire1.TabStop = false;
            // 
            // fire
            // 
            this.fire.Image = global::CSharp_SimpleBasicGameWindowsForm.Properties.Resources.fireCorrectSize;
            this.fire.Location = new System.Drawing.Point(335, 12);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(30, 44);
            this.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fire.TabIndex = 1;
            this.fire.TabStop = false;
            // 
            // JohnSnow
            // 
            this.JohnSnow.Image = global::CSharp_SimpleBasicGameWindowsForm.Properties.Resources.newJohnSnowFaceRight;
            this.JohnSnow.Location = new System.Drawing.Point(54, 233);
            this.JohnSnow.Name = "JohnSnow";
            this.JohnSnow.Size = new System.Drawing.Size(90, 100);
            this.JohnSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.JohnSnow.TabIndex = 0;
            this.JohnSnow.TabStop = false;
            // 
            // coinTimer
            // 
            this.coinTimer.Enabled = true;
            this.coinTimer.Tick += new System.EventHandler(this.coinTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 500);
            this.Controls.Add(this.coin02);
            this.Controls.Add(this.timerDisp);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.fire3);
            this.Controls.Add(this.fire2);
            this.Controls.Add(this.fire1);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.JohnSnow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.coin02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JohnSnow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JohnSnow;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.PictureBox fire1;
        private System.Windows.Forms.PictureBox fire2;
        private System.Windows.Forms.PictureBox fire3;
        private System.Windows.Forms.Timer fireTimer;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Timer pausedTimer;
        private System.Windows.Forms.Label timerDisp;
        private System.Windows.Forms.PictureBox coin02;
        private System.Windows.Forms.Timer coinTimer;
    }
}

