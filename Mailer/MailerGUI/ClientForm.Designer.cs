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
            this.lblSubject = new System.Windows.Forms.Label();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.gridMail = new System.Windows.Forms.DataGridView();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMailer.SuspendLayout();
            this.tabMail.SuspendLayout();
            this.panContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMailer
            // 
            this.tabMailer.Controls.Add(this.tabMail);
            this.tabMailer.Controls.Add(this.tabSend);
            this.tabMailer.Location = new System.Drawing.Point(0, 0);
            this.tabMailer.Name = "tabMailer";
            this.tabMailer.SelectedIndex = 0;
            this.tabMailer.Size = new System.Drawing.Size(963, 528);
            this.tabMailer.TabIndex = 0;
            // 
            // tabMail
            // 
            this.tabMail.Controls.Add(this.lbMail);
            this.tabMail.Controls.Add(this.panContent);
            this.tabMail.Location = new System.Drawing.Point(4, 29);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(955, 495);
            this.tabMail.TabIndex = 1;
            this.tabMail.Text = "Mail";
            this.tabMail.UseVisualStyleBackColor = true;
            this.tabMail.Click += new System.EventHandler(this.tabMail_Click);
            // 
            // lbMail
            // 
            this.lbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMail.FormattingEnabled = true;
            this.lbMail.ItemHeight = 23;
            this.lbMail.Location = new System.Drawing.Point(6, 6);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(426, 483);
            this.lbMail.TabIndex = 2;
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.lblSubject);
            this.panContent.Location = new System.Drawing.Point(438, 6);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(511, 483);
            this.panContent.TabIndex = 1;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(34, 29);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(58, 20);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject";
            // 
            // tabSend
            // 
            this.tabSend.Location = new System.Drawing.Point(4, 29);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabSend.Size = new System.Drawing.Size(955, 495);
            this.tabSend.TabIndex = 0;
            this.tabSend.Text = "Write";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // gridMail
            // 
            this.gridMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFrom,
            this.colSubject,
            this.colDate});
            this.gridMail.Location = new System.Drawing.Point(969, 35);
            this.gridMail.Name = "gridMail";
            this.gridMail.RowHeadersWidth = 51;
            this.gridMail.RowTemplate.Height = 29;
            this.gridMail.Size = new System.Drawing.Size(429, 495);
            this.gridMail.TabIndex = 0;
            this.gridMail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMail_CellClick);
            this.gridMail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMail_CellContentClick);
            // 
            // colFrom
            // 
            this.colFrom.HeaderText = "From";
            this.colFrom.MinimumWidth = 6;
            this.colFrom.Name = "colFrom";
            this.colFrom.Width = 125;
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "Subject";
            this.colSubject.MinimumWidth = 6;
            this.colSubject.Name = "colSubject";
            this.colSubject.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.Width = 125;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 529);
            this.Controls.Add(this.tabMailer);
            this.Controls.Add(this.gridMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "MailClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MailClient_FormClosed);
            this.Load += new System.EventHandler(this.MailClient_Load);
            this.tabMailer.ResumeLayout(false);
            this.tabMail.ResumeLayout(false);
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMailer;
        private TabPage tabSend;
        private TabPage tabMail;
        private DataGridView gridMail;
        private Panel panContent;
        private Label lblSubject;
        private DataGridViewTextBoxColumn colFrom;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn colDate;
        public ListBox lbMail;
    }
}