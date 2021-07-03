
namespace DGLI.Bank.Forms
{
	partial class TransactionsForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.txtTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtTransaction.Location = new System.Drawing.Point(177, 44);
			this.txtTransaction.Margin = new System.Windows.Forms.Padding(4);
			this.txtTransaction.Name = "txtTransaction";
			this.txtTransaction.Size = new System.Drawing.Size(179, 26);
			this.txtTransaction.TabIndex = 8;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pictureBox1.Image = global::DGLI.Bank.Properties.Resources.pictureBox1_Image;
			this.pictureBox1.Location = new System.Drawing.Point(861, 4);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(298, 101);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// btnSubmit
			// 
			this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btnSubmit.FlatAppearance.BorderSize = 0;
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Location = new System.Drawing.Point(289, 76);
			this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(66, 26);
			this.btnSubmit.TabIndex = 11;
			this.btnSubmit.Text = "Submit >";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(8, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 20);
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
			this.panel1.Location = new System.Drawing.Point(416, 183);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(373, 136);
			this.panel1.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(413, 592);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Balance:";
			// 
			// lblBalance
			// 
			this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblBalance.Location = new System.Drawing.Point(494, 592);
			this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(295, 31);
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
			this.listTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.listTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.listTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colTransaction,
            this.colAmount});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.listTransactions.DefaultCellStyle = dataGridViewCellStyle2;
			this.listTransactions.Location = new System.Drawing.Point(416, 326);
			this.listTransactions.Margin = new System.Windows.Forms.Padding(4);
			this.listTransactions.Name = "listTransactions";
			this.listTransactions.RowHeadersVisible = false;
			this.listTransactions.RowHeadersWidth = 51;
			this.listTransactions.Size = new System.Drawing.Size(374, 262);
			this.listTransactions.TabIndex = 17;
			// 
			// colNo
			// 
			this.colNo.HeaderText = "No.";
			this.colNo.MinimumWidth = 6;
			this.colNo.Name = "colNo";
			this.colNo.ReadOnly = true;
			this.colNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// colTransaction
			// 
			this.colTransaction.HeaderText = "Transaction Number";
			this.colTransaction.MinimumWidth = 6;
			this.colTransaction.Name = "colTransaction";
			this.colTransaction.ReadOnly = true;
			this.colTransaction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// colAmount
			// 
			this.colAmount.HeaderText = "Amount";
			this.colAmount.MinimumWidth = 6;
			this.colAmount.Name = "colAmount";
			this.colAmount.ReadOnly = true;
			this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1164, 734);
			this.panel2.TabIndex = 18;
			// 
			// TransactionsForm
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1164, 734);
			this.ControlBox = false;
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TransactionsForm";
			this.Text = "DGLI Bank";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Resize += new System.EventHandler(this.transactions_Resize);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}