namespace MailerGUI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginArea = new System.Windows.Forms.RichTextBox();
            this.passwordArea = new System.Windows.Forms.RichTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginArea
            // 
            this.loginArea.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginArea.Location = new System.Drawing.Point(187, 136);
            this.loginArea.Name = "loginArea";
            this.loginArea.Size = new System.Drawing.Size(262, 38);
            this.loginArea.TabIndex = 0;
            this.loginArea.Text = "";
            // 
            // passwordArea
            // 
            this.passwordArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordArea.Location = new System.Drawing.Point(187, 192);
            this.passwordArea.Name = "passwordArea";
            this.passwordArea.Size = new System.Drawing.Size(262, 38);
            this.passwordArea.TabIndex = 1;
            this.passwordArea.Text = "";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(187, 253);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordArea);
            this.Controls.Add(this.loginArea);
            this.Name = "LoginForm";
            this.Text = "Mailer";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox loginArea;
        private RichTextBox passwordArea;
        private Button btnLogin;
    }
}