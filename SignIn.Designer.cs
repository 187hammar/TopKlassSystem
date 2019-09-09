namespace TopKlassSystem
{
    partial class SignInPage
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
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(101, 115);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(124, 41);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(101, 66);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(124, 43);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // SignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 259);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSignIn);
            this.Name = "SignInPage";
            this.Text = "SIGN IN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignInPage_FormClosed);
            this.Load += new System.EventHandler(this.SignInPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnRegister;
    }
}

