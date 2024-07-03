namespace RacingGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bg1 = new PictureBox();
            player = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            bg2 = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            labelLose = new Label();
            btnRestart = new Button();
            coin = new PictureBox();
            labelCoins = new Label();
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            SuspendLayout();
            // 
            // bg1
            // 
            bg1.Image = (Image)resources.GetObject("bg1.Image");
            bg1.Location = new Point(0, 0);
            bg1.Name = "bg1";
            bg1.Size = new Size(840, 650);
            bg1.TabIndex = 0;
            bg1.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(64, 64, 64);
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(365, 510);
            player.Name = "player";
            player.Size = new Size(109, 128);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // bg2
            // 
            bg2.Image = (Image)resources.GetObject("bg2.Image");
            bg2.Location = new Point(0, -650);
            bg2.Name = "bg2";
            bg2.Size = new Size(840, 650);
            bg2.TabIndex = 2;
            bg2.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.FromArgb(64, 64, 64);
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(174, -130);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(128, 128);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 3;
            enemy1.TabStop = false;
            enemy1.Click += pictureBox1_Click;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.FromArgb(64, 64, 64);
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(541, -400);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(128, 128);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 4;
            enemy2.TabStop = false;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.Red;
            labelLose.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLose.ForeColor = Color.White;
            labelLose.Location = new Point(281, 163);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(278, 60);
            labelLose.TabIndex = 5;
            labelLose.Text = "GAME OVER";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Red;
            btnRestart.FlatStyle = FlatStyle.Popup;
            btnRestart.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.White;
            btnRestart.Location = new Point(340, 265);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(152, 57);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "RESTART";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // coin
            // 
            coin.BackColor = Color.FromArgb(64, 64, 64);
            coin.Image = (Image)resources.GetObject("coin.Image");
            coin.Location = new Point(460, -550);
            coin.Name = "coin";
            coin.Size = new Size(32, 32);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 7;
            coin.TabStop = false;
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.FromArgb(192, 192, 0);
            labelCoins.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoins.ForeColor = Color.White;
            labelCoins.Location = new Point(12, 9);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(158, 50);
            labelCoins.TabIndex = 8;
            labelCoins.Text = "Coins: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(840, 650);
            Controls.Add(labelCoins);
            Controls.Add(coin);
            Controls.Add(btnRestart);
            Controls.Add(labelLose);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(player);
            Controls.Add(bg1);
            Controls.Add(bg2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)bg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg1;
        private PictureBox player;
        private System.Windows.Forms.Timer timer;
        private PictureBox bg2;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private Label labelLose;
        private Button btnRestart;
        private PictureBox coin;
        private Label labelCoins;
    }
}
