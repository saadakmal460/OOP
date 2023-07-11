
namespace GUI.GUI
{
    partial class NoticesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkAddHostelite = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkRemoveHostelite = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 730);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.download;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 53);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.Hms_PhotoRoom1;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(51, 353);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Hostel Managment System";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(681, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notices";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.linkAddHostelite);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(646, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 130);
            this.panel2.TabIndex = 13;
            // 
            // linkAddHostelite
            // 
            this.linkAddHostelite.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkAddHostelite.AutoSize = true;
            this.linkAddHostelite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.linkAddHostelite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAddHostelite.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkAddHostelite.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkAddHostelite.Location = new System.Drawing.Point(95, 12);
            this.linkAddHostelite.Name = "linkAddHostelite";
            this.linkAddHostelite.Size = new System.Drawing.Size(169, 92);
            this.linkAddHostelite.TabIndex = 1;
            this.linkAddHostelite.TabStop = true;
            this.linkAddHostelite.Text = "View\r\nNotices\r\n";
            this.linkAddHostelite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddHostelite_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.bullet_list;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(646, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 130);
            this.panel3.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(95, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 92);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add a \r\nNotice\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources._1091916;
            this.pictureBox3.Location = new System.Drawing.Point(0, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.linkRemoveHostelite);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(646, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 118);
            this.panel4.TabIndex = 6;
            // 
            // linkRemoveHostelite
            // 
            this.linkRemoveHostelite.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkRemoveHostelite.AutoSize = true;
            this.linkRemoveHostelite.BackColor = System.Drawing.Color.Gainsboro;
            this.linkRemoveHostelite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRemoveHostelite.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkRemoveHostelite.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkRemoveHostelite.Location = new System.Drawing.Point(82, 19);
            this.linkRemoveHostelite.Name = "linkRemoveHostelite";
            this.linkRemoveHostelite.Size = new System.Drawing.Size(214, 88);
            this.linkRemoveHostelite.TabIndex = 3;
            this.linkRemoveHostelite.TabStop = true;
            this.linkRemoveHostelite.Text = "Remove a \r\nNotice\r\n";
            this.linkRemoveHostelite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemoveHostelite_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources._7037649;
            this.pictureBox4.Location = new System.Drawing.Point(3, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // NoticesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 728);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1225, 775);
            this.MinimumSize = new System.Drawing.Size(1225, 775);
            this.Name = "NoticesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoticesForm";
            this.Load += new System.EventHandler(this.NoticesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkAddHostelite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkRemoveHostelite;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}