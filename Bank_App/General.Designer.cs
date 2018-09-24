namespace Bank_App
{
    partial class General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.generalPanel = new System.Windows.Forms.Panel();
            this.elipsButton2 = new Bank_App.ElipsButton();
            this.label3 = new System.Windows.Forms.Label();
            this.elipsButton1 = new Bank_App.ElipsButton();
            this.menuBar = new System.Windows.Forms.Panel();
            this.pointerPanel = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.servicesButton = new System.Windows.Forms.Button();
            this.generalButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generalControl1 = new Bank_App.GeneralControl();
            this.userServices1 = new Bank_App.UserServices();
            this.logRegister1 = new Bank_App.LogRegister();
            this.depositControl1 = new Bank_App.DepositControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.generalPanel.SuspendLayout();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalPanel
            // 
            this.generalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.generalPanel.Controls.Add(this.elipsButton2);
            this.generalPanel.Controls.Add(this.label3);
            this.generalPanel.Controls.Add(this.elipsButton1);
            this.generalPanel.Location = new System.Drawing.Point(289, 1);
            this.generalPanel.Margin = new System.Windows.Forms.Padding(0);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(1143, 171);
            this.generalPanel.TabIndex = 0;
            this.generalPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseDown);
            this.generalPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseMove);
            this.generalPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.generalPanel_MouseUp);
            // 
            // elipsButton2
            // 
            this.elipsButton2.BackColor = System.Drawing.Color.White;
            this.elipsButton2.FlatAppearance.BorderSize = 0;
            this.elipsButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elipsButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elipsButton2.ForeColor = System.Drawing.Color.DimGray;
            this.elipsButton2.Image = ((System.Drawing.Image)(resources.GetObject("elipsButton2.Image")));
            this.elipsButton2.Location = new System.Drawing.Point(1014, 35);
            this.elipsButton2.Name = "elipsButton2";
            this.elipsButton2.Size = new System.Drawing.Size(103, 94);
            this.elipsButton2.TabIndex = 10;
            this.elipsButton2.Text = "Exit";
            this.elipsButton2.UseVisualStyleBackColor = false;
            this.elipsButton2.Click += new System.EventHandler(this.close_Click);
            this.elipsButton2.MouseEnter += new System.EventHandler(this.elipsButton1_MouseEnter);
            this.elipsButton2.MouseLeave += new System.EventHandler(this.elipsButton1_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 96);
            this.label3.TabIndex = 0;
            this.label3.Text = "Some Banek UI";
            // 
            // elipsButton1
            // 
            this.elipsButton1.BackColor = System.Drawing.Color.White;
            this.elipsButton1.FlatAppearance.BorderSize = 0;
            this.elipsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elipsButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elipsButton1.ForeColor = System.Drawing.Color.DimGray;
            this.elipsButton1.Image = ((System.Drawing.Image)(resources.GetObject("elipsButton1.Image")));
            this.elipsButton1.Location = new System.Drawing.Point(885, 35);
            this.elipsButton1.Name = "elipsButton1";
            this.elipsButton1.Size = new System.Drawing.Size(103, 94);
            this.elipsButton1.TabIndex = 9;
            this.elipsButton1.Text = "Login";
            this.elipsButton1.UseVisualStyleBackColor = false;
            this.elipsButton1.Click += new System.EventHandler(this.logButton_Click);
            this.elipsButton1.MouseEnter += new System.EventHandler(this.elipsButton1_MouseEnter);
            this.elipsButton1.MouseLeave += new System.EventHandler(this.elipsButton1_MouseLeave);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.menuBar.Controls.Add(this.pointerPanel);
            this.menuBar.Controls.Add(this.helpButton);
            this.menuBar.Controls.Add(this.depositButton);
            this.menuBar.Controls.Add(this.servicesButton);
            this.menuBar.Controls.Add(this.generalButton);
            this.menuBar.Location = new System.Drawing.Point(-5, 175);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(291, 541);
            this.menuBar.TabIndex = 3;
            // 
            // pointerPanel
            // 
            this.pointerPanel.BackColor = System.Drawing.Color.Gray;
            this.pointerPanel.Location = new System.Drawing.Point(275, 0);
            this.pointerPanel.Name = "pointerPanel";
            this.pointerPanel.Size = new System.Drawing.Size(16, 131);
            this.pointerPanel.TabIndex = 0;
            this.pointerPanel.Visible = false;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(14, 404);
            this.helpButton.Margin = new System.Windows.Forms.Padding(0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(268, 123);
            this.helpButton.TabIndex = 10;
            this.helpButton.Text = "Help    ";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.helpButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.depositButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositButton.FlatAppearance.BorderSize = 0;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.ForeColor = System.Drawing.Color.White;
            this.depositButton.Image = ((System.Drawing.Image)(resources.GetObject("depositButton.Image")));
            this.depositButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depositButton.Location = new System.Drawing.Point(14, 271);
            this.depositButton.Margin = new System.Windows.Forms.Padding(0);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(268, 123);
            this.depositButton.TabIndex = 9;
            this.depositButton.Text = "Deposits";
            this.depositButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            this.depositButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.depositButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // servicesButton
            // 
            this.servicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.servicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicesButton.FlatAppearance.BorderSize = 0;
            this.servicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesButton.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesButton.ForeColor = System.Drawing.Color.White;
            this.servicesButton.Image = ((System.Drawing.Image)(resources.GetObject("servicesButton.Image")));
            this.servicesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesButton.Location = new System.Drawing.Point(14, 138);
            this.servicesButton.Margin = new System.Windows.Forms.Padding(0);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(268, 123);
            this.servicesButton.TabIndex = 8;
            this.servicesButton.Text = "Services";
            this.servicesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.servicesButton.UseVisualStyleBackColor = false;
            this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
            this.servicesButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.servicesButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // generalButton
            // 
            this.generalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.generalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generalButton.FlatAppearance.BorderSize = 0;
            this.generalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalButton.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalButton.ForeColor = System.Drawing.Color.White;
            this.generalButton.Image = ((System.Drawing.Image)(resources.GetObject("generalButton.Image")));
            this.generalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generalButton.Location = new System.Drawing.Point(14, 3);
            this.generalButton.Margin = new System.Windows.Forms.Padding(0);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(268, 123);
            this.generalButton.TabIndex = 7;
            this.generalButton.Text = "General";
            this.generalButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generalButton.UseVisualStyleBackColor = false;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            this.generalButton.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.generalButton.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(283, 162);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(-3, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 168);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.generalControl1);
            this.panel1.Controls.Add(this.userServices1);
            this.panel1.Controls.Add(this.logRegister1);
            this.panel1.Controls.Add(this.depositControl1);
            this.panel1.Location = new System.Drawing.Point(292, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 480);
            this.panel1.TabIndex = 7;
            // 
            // generalControl1
            // 
            this.generalControl1.Location = new System.Drawing.Point(3, 3);
            this.generalControl1.Name = "generalControl1";
            this.generalControl1.Size = new System.Drawing.Size(1124, 472);
            this.generalControl1.TabIndex = 4;
            // 
            // userServices1
            // 
            this.userServices1.Location = new System.Drawing.Point(3, 8);
            this.userServices1.Name = "userServices1";
            this.userServices1.Size = new System.Drawing.Size(1124, 472);
            this.userServices1.TabIndex = 3;
            this.userServices1.Visible = false;
            // 
            // logRegister1
            // 
            this.logRegister1.Location = new System.Drawing.Point(13, 13);
            this.logRegister1.Name = "logRegister1";
            this.logRegister1.Size = new System.Drawing.Size(1124, 472);
            this.logRegister1.TabIndex = 2;
            // 
            // depositControl1
            // 
            this.depositControl1.BackColor = System.Drawing.Color.Silver;
            this.depositControl1.Location = new System.Drawing.Point(3, 0);
            this.depositControl1.Name = "depositControl1";
            this.depositControl1.Size = new System.Drawing.Size(1124, 472);
            this.depositControl1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Location = new System.Drawing.Point(295, 703);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 13);
            this.panel2.TabIndex = 8;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1431, 715);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.generalPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "General";
            this.Text = "BankAccaunt";
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.menuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button generalButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button servicesButton;
        private System.Windows.Forms.Panel pointerPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private ElipsButton elipsButton1;
        private System.Windows.Forms.Panel panel1;
        private LogRegister logRegister1;
        private DepositControl depositControl1;
        private UserServices userServices1;
        private ElipsButton elipsButton2;
        private GeneralControl generalControl1;
        private System.Windows.Forms.Panel panel2;
    }
}

