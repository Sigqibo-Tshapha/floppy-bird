namespace FlappyBirdProject
{
    partial class Form
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.floppyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameOverLbl = new System.Windows.Forms.Label();
            this.finalScoreTxt = new System.Windows.Forms.Label();
            this.gameOverBox = new System.Windows.Forms.GroupBox();
            this.restartBtn = new System.Windows.Forms.Button();
            this.ground2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floppyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.gameOverBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(437, -1);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(185, 49);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // floppyBird
            // 
            this.floppyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.floppyBird.Image = global::FlappyBirdProject.Properties.Resources.bird3;
            this.floppyBird.Location = new System.Drawing.Point(22, 119);
            this.floppyBird.Name = "floppyBird";
            this.floppyBird.Size = new System.Drawing.Size(60, 60);
            this.floppyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floppyBird.TabIndex = 1;
            this.floppyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBirdProject.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(316, -1);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(65, 219);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyBirdProject.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(435, 340);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(65, 144);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdProject.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(1, 258);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(750, 270);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.AutoSize = true;
            this.gameOverLbl.Font = new System.Drawing.Font("Comic Sans MS", 45.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLbl.ForeColor = System.Drawing.Color.Red;
            this.gameOverLbl.Location = new System.Drawing.Point(6, 16);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(443, 86);
            this.gameOverLbl.TabIndex = 5;
            this.gameOverLbl.Text = "GAME OVER!!!";
            // 
            // finalScoreTxt
            // 
            this.finalScoreTxt.AutoSize = true;
            this.finalScoreTxt.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScoreTxt.ForeColor = System.Drawing.Color.Red;
            this.finalScoreTxt.Location = new System.Drawing.Point(97, 102);
            this.finalScoreTxt.Name = "finalScoreTxt";
            this.finalScoreTxt.Size = new System.Drawing.Size(261, 52);
            this.finalScoreTxt.TabIndex = 6;
            this.finalScoreTxt.Text = "Final Score: 0";
            // 
            // gameOverBox
            // 
            this.gameOverBox.Controls.Add(this.restartBtn);
            this.gameOverBox.Controls.Add(this.gameOverLbl);
            this.gameOverBox.Controls.Add(this.finalScoreTxt);
            this.gameOverBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverBox.Location = new System.Drawing.Point(98, 176);
            this.gameOverBox.Name = "gameOverBox";
            this.gameOverBox.Size = new System.Drawing.Size(454, 228);
            this.gameOverBox.TabIndex = 7;
            this.gameOverBox.TabStop = false;
            this.gameOverBox.Visible = false;
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.restartBtn.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(146, 173);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(137, 49);
            this.restartBtn.TabIndex = 7;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // ground2
            // 
            this.ground2.Image = global::FlappyBirdProject.Properties.Resources.ground;
            this.ground2.Location = new System.Drawing.Point(716, 258);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(750, 270);
            this.ground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground2.TabIndex = 8;
            this.ground2.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(877, 531);
            this.Controls.Add(this.floppyBird);
            this.Controls.Add(this.gameOverBox);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.ground2);
            this.Name = "Form";
            this.Text = "Floppy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gameKeyIsOther);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.floppyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.gameOverBox.ResumeLayout(false);
            this.gameOverBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox floppyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label gameOverLbl;
        private System.Windows.Forms.Label finalScoreTxt;
        private System.Windows.Forms.GroupBox gameOverBox;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.PictureBox ground2;
    }
}

