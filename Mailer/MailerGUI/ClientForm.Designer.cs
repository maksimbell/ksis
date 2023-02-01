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
            this.btnReload = new System.Windows.Forms.Button();
            this.lbMail = new System.Windows.Forms.ListBox();
            this.panContent = new System.Windows.Forms.Panel();
            this.tvMailAtt = new System.Windows.Forms.TreeView();
            this.rtbSubject = new System.Windows.Forms.RichTextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSenderOrg = new System.Windows.Forms.Label();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.tvAttachments = new System.Windows.Forms.TreeView();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbMessageSend = new System.Windows.Forms.RichTextBox();
            this.rtbSubSend = new System.Windows.Forms.RichTextBox();
            this.rtbToSend = new System.Windows.Forms.RichTextBox();
            this.llblSub = new System.Windows.Forms.LinkLabel();
            this.llblTo = new System.Windows.Forms.LinkLabel();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabMailer.SuspendLayout();
            this.tabMail.SuspendLayout();
            this.panContent.SuspendLayout();
            this.tabSend.SuspendLayout();
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
            this.tabMail.Controls.Add(this.btnReload);
            this.tabMail.Controls.Add(this.lbMail);
            this.tabMail.Controls.Add(this.panContent);
            this.tabMail.Location = new System.Drawing.Point(4, 29);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(1127, 495);
            this.tabMail.TabIndex = 1;
            this.tabMail.Text = "Mail";
            this.tabMail.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(385, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 26);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Refresh";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // lbMail
            // 
            this.lbMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMail.FormattingEnabled = true;
            this.lbMail.ItemHeight = 28;
            this.lbMail.Location = new System.Drawing.Point(6, 39);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(485, 450);
            this.lbMail.TabIndex = 2;
            this.lbMail.SelectedIndexChanged += new System.EventHandler(this.lbMail_SelectedIndexChanged);
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.tvMailAtt);
            this.panContent.Controls.Add(this.rtbSubject);
            this.panContent.Controls.Add(this.rtbContent);
            this.panContent.Controls.Add(this.lblDate);
            this.panContent.Controls.Add(this.lblSenderOrg);
            this.panContent.Location = new System.Drawing.Point(497, 6);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(627, 483);
            this.panContent.TabIndex = 1;
            // 
            // tvMailAtt
            // 
            this.tvMailAtt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tvMailAtt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMailAtt.Location = new System.Drawing.Point(320, 398);
            this.tvMailAtt.Name = "tvMailAtt";
            this.tvMailAtt.ShowNodeToolTips = true;
            this.tvMailAtt.Size = new System.Drawing.Size(266, 70);
            this.tvMailAtt.TabIndex = 8;
            this.tvMailAtt.DoubleClick += new System.EventHandler(this.tvMailAtt_DoubleClick);
            // 
            // rtbSubject
            // 
            this.rtbSubject.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSubject.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbSubject.Location = new System.Drawing.Point(36, 24);
            this.rtbSubject.Name = "rtbSubject";
            this.rtbSubject.ReadOnly = true;
            this.rtbSubject.Size = new System.Drawing.Size(550, 72);
            this.rtbSubject.TabIndex = 4;
            this.rtbSubject.Text = "";
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Location = new System.Drawing.Point(36, 156);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(550, 312);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(437, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "MailDate";
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
            // 
            // tabSend
            // 
            this.tabSend.Controls.Add(this.tvAttachments);
            this.tabSend.Controls.Add(this.btnAttach);
            this.tabSend.Controls.Add(this.btnSend);
            this.tabSend.Controls.Add(this.rtbMessageSend);
            this.tabSend.Controls.Add(this.rtbSubSend);
            this.tabSend.Controls.Add(this.rtbToSend);
            this.tabSend.Controls.Add(this.llblSub);
            this.tabSend.Controls.Add(this.llblTo);
            this.tabSend.Location = new System.Drawing.Point(4, 29);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabSend.Size = new System.Drawing.Size(1127, 495);
            this.tabSend.TabIndex = 0;
            this.tabSend.Text = "New message";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // tvAttachments
            // 
            this.tvAttachments.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tvAttachments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvAttachments.Location = new System.Drawing.Point(85, 314);
            this.tvAttachments.Name = "tvAttachments";
            this.tvAttachments.ShowNodeToolTips = true;
            this.tvAttachments.Size = new System.Drawing.Size(569, 70);
            this.tvAttachments.TabIndex = 7;
            this.tvAttachments.DoubleClick += new System.EventHandler(this.tvAttachments_DoubleClick);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.SlateGray;
            this.btnAttach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttach.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAttach.Location = new System.Drawing.Point(525, 424);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(145, 52);
            this.btnAttach.TabIndex = 6;
            this.btnAttach.Text = "Attach files";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSend.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSend.Location = new System.Drawing.Point(72, 424);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(145, 52);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbMessageSend
            // 
            this.rtbMessageSend.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbMessageSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessageSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbMessageSend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMessageSend.Location = new System.Drawing.Point(72, 151);
            this.rtbMessageSend.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMessageSend.Name = "rtbMessageSend";
            this.rtbMessageSend.Size = new System.Drawing.Size(598, 249);
            this.rtbMessageSend.TabIndex = 4;
            this.rtbMessageSend.Text = "";
            // 
            // rtbSubSend
            // 
            this.rtbSubSend.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbSubSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSubSend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbSubSend.Location = new System.Drawing.Point(185, 88);
            this.rtbSubSend.Name = "rtbSubSend";
            this.rtbSubSend.Size = new System.Drawing.Size(485, 33);
            this.rtbSubSend.TabIndex = 3;
            this.rtbSubSend.Text = "";
            // 
            // rtbToSend
            // 
            this.rtbToSend.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbToSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbToSend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbToSend.Location = new System.Drawing.Point(185, 32);
            this.rtbToSend.Name = "rtbToSend";
            this.rtbToSend.Size = new System.Drawing.Size(485, 33);
            this.rtbToSend.TabIndex = 2;
            this.rtbToSend.Text = "lilfidgetx@gmail.com";
            this.rtbToSend.TextChanged += new System.EventHandler(this.rtbToSend_TextChanged);
            // 
            // llblSub
            // 
            this.llblSub.AutoSize = true;
            this.llblSub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llblSub.LinkColor = System.Drawing.Color.Black;
            this.llblSub.Location = new System.Drawing.Point(72, 95);
            this.llblSub.Name = "llblSub";
            this.llblSub.Size = new System.Drawing.Size(75, 23);
            this.llblSub.TabIndex = 1;
            this.llblSub.TabStop = true;
            this.llblSub.Text = "Subject";
            // 
            // llblTo
            // 
            this.llblTo.AutoSize = true;
            this.llblTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llblTo.LinkColor = System.Drawing.Color.Black;
            this.llblTo.Location = new System.Drawing.Point(72, 42);
            this.llblTo.Name = "llblTo";
            this.llblTo.Size = new System.Drawing.Size(91, 23);
            this.llblTo.TabIndex = 0;
            this.llblTo.TabStop = true;
            this.llblTo.Text = "Recipient";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.tabMailer.ResumeLayout(false);
            this.tabMail.ResumeLayout(false);
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.tabSend.ResumeLayout(false);
            this.tabSend.PerformLayout();
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
        private LinkLabel llblTo;
        private RichTextBox rtbToSend;
        private RichTextBox rtbSubSend;
        private LinkLabel llblSub;
        private RichTextBox rtbMessageSend;
        private Button btnSend;
        private Button btnAttach;
        private TreeView tvAttachments;
        private Button btnReload;
        private TreeView tvMailAtt;
        private SaveFileDialog SaveFileDialog;
    }
}