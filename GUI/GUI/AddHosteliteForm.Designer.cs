
namespace GUI.GUI
{
    partial class AddHosteliteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHosteliteForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblerrorName = new System.Windows.Forms.Label();
            this.lblErrorRollNumber = new System.Windows.Forms.Label();
            this.lblErrorCnic = new System.Windows.Forms.Label();
            this.lblErrorCity = new System.Windows.Forms.Label();
            this.lblErrorRoom = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 730);
            this.panel1.TabIndex = 0;
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(460, 188);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(190, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Enter name of hostelite";
            // 
            // txtUsename
            // 
            this.txtUsename.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUsename.Location = new System.Drawing.Point(728, 186);
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.Size = new System.Drawing.Size(270, 22);
            this.txtUsename.TabIndex = 11;
            // 
            // lblRollNumber
            // 
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRollNumber.Location = new System.Drawing.Point(506, 252);
            this.lblRollNumber.Name = "lblRollNumber";
            this.lblRollNumber.Size = new System.Drawing.Size(144, 20);
            this.lblRollNumber.TabIndex = 12;
            this.lblRollNumber.Text = "Enter roll number";
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnic.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCnic.Location = new System.Drawing.Point(557, 316);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(93, 20);
            this.lblCnic.TabIndex = 13;
            this.lblCnic.Text = "Enter CNIC";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCity.Location = new System.Drawing.Point(565, 378);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(85, 20);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "Enter City";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRoomNumber.Location = new System.Drawing.Point(493, 439);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(157, 20);
            this.lblRoomNumber.TabIndex = 15;
            this.lblRoomNumber.Text = "Allot room Number";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPassword.Location = new System.Drawing.Point(520, 505);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 20);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Enter password";
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtRollNumber.Location = new System.Drawing.Point(728, 250);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(270, 22);
            this.txtRollNumber.TabIndex = 17;
            // 
            // txtCnic
            // 
            this.txtCnic.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCnic.Location = new System.Drawing.Point(728, 316);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(270, 22);
            this.txtCnic.TabIndex = 18;
            // 
            // txtCity
            // 
            this.txtCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCity.Location = new System.Drawing.Point(728, 378);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(270, 22);
            this.txtCity.TabIndex = 19;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtRoomNumber.Location = new System.Drawing.Point(728, 439);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(270, 22);
            this.txtRoomNumber.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPassword.Location = new System.Drawing.Point(728, 503);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 22);
            this.txtPassword.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(644, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 48);
            this.label7.TabIndex = 10;
            this.label7.Text = "Add a hostelite\r\n";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(903, 584);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 40);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(497, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 40);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblerrorName
            // 
            this.lblerrorName.AutoSize = true;
            this.lblerrorName.ForeColor = System.Drawing.Color.Crimson;
            this.lblerrorName.Location = new System.Drawing.Point(725, 211);
            this.lblerrorName.Name = "lblerrorName";
            this.lblerrorName.Size = new System.Drawing.Size(93, 17);
            this.lblerrorName.TabIndex = 23;
            this.lblerrorName.Text = "Invalid name!!";
            this.lblerrorName.Visible = false;
            // 
            // lblErrorRollNumber
            // 
            this.lblErrorRollNumber.AutoSize = true;
            this.lblErrorRollNumber.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorRollNumber.Location = new System.Drawing.Point(725, 275);
            this.lblErrorRollNumber.Name = "lblErrorRollNumber";
            this.lblErrorRollNumber.Size = new System.Drawing.Size(129, 17);
            this.lblErrorRollNumber.TabIndex = 24;
            this.lblErrorRollNumber.Text = "Invalid roll number!!";
            this.lblErrorRollNumber.Visible = false;
            // 
            // lblErrorCnic
            // 
            this.lblErrorCnic.AutoSize = true;
            this.lblErrorCnic.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorCnic.Location = new System.Drawing.Point(729, 341);
            this.lblErrorCnic.Name = "lblErrorCnic";
            this.lblErrorCnic.Size = new System.Drawing.Size(89, 17);
            this.lblErrorCnic.TabIndex = 25;
            this.lblErrorCnic.Text = "Invalid CNIC!!";
            this.lblErrorCnic.Visible = false;
            // 
            // lblErrorCity
            // 
            this.lblErrorCity.AutoSize = true;
            this.lblErrorCity.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorCity.Location = new System.Drawing.Point(729, 403);
            this.lblErrorCity.Name = "lblErrorCity";
            this.lblErrorCity.Size = new System.Drawing.Size(81, 17);
            this.lblErrorCity.TabIndex = 26;
            this.lblErrorCity.Text = "Invalid City!!";
            this.lblErrorCity.Visible = false;
            // 
            // lblErrorRoom
            // 
            this.lblErrorRoom.AutoSize = true;
            this.lblErrorRoom.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorRoom.Location = new System.Drawing.Point(725, 464);
            this.lblErrorRoom.Name = "lblErrorRoom";
            this.lblErrorRoom.Size = new System.Drawing.Size(149, 17);
            this.lblErrorRoom.TabIndex = 27;
            this.lblErrorRoom.Text = "Invalid Room Number!!";
            this.lblErrorRoom.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorPassword.Location = new System.Drawing.Point(725, 528);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(119, 17);
            this.lblErrorPassword.TabIndex = 28;
            this.lblErrorPassword.Text = "Invalid Password!!";
            this.lblErrorPassword.Visible = false;
            // 
            // lblErrorLine
            // 
            this.lblErrorLine.AutoSize = true;
            this.lblErrorLine.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorLine.Location = new System.Drawing.Point(900, 646);
            this.lblErrorLine.Name = "lblErrorLine";
            this.lblErrorLine.Size = new System.Drawing.Size(247, 17);
            this.lblErrorLine.TabIndex = 29;
            this.lblErrorLine.Text = "Data was not saved! Check you inputs";
            this.lblErrorLine.Visible = false;
            // 
            // AddHosteliteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 728);
            this.Controls.Add(this.lblErrorLine);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorRoom);
            this.Controls.Add(this.lblErrorCity);
            this.Controls.Add(this.lblErrorCnic);
            this.Controls.Add(this.lblErrorRollNumber);
            this.Controls.Add(this.lblerrorName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.txtRollNumber);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.lblRollNumber);
            this.Controls.Add(this.txtUsename);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1225, 775);
            this.MinimumSize = new System.Drawing.Size(1225, 775);
            this.Name = "AddHosteliteForm";
            this.Text = "AddHosteliteForm";
            this.Load += new System.EventHandler(this.AddHosteliteForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUsename;
        private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblerrorName;
        private System.Windows.Forms.Label lblErrorRollNumber;
        private System.Windows.Forms.Label lblErrorCnic;
        private System.Windows.Forms.Label lblErrorCity;
        private System.Windows.Forms.Label lblErrorRoom;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorLine;
    }
}