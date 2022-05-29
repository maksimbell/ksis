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
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.cbSsl = new System.Windows.Forms.CheckBox();
            this.panSettings = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panLogin = new System.Windows.Forms.Panel();
            this.panSettings.SuspendLayout();
            this.panLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginArea
            // 
            this.loginArea.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginArea.Location = new System.Drawing.Point(12, 50);
            this.loginArea.Name = "loginArea";
            this.loginArea.Size = new System.Drawing.Size(262, 38);
            this.loginArea.TabIndex = 0;
            this.loginArea.Text = "";
            // 
            // passwordArea
            // 
            this.passwordArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordArea.Location = new System.Drawing.Point(12, 106);
            this.passwordArea.Name = "passwordArea";
            this.passwordArea.Size = new System.Drawing.Size(262, 38);
            this.passwordArea.TabIndex = 1;
            this.passwordArea.Text = "*********";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 167);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(27, 113);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(151, 28);
            this.cbServer.TabIndex = 3;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(27, 60);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(151, 27);
            this.tbPort.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(27, 31);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 20);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(27, 90);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(50, 20);
            this.lblServer.TabIndex = 6;
            this.lblServer.Text = "Server";
            // 
            // cbSsl
            // 
            this.cbSsl.AutoSize = true;
            this.cbSsl.Location = new System.Drawing.Point(27, 162);
            this.cbSsl.Name = "cbSsl";
            this.cbSsl.Size = new System.Drawing.Size(54, 24);
            this.cbSsl.TabIndex = 7;
            this.cbSsl.Text = "SSL";
            this.cbSsl.UseVisualStyleBackColor = true;
            this.cbSsl.CheckedChanged += new System.EventHandler(this.cbSsl_CheckedChanged);
            // 
            // panSettings
            // 
            this.panSettings.Controls.Add(this.cbServer);
            this.panSettings.Controls.Add(this.cbSsl);
            this.panSettings.Controls.Add(this.tbPort);
            this.panSettings.Controls.Add(this.lblServer);
            this.panSettings.Controls.Add(this.lblPort);
            this.panSettings.Location = new System.Drawing.Point(34, 111);
            this.panSettings.Name = "panSettings";
            this.panSettings.Size = new System.Drawing.Size(210, 212);
            this.panSettings.TabIndex = 8;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(12, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(93, 38);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Log in";
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.passwordArea);
            this.panLogin.Controls.Add(this.lblLogin);
            this.panLogin.Controls.Add(this.loginArea);
            this.panLogin.Controls.Add(this.btnLogin);
            this.panLogin.Location = new System.Drawing.Point(308, 111);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(311, 212);
            this.panLogin.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Mailer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panSettings.ResumeLayout(false);
            this.panSettings.PerformLayout();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox loginArea;
        private RichTextBox passwordArea;
        private Button btnLogin;
        private ComboBox cbServer;
        private TextBox tbPort;
        private Label lblPort;
        private Label lblServer;
        private CheckBox cbSsl;
        private Panel panSettings;
        private Label lblLogin;
        private Panel panLogin;
    }
}