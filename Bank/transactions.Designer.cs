namespace Bank
{
    partial class transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transactions));
            this.txtTransaction = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.listTransactions = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTransactions)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTransaction
            // 
            this.txtTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTransaction.Location = new System.Drawing.Point(128, 41);
            this.txtTransaction.Name = "txtTransaction";
            this.txtTransaction.Size = new System.Drawing.Size(164, 20);
            this.txtTransaction.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(235, 64);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(57, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit >";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Transaction Code:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtTransaction);
            this.panel1.Location = new System.Drawing.Point(243, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 118);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBalance.Location = new System.Drawing.Point(310, 409);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(253, 13);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "£0.00";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listTransactions
            // 
            this.listTransactions.AllowUserToAddRows = false;
            this.listTransactions.AllowUserToDeleteRows = false;
            this.listTransactions.AllowUserToResizeColumns = false;
            this.listTransactions.AllowUserToResizeRows = false;
            this.listTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colTransaction,
            this.colAmount});
            this.listTransactions.Location = new System.Drawing.Point(243, 221);
            this.listTransactions.Name = "listTransactions";
            this.listTransactions.RowHeadersVisible = false;
            this.listTransactions.Size = new System.Drawing.Size(320, 185);
            this.listTransactions.TabIndex = 17;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No.";
            this.colNo.Name = "colNo";
            // 
            // colTransaction
            // 
            this.colTransaction.HeaderText = "Transaction Number";
            this.colTransaction.Name = "colTransaction";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.listTransactions);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 18;
            // 
            // transactions
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "transactions";
            this.Text = "DGLI Bank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listTransactions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTransaction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridView listTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.Panel panel2;
    }
}

