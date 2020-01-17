namespace Bank
{
    partial class Form1
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            this.Num2 = new System.Windows.Forms.NumericUpDown();
            this.Num3 = new System.Windows.Forms.NumericUpDown();
            this.Num4 = new System.Windows.Forms.NumericUpDown();
            this.Num5 = new System.Windows.Forms.NumericUpDown();
            this.Num6 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransfer.Location = new System.Drawing.Point(350, 346);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Num1
            // 
            this.Num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num1.Location = new System.Drawing.Point(221, 218);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(40, 20);
            this.Num1.TabIndex = 1;
            // 
            // Num2
            // 
            this.Num2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num2.Location = new System.Drawing.Point(294, 218);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(40, 20);
            this.Num2.TabIndex = 2;
            // 
            // Num3
            // 
            this.Num3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num3.Location = new System.Drawing.Point(363, 218);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(40, 20);
            this.Num3.TabIndex = 3;
            // 
            // Num4
            // 
            this.Num4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num4.Location = new System.Drawing.Point(427, 218);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(40, 20);
            this.Num4.TabIndex = 4;
            // 
            // Num5
            // 
            this.Num5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num5.Location = new System.Drawing.Point(482, 218);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(40, 20);
            this.Num5.TabIndex = 5;
            // 
            // Num6
            // 
            this.Num6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num6.Location = new System.Drawing.Point(545, 218);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(40, 20);
            this.Num6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasn\'t worked";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountNumber.Location = new System.Drawing.Point(350, 141);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasn\'t worked";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.btnTransfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.NumericUpDown Num1;
        private System.Windows.Forms.NumericUpDown Num2;
        private System.Windows.Forms.NumericUpDown Num3;
        private System.Windows.Forms.NumericUpDown Num4;
        private System.Windows.Forms.NumericUpDown Num5;
        private System.Windows.Forms.NumericUpDown Num6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
    }
}

