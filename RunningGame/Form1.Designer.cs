namespace RunningGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1209, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // trex
            // 
            this.trex.Image = global::RunningGame.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(76, 367);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            this.trex.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::RunningGame.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(993, 377);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(32, 33);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 1;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            this.obstacle2.Click += new System.EventHandler(this.obstacle2_Click);
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::RunningGame.Properties.Resources.obstacle_1;
            this.obstacle1.Location = new System.Drawing.Point(685, 364);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 1;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            this.obstacle1.Click += new System.EventHandler(this.obstacle1_Click);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(12, 9);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(106, 24);
            this.textScore.TabIndex = 2;
            this.textScore.Text = "Score: 0\r\n";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1198, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.trex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

