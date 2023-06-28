
namespace GUI.GUI
{
    partial class GraphicalAnalysisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicalAnalysisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pannel1k = new System.Windows.Forms.Panel();
            this.pannel5k = new System.Windows.Forms.Panel();
            this.panel10k = new System.Windows.Forms.Panel();
            this.panel100k = new System.Windows.Forms.Panel();
            this.panel1M = new System.Windows.Forms.Panel();
            this.pannelE1M = new System.Windows.Forms.Panel();
            this.panelE100K = new System.Windows.Forms.Panel();
            this.panelE10K = new System.Windows.Forms.Panel();
            this.panelE1k = new System.Windows.Forms.Panel();
            this.panelE1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(624, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Graphical Analysis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.graph_paper_axis_blank_20x20_1_quadrant_010101_4477bb;
            this.pictureBox1.Location = new System.Drawing.Point(472, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "1K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "10K";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "100K";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "1M";
            // 
            // pannel1k
            // 
            this.pannel1k.BackColor = System.Drawing.Color.Green;
            this.pannel1k.Location = new System.Drawing.Point(550, 564);
            this.pannel1k.Name = "pannel1k";
            this.pannel1k.Size = new System.Drawing.Size(18, 36);
            this.pannel1k.TabIndex = 11;
            this.pannel1k.Visible = false;
            // 
            // pannel5k
            // 
            this.pannel5k.BackColor = System.Drawing.Color.Green;
            this.pannel5k.Location = new System.Drawing.Point(550, 511);
            this.pannel5k.Name = "pannel5k";
            this.pannel5k.Size = new System.Drawing.Size(18, 86);
            this.pannel5k.TabIndex = 12;
            this.pannel5k.Visible = false;
            // 
            // panel10k
            // 
            this.panel10k.BackColor = System.Drawing.Color.Green;
            this.panel10k.Location = new System.Drawing.Point(550, 441);
            this.panel10k.Name = "panel10k";
            this.panel10k.Size = new System.Drawing.Size(18, 159);
            this.panel10k.TabIndex = 13;
            this.panel10k.Visible = false;
            // 
            // panel100k
            // 
            this.panel100k.BackColor = System.Drawing.Color.Green;
            this.panel100k.Location = new System.Drawing.Point(550, 381);
            this.panel100k.Name = "panel100k";
            this.panel100k.Size = new System.Drawing.Size(18, 219);
            this.panel100k.TabIndex = 14;
            this.panel100k.Visible = false;
            // 
            // panel1M
            // 
            this.panel1M.BackColor = System.Drawing.Color.Green;
            this.panel1M.Location = new System.Drawing.Point(550, 319);
            this.panel1M.Name = "panel1M";
            this.panel1M.Size = new System.Drawing.Size(18, 278);
            this.panel1M.TabIndex = 15;
            this.panel1M.Visible = false;
            // 
            // pannelE1M
            // 
            this.pannelE1M.BackColor = System.Drawing.Color.Red;
            this.pannelE1M.Location = new System.Drawing.Point(728, 321);
            this.pannelE1M.Name = "pannelE1M";
            this.pannelE1M.Size = new System.Drawing.Size(18, 278);
            this.pannelE1M.TabIndex = 16;
            this.pannelE1M.Visible = false;
            // 
            // panelE100K
            // 
            this.panelE100K.BackColor = System.Drawing.Color.Red;
            this.panelE100K.Location = new System.Drawing.Point(728, 381);
            this.panelE100K.Name = "panelE100K";
            this.panelE100K.Size = new System.Drawing.Size(18, 219);
            this.panelE100K.TabIndex = 15;
            this.panelE100K.Visible = false;
            // 
            // panelE10K
            // 
            this.panelE10K.BackColor = System.Drawing.Color.Red;
            this.panelE10K.Location = new System.Drawing.Point(728, 441);
            this.panelE10K.Name = "panelE10K";
            this.panelE10K.Size = new System.Drawing.Size(18, 160);
            this.panelE10K.TabIndex = 14;
            this.panelE10K.Visible = false;
            // 
            // panelE1k
            // 
            this.panelE1k.BackColor = System.Drawing.Color.Red;
            this.panelE1k.Location = new System.Drawing.Point(728, 515);
            this.panelE1k.Name = "panelE1k";
            this.panelE1k.Size = new System.Drawing.Size(18, 86);
            this.panelE1k.TabIndex = 13;
            this.panelE1k.Visible = false;
            // 
            // panelE1
            // 
            this.panelE1.BackColor = System.Drawing.Color.Red;
            this.panelE1.Location = new System.Drawing.Point(728, 565);
            this.panelE1.Name = "panelE1";
            this.panelE1.Size = new System.Drawing.Size(18, 36);
            this.panelE1.TabIndex = 12;
            this.panelE1.Visible = false;
            // 
            // GraphicalAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 728);
            this.Controls.Add(this.panelE100K);
            this.Controls.Add(this.panelE1k);
            this.Controls.Add(this.panelE1);
            this.Controls.Add(this.panel100k);
            this.Controls.Add(this.panel10k);
            this.Controls.Add(this.pannel1k);
            this.Controls.Add(this.pannel5k);
            this.Controls.Add(this.panelE10K);
            this.Controls.Add(this.pannelE1M);
            this.Controls.Add(this.panel1M);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1225, 775);
            this.MinimumSize = new System.Drawing.Size(1225, 775);
            this.Name = "GraphicalAnalysisForm";
            this.Text = "GraphicalAnalysisForm";
            this.Load += new System.EventHandler(this.GraphicalAnalysisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pannel1k;
        private System.Windows.Forms.Panel pannel5k;
        private System.Windows.Forms.Panel panel10k;
        private System.Windows.Forms.Panel panel100k;
        private System.Windows.Forms.Panel panel1M;
        private System.Windows.Forms.Panel pannelE1M;
        private System.Windows.Forms.Panel panelE100K;
        private System.Windows.Forms.Panel panelE10K;
        private System.Windows.Forms.Panel panelE1k;
        private System.Windows.Forms.Panel panelE1;
    }
}