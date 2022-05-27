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
            this.gridMail = new System.Windows.Forms.DataGridView();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.tabMailer.SuspendLayout();
            this.tabMail.SuspendLayout();
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
            this.tabMailer.Size = new System.Drawing.Size(802, 454);
            this.tabMailer.TabIndex = 0;
            // 
            // tabMail
            // 
            this.tabMail.Controls.Add(this.gridMail);
            this.tabMail.Location = new System.Drawing.Point(4, 29);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(794, 421);
            this.tabMail.TabIndex = 1;
            this.tabMail.Text = "Mail";
            this.tabMail.UseVisualStyleBackColor = true;
            this.tabMail.Click += new System.EventHandler(this.tabMail_Click);
            // 
            // gridMail
            // 
            this.gridMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFrom,
            this.colHeader,
            this.colDate});
            this.gridMail.Location = new System.Drawing.Point(3, 3);
            this.gridMail.Name = "gridMail";
            this.gridMail.RowHeadersWidth = 51;
            this.gridMail.RowTemplate.Height = 29;
            this.gridMail.Size = new System.Drawing.Size(461, 415);
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
            // colHeader
            // 
            this.colHeader.HeaderText = "Header";
            this.colHeader.MinimumWidth = 6;
            this.colHeader.Name = "colHeader";
            this.colHeader.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.Width = 125;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MailClient";
            this.Text = "MailClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MailClient_FormClosed);
            this.Load += new System.EventHandler(this.MailClient_Load);
            this.tabMailer.ResumeLayout(false);
            this.tabMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMailer;
        private TabPage tabSend;
        private TabPage tabMail;
        private DataGridView gridMail;
        private DataGridViewTextBoxColumn colFrom;
        private DataGridViewTextBoxColumn colHeader;
        private DataGridViewTextBoxColumn colDate;
    }
}