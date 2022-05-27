namespace MailerGUI
{
    partial class MailClient
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
            this.tabMailer = new System.Windows.Forms.TabControl();
            this.tabMail = new System.Windows.Forms.TabPage();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.tabMailer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMailer
            // 
            this.tabMailer.Controls.Add(this.tabMail);
            this.tabMailer.Controls.Add(this.tabSend);
            this.tabMailer.Location = new System.Drawing.Point(0, 0);
            this.tabMailer.Name = "tabMailer";
            this.tabMailer.SelectedIndex = 0;
            this.tabMailer.Size = new System.Drawing.Size(802, 454);
            this.tabMailer.TabIndex = 0;
            // 
            // tabMail
            // 
            this.tabMail.Location = new System.Drawing.Point(4, 29);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(794, 421);
            this.tabMail.TabIndex = 1;
            this.tabMail.Text = "Mail";
            this.tabMail.UseVisualStyleBackColor = true;
            // 
            // tabSend
            // 
            this.tabSend.Location = new System.Drawing.Point(4, 29);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabSend.Size = new System.Drawing.Size(794, 421);
            this.tabSend.TabIndex = 0;
            this.tabSend.Text = "Send";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // MailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMailer);
            this.Name = "MailClient";
            this.Text = "MailClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MailClient_FormClosed);
            this.Load += new System.EventHandler(this.MailClient_Load);
            this.tabMailer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMailer;
        private TabPage tabSend;
        private TabPage tabMail;
    }
}