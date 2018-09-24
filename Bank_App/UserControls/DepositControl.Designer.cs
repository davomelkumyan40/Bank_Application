namespace Bank_App
{
    partial class DepositControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositControl));
            this.bankChecker = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.depositCheck = new System.Windows.Forms.Button();
            this.moneyCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depositChecker = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bankChecker
            // 
            this.bankChecker.BackColor = System.Drawing.Color.White;
            this.bankChecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bankChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankChecker.ForeColor = System.Drawing.SystemColors.InfoText;
            this.bankChecker.FormattingEnabled = true;
            this.bankChecker.Location = new System.Drawing.Point(888, 34);
            this.bankChecker.Name = "bankChecker";
            this.bankChecker.Size = new System.Drawing.Size(181, 33);
            this.bankChecker.TabIndex = 0;
            this.bankChecker.Text = "Banks";
            this.bankChecker.Click += new System.EventHandler(this.checker_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.depositCheck);
            this.panel1.Controls.Add(this.moneyCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.depositChecker);
            this.panel1.Controls.Add(this.bankChecker);
            this.panel1.Location = new System.Drawing.Point(19, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 438);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bank Privacy Policy";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(606, 297);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(16, 353);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(224, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "I accept privacy policy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // depositCheck
            // 
            this.depositCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositCheck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.depositCheck.FlatAppearance.BorderSize = 4;
            this.depositCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositCheck.ForeColor = System.Drawing.Color.White;
            this.depositCheck.Location = new System.Drawing.Point(768, 283);
            this.depositCheck.Margin = new System.Windows.Forms.Padding(0);
            this.depositCheck.Name = "depositCheck";
            this.depositCheck.Size = new System.Drawing.Size(210, 64);
            this.depositCheck.TabIndex = 7;
            this.depositCheck.Text = "Deposit Checkout";
            this.depositCheck.UseVisualStyleBackColor = true;
            this.depositCheck.Click += new System.EventHandler(this.depositCheck_Click);
            // 
            // moneyCount
            // 
            this.moneyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyCount.Location = new System.Drawing.Point(888, 178);
            this.moneyCount.Multiline = true;
            this.moneyCount.Name = "moneyCount";
            this.moneyCount.Size = new System.Drawing.Size(181, 36);
            this.moneyCount.TabIndex = 6;
            this.moneyCount.Text = "Money ($)";
            this.moneyCount.Click += new System.EventHandler(this.moneyCount_Click);
            this.moneyCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneyCount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(669, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count Of Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(669, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change Deposit Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change Bank";
            // 
            // depositChecker
            // 
            this.depositChecker.BackColor = System.Drawing.Color.White;
            this.depositChecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositChecker.ForeColor = System.Drawing.SystemColors.InfoText;
            this.depositChecker.FormattingEnabled = true;
            this.depositChecker.Location = new System.Drawing.Point(888, 106);
            this.depositChecker.Name = "depositChecker";
            this.depositChecker.Size = new System.Drawing.Size(181, 33);
            this.depositChecker.TabIndex = 2;
            this.depositChecker.Text = "Deposits";
            this.depositChecker.Click += new System.EventHandler(this.checker_Click);
            // 
            // DepositControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Name = "DepositControl";
            this.Size = new System.Drawing.Size(1124, 472);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox bankChecker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox moneyCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox depositChecker;
        private System.Windows.Forms.Button depositCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
    }
}
