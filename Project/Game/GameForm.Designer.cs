
namespace Game
{
    partial class GameForm
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
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.randomEnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbHeart3 = new System.Windows.Forms.PictureBox();
            this.pbHeart2 = new System.Windows.Forms.PictureBox();
            this.pbHeart1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Interval = 7500;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyTimer_Tick);
            // 
            // randomEnemyTimer
            // 
            this.randomEnemyTimer.Enabled = true;
            this.randomEnemyTimer.Interval = 10000;
            this.randomEnemyTimer.Tick += new System.EventHandler(this.randomEnemyTimer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(1520, 167);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 100;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(1517, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Health";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Orbitron", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(1517, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lives";
            // 
            // pbHeart3
            // 
            this.pbHeart3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart3.Image = global::Game.Properties.Resources._removal_ai__a57f3c40_39d6_465a_83fc_9df6986f68e8_heart;
            this.pbHeart3.Location = new System.Drawing.Point(1648, 254);
            this.pbHeart3.Name = "pbHeart3";
            this.pbHeart3.Size = new System.Drawing.Size(58, 38);
            this.pbHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart3.TabIndex = 5;
            this.pbHeart3.TabStop = false;
            // 
            // pbHeart2
            // 
            this.pbHeart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart2.Image = global::Game.Properties.Resources._removal_ai__a57f3c40_39d6_465a_83fc_9df6986f68e8_heart;
            this.pbHeart2.Location = new System.Drawing.Point(1584, 254);
            this.pbHeart2.Name = "pbHeart2";
            this.pbHeart2.Size = new System.Drawing.Size(58, 38);
            this.pbHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart2.TabIndex = 4;
            this.pbHeart2.TabStop = false;
            // 
            // pbHeart1
            // 
            this.pbHeart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart1.Image = global::Game.Properties.Resources._removal_ai__a57f3c40_39d6_465a_83fc_9df6986f68e8_heart;
            this.pbHeart1.Location = new System.Drawing.Point(1520, 254);
            this.pbHeart1.Name = "pbHeart1";
            this.pbHeart1.Size = new System.Drawing.Size(58, 38);
            this.pbHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart1.TabIndex = 3;
            this.pbHeart1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.BackgroundImage = global::Game.Properties.Resources.blue;
            this.ClientSize = new System.Drawing.Size(1781, 847);
            this.Controls.Add(this.pbHeart3);
            this.Controls.Add(this.pbHeart2);
            this.Controls.Add(this.pbHeart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.Timer randomEnemyTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbHeart1;
        private System.Windows.Forms.PictureBox pbHeart2;
        private System.Windows.Forms.PictureBox pbHeart3;
    }
}