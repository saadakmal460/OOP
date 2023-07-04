
namespace GUI.GUI
{
    partial class AddReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReviewForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorLine = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 730);
            this.panel1.TabIndex = 4;
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
            this.label7.Location = new System.Drawing.Point(592, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 48);
            this.label7.TabIndex = 14;
            this.label7.Text = "View Notices";
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
            // comboBoxRating
            // 
            this.comboBoxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(627, 179);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(128, 24);
            this.comboBoxRating.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(476, 463);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 40);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(817, 463);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 40);
            this.btnConfirm.TabIndex = 48;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtReview
            // 
            this.txtReview.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtReview.Location = new System.Drawing.Point(627, 279);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(285, 112);
            this.txtReview.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(472, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Enter notice\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(411, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Select Rating(Stars)";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(814, 506);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 51;
            this.lblError.Visible = false;
            // 
            // lblErrorLine
            // 
            this.lblErrorLine.AutoSize = true;
            this.lblErrorLine.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorLine.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorLine.Location = new System.Drawing.Point(624, 394);
            this.lblErrorLine.Name = "lblErrorLine";
            this.lblErrorLine.Size = new System.Drawing.Size(58, 17);
            this.lblErrorLine.TabIndex = 52;
            this.lblErrorLine.Text = "Invalid !!\r\n";
            this.lblErrorLine.Visible = false;
            // 
            // AddReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 728);
            this.Controls.Add(this.lblErrorLine);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1225, 775);
            this.MinimumSize = new System.Drawing.Size(1225, 775);
            this.Name = "AddReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReviewForm";
            this.Load += new System.EventHandler(this.AddReviewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorLine;
    }
}