
namespace GUI.GUI
{
    partial class AddExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpenseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrorLine = new System.Windows.Forms.Label();
            this.lblErrorTax = new System.Windows.Forms.Label();
            this.lblErrorAmount = new System.Windows.Forms.Label();
            this.lblerrorName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.panel1.TabIndex = 2;
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
            this.label7.Location = new System.Drawing.Point(617, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = "Add an Expense";
            // 
            // lblErrorLine
            // 
            this.lblErrorLine.AutoSize = true;
            this.lblErrorLine.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorLine.Location = new System.Drawing.Point(871, 531);
            this.lblErrorLine.Name = "lblErrorLine";
            this.lblErrorLine.Size = new System.Drawing.Size(0, 17);
            this.lblErrorLine.TabIndex = 53;
            this.lblErrorLine.Visible = false;
            // 
            // lblErrorTax
            // 
            this.lblErrorTax.AutoSize = true;
            this.lblErrorTax.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorTax.Location = new System.Drawing.Point(700, 329);
            this.lblErrorTax.Name = "lblErrorTax";
            this.lblErrorTax.Size = new System.Drawing.Size(105, 17);
            this.lblErrorTax.TabIndex = 52;
            this.lblErrorTax.Text = "Invalid amount!!";
            this.lblErrorTax.Visible = false;
            this.lblErrorTax.Click += new System.EventHandler(this.lblErrorTax_Click);
            // 
            // lblErrorAmount
            // 
            this.lblErrorAmount.AutoSize = true;
            this.lblErrorAmount.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorAmount.Location = new System.Drawing.Point(696, 263);
            this.lblErrorAmount.Name = "lblErrorAmount";
            this.lblErrorAmount.Size = new System.Drawing.Size(105, 17);
            this.lblErrorAmount.TabIndex = 51;
            this.lblErrorAmount.Text = "Invalid amount!!";
            this.lblErrorAmount.Visible = false;
            this.lblErrorAmount.Click += new System.EventHandler(this.lblErrorAmount_Click);
            // 
            // lblerrorName
            // 
            this.lblerrorName.AutoSize = true;
            this.lblerrorName.ForeColor = System.Drawing.Color.Crimson;
            this.lblerrorName.Location = new System.Drawing.Point(696, 199);
            this.lblerrorName.Name = "lblerrorName";
            this.lblerrorName.Size = new System.Drawing.Size(93, 17);
            this.lblerrorName.TabIndex = 50;
            this.lblerrorName.Text = "Invalid name!!";
            this.lblerrorName.Visible = false;
            this.lblerrorName.Click += new System.EventHandler(this.lblerrorName_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(494, 488);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 40);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(874, 488);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 40);
            this.btnConfirm.TabIndex = 42;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTax
            // 
            this.txtTax.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTax.Location = new System.Drawing.Point(699, 304);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(270, 22);
            this.txtTax.TabIndex = 48;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtAmount.Location = new System.Drawing.Point(699, 238);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(270, 22);
            this.txtAmount.TabIndex = 47;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPassword.Location = new System.Drawing.Point(490, 240);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 20);
            this.lblPassword.TabIndex = 46;
            this.lblPassword.Text = "Enter amount";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContact.Location = new System.Drawing.Point(462, 306);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(142, 20);
            this.lblContact.TabIndex = 45;
            this.lblContact.Text = "Enter tax amount";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // txtExpense
            // 
            this.txtExpense.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtExpense.Location = new System.Drawing.Point(699, 174);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(270, 22);
            this.txtExpense.TabIndex = 44;
            this.txtExpense.TextChanged += new System.EventHandler(this.txtExpense_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(434, 176);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 20);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Enter expense name ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
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
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 728);
            this.Controls.Add(this.lblErrorLine);
            this.Controls.Add(this.lblErrorTax);
            this.Controls.Add(this.lblErrorAmount);
            this.Controls.Add(this.lblerrorName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1225, 775);
            this.MinimumSize = new System.Drawing.Size(1225, 775);
            this.Name = "AddExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpenseForm";
            this.Load += new System.EventHandler(this.AddExpenseForm_Load);
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
        private System.Windows.Forms.Label lblErrorLine;
        private System.Windows.Forms.Label lblErrorTax;
        private System.Windows.Forms.Label lblErrorAmount;
        private System.Windows.Forms.Label lblerrorName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label lblName;
    }
}