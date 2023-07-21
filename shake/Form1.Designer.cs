namespace shake
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.HScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picCanvas.Location = new System.Drawing.Point(12, 25);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(531, 413);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(620, 90);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 38);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(650, 162);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(43, 16);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Score";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // HScoreLabel
            // 
            this.HScoreLabel.AutoSize = true;
            this.HScoreLabel.Location = new System.Drawing.Point(650, 216);
            this.HScoreLabel.Name = "HScoreLabel";
            this.HScoreLabel.Size = new System.Drawing.Size(69, 16);
            this.HScoreLabel.TabIndex = 3;
            this.HScoreLabel.Text = "Highscore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(643, 44);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 22);
            this.namebox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HScoreLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label HScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namebox;
    }
}

