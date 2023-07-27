
namespace GUI.GUI
{
    partial class AddChalanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChalanForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRollNumber = new System.Windows.Forms.ComboBox();
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChallan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblChallanNumber = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 730);
            this.panel1.TabIndex = 1;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(569, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 48);
            this.label7.TabIndex = 11;
            this.label7.Text = "Generate Challan Form";
            // 
            // comboBoxRollNumber
            // 
            this.comboBoxRollNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRollNumber.FormattingEnabled = true;
            this.comboBoxRollNumber.Location = new System.Drawing.Point(704, 170);
            this.comboBoxRollNumber.Name = "comboBoxRollNumber";
            this.comboBoxRollNumber.Size = new System.Drawing.Size(270, 24);
            this.comboBoxRollNumber.TabIndex = 12;
            // 
            // lblRollNumber
            // 
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRollNumber.Location = new System.Drawing.Point(400, 174);
            this.lblRollNumber.Name = "lblRollNumber";
            this.lblRollNumber.Size = new System.Drawing.Size(235, 20);
            this.lblRollNumber.TabIndex = 13;
            this.lblRollNumber.Text = "Select roll number of student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(460, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter challan number\r\n";
            // 
            // txtChallan
            // 
            this.txtChallan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtChallan.Location = new System.Drawing.Point(704, 267);
            this.txtChallan.Name = "txtChallan";
            this.txtChallan.Size = new System.Drawing.Size(270, 22);
            this.txtChallan.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(460, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter payable amount\r\n";
            // 
            // txtAmount
            // 
            this.txtAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtAmount.Location = new System.Drawing.Point(704, 383);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(270, 22);
            this.txtAmount.TabIndex = 20;
            // 
            // lblChallanNumber
            // 
            this.lblChallanNumber.AutoSize = true;
            this.lblChallanNumber.ForeColor = System.Drawing.Color.Crimson;
            this.lblChallanNumber.Location = new System.Drawing.Point(701, 296);
            this.lblChallanNumber.Name = "lblChallanNumber";
            this.lblChallanNumber.Size = new System.Drawing.Size(157, 17);
            this.lblChallanNumber.TabIndex = 25;
            this.lblChallanNumber.Text = "Invalid Challan number!!";
            this.lblChallanNumber.Visible = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.ForeColor = System.Drawing.Color.Crimson;
            this.lblAmount.Location = new System.Drawing.Point(701, 408);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(105, 17);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "Invalid amount!!";
            this.lblAmount.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(879, 486);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 40);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "Generate";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblErrorLine
            // 
            this.lblErrorLine.AutoSize = true;
            this.lblErrorLine.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorLine.Location = new System.Drawing.Point(876, 529);
            this.lblErrorLine.Name = "lblErrorLine";
            this.lblErrorLine.Size = new System.Drawing.Size(247, 17);
            this.lblErrorLine.TabIndex = 30;
            this.lblErrorLine.Text = "Data was not saved! Check you inputs";
            this.lblErrorLine.Visible = false;
            // 
            // AddChalanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 728);
            this.Controls.Add(this.lblErrorLine);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblChallanNumber);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChallan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRollNumber);
            this.Controls.Add(this.comboBoxRollNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1225, 775);
            this.MinimumSize = new System.Drawing.Size(1225, 775);
            this.Name = "AddChalanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddChalanForm";
            this.Load += new System.EventHandler(this.AddChalanForm_Load);
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
        private System.Windows.Forms.ComboBox comboBoxRollNumber;
        private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChallan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblChallanNumber;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblErrorLine;
    }
}