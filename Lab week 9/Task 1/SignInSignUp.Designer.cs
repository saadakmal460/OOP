
namespace Task_1
{
    partial class SignInSignUp
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
            this.CbSignIn = new System.Windows.Forms.CheckBox();
            this.CbSignUp = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(224, 63);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(529, 44);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Sign IN Sign UP Application";
            this.lblHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // CbSignIn
            // 
            this.CbSignIn.AutoSize = true;
            this.CbSignIn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSignIn.Location = new System.Drawing.Point(277, 293);
            this.CbSignIn.Name = "CbSignIn";
            this.CbSignIn.Size = new System.Drawing.Size(91, 28);
            this.CbSignIn.TabIndex = 1;
            this.CbSignIn.Text = "SignIN";
            this.CbSignIn.UseVisualStyleBackColor = true;
            this.CbSignIn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CbSignUp
            // 
            this.CbSignUp.AutoSize = true;
            this.CbSignUp.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSignUp.Location = new System.Drawing.Point(581, 293);
            this.CbSignUp.Name = "CbSignUp";
            this.CbSignUp.Size = new System.Drawing.Size(97, 28);
            this.CbSignUp.TabIndex = 2;
            this.CbSignUp.Text = "SignUP";
            this.CbSignUp.UseVisualStyleBackColor = true;
            this.CbSignUp.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(803, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignInSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 714);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbSignUp);
            this.Controls.Add(this.CbSignIn);
            this.Controls.Add(this.lblHeading);
            this.Name = "SignInSignUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignInSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.CheckBox CbSignIn;
        private System.Windows.Forms.CheckBox CbSignUp;
        private System.Windows.Forms.Button button1;
    }
}

