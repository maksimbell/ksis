namespace MailerGUI
{
    partial class ClientForm
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
            this.lbMail = new System.Windows.Forms.ListBox();
            this.panContent = new System.Windows.Forms.Panel();
            this.rtbSubject = new System.Windows.Forms.RichTextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSenderOrg = new System.Windows.Forms.Label();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.tabMailer.SuspendLayout();
            this.tabMail.SuspendLayout();
            this.panContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMailer
            // 
            this.tabMailer.Controls.Add(this.tabMail);
            this.tabMailer.Controls.Add(this.tabSend);
            this.tabMailer.Location = new System.Drawing.Point(0, 0);
            this.tabMailer.Name = "tabMailer";
            this.tabMailer.SelectedIndex = 0;
            this.tabMailer.Size = new System.Drawing.Size(1135, 528);
            this.tabMailer.TabIndex = 0;
            // 
            // tabMail
            // 
            this.tabMail.Controls.Add(this.lbMail);
            this.tabMail.Controls.Add(this.panContent);
            this.tabMail.Location = new System.Drawing.Point(4, 29);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(1127, 495);
            this.tabMail.TabIndex = 1;
            this.tabMail.Text = "Mail";
            this.tabMail.UseVisualStyleBackColor = true;
            this.tabMail.Click += new System.EventHandler(this.tabMail_Click);
            // 
            // lbMail
            // 
            this.lbMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMail.FormattingEnabled = true;
            this.lbMail.ItemHeight = 28;
            this.lbMail.Location = new System.Drawing.Point(6, 6);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(485, 478);
            this.lbMail.TabIndex = 2;
            this.lbMail.SelectedIndexChanged += new System.EventHandler(this.lbMail_SelectedIndexChanged);
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.rtbSubject);
            this.panContent.Controls.Add(this.rtbContent);
            this.panContent.Controls.Add(this.lblDate);
            this.panContent.Controls.Add(this.lblSenderOrg);
            this.panContent.Location = new System.Drawing.Point(497, 6);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(627, 483);
            this.panContent.TabIndex = 1;
            // 
            // rtbSubject
            // 
            this.rtbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSubject.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbSubject.Location = new System.Drawing.Point(36, 24);
            this.rtbSubject.Name = "rtbSubject";
            this.rtbSubject.Size = new System.Drawing.Size(550, 72);
            this.rtbSubject.TabIndex = 4;
            this.rtbSubject.Text = "";
            // 
            // rtbContent
            // 
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Location = new System.Drawing.Point(36, 144);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(550, 324);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(462, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "MailDate";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblSenderOrg
            // 
            this.lblSenderOrg.AutoSize = true;
            this.lblSenderOrg.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenderOrg.Location = new System.Drawing.Point(36, 100);
            this.lblSenderOrg.Name = "lblSenderOrg";
            this.lblSenderOrg.Size = new System.Drawing.Size(98, 21);
            this.lblSenderOrg.TabIndex = 1;
            this.lblSenderOrg.Text = "SenderOrg";
            this.lblSenderOrg.Click += new System.EventHandler(this.lblSenderOrg_Click);
            // 
            // tabSend
            // 
            this.tabSend.Location = new System.Drawing.Point(4, 29);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabSend.Size = new System.Drawing.Size(1127, 495);
            this.tabSend.TabIndex = 0;
            this.tabSend.Text = "Write";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 529);
            this.Controls.Add(this.tabMailer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "MailClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MailClient_FormClosed);
            this.Load += new System.EventHandler(this.MailClient_Load);
            this.tabMailer.ResumeLayout(false);
            this.tabMail.ResumeLayout(false);
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMailer;
        private TabPage tabSend;
        private TabPage tabMail;
        private Panel panContent;
        public ListBox lbMail;
        private Label lblSenderOrg;
        private Label lblDate;
        private RichTextBox rtbContent;
        private RichTextBox rtbSubject;
    }
}