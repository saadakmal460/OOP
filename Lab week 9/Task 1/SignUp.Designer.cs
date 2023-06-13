
namespace Task_1
{
    partial class SignUp
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNameSignUp = new System.Windows.Forms.Label();
            this.PassowrdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.RoleBox = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(202, 70);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(529, 44);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Sign IN Sign UP Application";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(200, 543);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(651, 543);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 42);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(237, 311);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // lblNameSignUp
            // 
            this.lblNameSignUp.AutoSize = true;
            this.lblNameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSignUp.Location = new System.Drawing.Point(237, 210);
            this.lblNameSignUp.Name = "lblNameSignUp";
            this.lblNameSignUp.Size = new System.Drawing.Size(102, 25);
            this.lblNameSignUp.TabIndex = 10;
            this.lblNameSignUp.Text = "Username";
            // 
            // PassowrdBox
            // 
            this.PassowrdBox.Location = new System.Drawing.Point(438, 315);
            this.PassowrdBox.Name = "PassowrdBox";
            this.PassowrdBox.Size = new System.Drawing.Size(294, 22);
            this.PassowrdBox.TabIndex = 9;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(438, 207);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(294, 22);
            this.NameBox.TabIndex = 8;
            // 
            // RoleBox
            // 
            this.RoleBox.Location = new System.Drawing.Point(438, 411);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(294, 22);
            this.RoleBox.TabIndex = 14;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(237, 411);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 25);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 714);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNameSignUp);
            this.Controls.Add(this.PassowrdBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.lblHeading);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNameSignUp;
        private System.Windows.Forms.TextBox PassowrdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox RoleBox;
        private System.Windows.Forms.Label lblRole;
    }
}