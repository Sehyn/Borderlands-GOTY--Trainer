namespace BorderlandsGOTY_Money
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrentMoneyLbl = new System.Windows.Forms.Label();
            this.MoneyBoxTxt = new System.Windows.Forms.TextBox();
            this.Timery = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CopyrightLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ArmorCheckbox = new System.Windows.Forms.CheckBox();
            this.ArmorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMoneyLbl
            // 
            this.CurrentMoneyLbl.AutoSize = true;
            this.CurrentMoneyLbl.Location = new System.Drawing.Point(12, 53);
            this.CurrentMoneyLbl.Name = "CurrentMoneyLbl";
            this.CurrentMoneyLbl.Size = new System.Drawing.Size(82, 13);
            this.CurrentMoneyLbl.TabIndex = 1;
            this.CurrentMoneyLbl.Text = "Current Money :";
            // 
            // MoneyBoxTxt
            // 
            this.MoneyBoxTxt.Location = new System.Drawing.Point(15, 69);
            this.MoneyBoxTxt.Name = "MoneyBoxTxt";
            this.MoneyBoxTxt.Size = new System.Drawing.Size(251, 20);
            this.MoneyBoxTxt.TabIndex = 3;
            // 
            // Timery
            // 
            this.Timery.Enabled = true;
            this.Timery.Interval = 1000;
            this.Timery.Tick += new System.EventHandler(this.Timery_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CopyrightLbl
            // 
            this.CopyrightLbl.AutoSize = true;
            this.CopyrightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.CopyrightLbl.Location = new System.Drawing.Point(13, 185);
            this.CopyrightLbl.Name = "CopyrightLbl";
            this.CopyrightLbl.Size = new System.Drawing.Size(100, 12);
            this.CopyrightLbl.TabIndex = 5;
            this.CopyrightLbl.Text = "123lkj12lk312kjl3 @UC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set Money!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ArmorCheckbox
            // 
            this.ArmorCheckbox.AutoSize = true;
            this.ArmorCheckbox.Location = new System.Drawing.Point(15, 135);
            this.ArmorCheckbox.Name = "ArmorCheckbox";
            this.ArmorCheckbox.Size = new System.Drawing.Size(169, 17);
            this.ArmorCheckbox.TabIndex = 7;
            this.ArmorCheckbox.Text = "Unlimited Shield/Armor (Noise)";
            this.ArmorCheckbox.UseVisualStyleBackColor = true;
            this.ArmorCheckbox.Click += new System.EventHandler(this.ArmorCheckbox_Click);
            // 
            // ArmorTimer
            // 
            this.ArmorTimer.Interval = 500;
            this.ArmorTimer.Tick += new System.EventHandler(this.ArmorTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 260);
            this.Controls.Add(this.ArmorCheckbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CopyrightLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MoneyBoxTxt);
            this.Controls.Add(this.CurrentMoneyLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Borderlands GOTY - PC - Money Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CurrentMoneyLbl;
        private System.Windows.Forms.TextBox MoneyBoxTxt;
        private System.Windows.Forms.Timer Timery;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CopyrightLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ArmorCheckbox;
        private System.Windows.Forms.Timer ArmorTimer;
    }
}

