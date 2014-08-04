namespace GrandExchangeLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ChangeTodayLabel = new System.Windows.Forms.Label();
            this.Day30TrendLabel = new System.Windows.Forms.Label();
            this.Day90TrendLabel = new System.Windows.Forms.Label();
            this.Day180TrendLabel = new System.Windows.Forms.Label();
            this.MembersIcon = new System.Windows.Forms.PictureBox();
            this.MembersTextLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MembersIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item id:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.ForeColor = System.Drawing.Color.Yellow;
            this.PriceLabel.Location = new System.Drawing.Point(10, 259);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(70, 13);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Current price:";
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.NameLabel.Location = new System.Drawing.Point(0, 80);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(434, 24);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Item name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeTodayLabel
            // 
            this.ChangeTodayLabel.AutoSize = true;
            this.ChangeTodayLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChangeTodayLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ChangeTodayLabel.Location = new System.Drawing.Point(10, 279);
            this.ChangeTodayLabel.Name = "ChangeTodayLabel";
            this.ChangeTodayLabel.Size = new System.Drawing.Size(76, 13);
            this.ChangeTodayLabel.TabIndex = 8;
            this.ChangeTodayLabel.Text = "Change today:";
            // 
            // Day30TrendLabel
            // 
            this.Day30TrendLabel.AutoSize = true;
            this.Day30TrendLabel.BackColor = System.Drawing.Color.Transparent;
            this.Day30TrendLabel.ForeColor = System.Drawing.Color.Yellow;
            this.Day30TrendLabel.Location = new System.Drawing.Point(10, 299);
            this.Day30TrendLabel.Name = "Day30TrendLabel";
            this.Day30TrendLabel.Size = new System.Drawing.Size(87, 13);
            this.Day30TrendLabel.TabIndex = 9;
            this.Day30TrendLabel.Text = "1 month change:";
            // 
            // Day90TrendLabel
            // 
            this.Day90TrendLabel.AutoSize = true;
            this.Day90TrendLabel.BackColor = System.Drawing.Color.Transparent;
            this.Day90TrendLabel.ForeColor = System.Drawing.Color.Yellow;
            this.Day90TrendLabel.Location = new System.Drawing.Point(10, 319);
            this.Day90TrendLabel.Name = "Day90TrendLabel";
            this.Day90TrendLabel.Size = new System.Drawing.Size(87, 13);
            this.Day90TrendLabel.TabIndex = 10;
            this.Day90TrendLabel.Text = "3 month change:";
            // 
            // Day180TrendLabel
            // 
            this.Day180TrendLabel.AutoSize = true;
            this.Day180TrendLabel.BackColor = System.Drawing.Color.Transparent;
            this.Day180TrendLabel.ForeColor = System.Drawing.Color.Yellow;
            this.Day180TrendLabel.Location = new System.Drawing.Point(10, 339);
            this.Day180TrendLabel.Name = "Day180TrendLabel";
            this.Day180TrendLabel.Size = new System.Drawing.Size(87, 13);
            this.Day180TrendLabel.TabIndex = 11;
            this.Day180TrendLabel.Text = "6 month change:";
            // 
            // MembersIcon
            // 
            this.MembersIcon.BackColor = System.Drawing.Color.Transparent;
            this.MembersIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MembersIcon.BackgroundImage")));
            this.MembersIcon.Location = new System.Drawing.Point(7, 368);
            this.MembersIcon.Name = "MembersIcon";
            this.MembersIcon.Size = new System.Drawing.Size(35, 36);
            this.MembersIcon.TabIndex = 12;
            this.MembersIcon.TabStop = false;
            this.MembersIcon.Visible = false;
            // 
            // MembersTextLabel
            // 
            this.MembersTextLabel.AutoSize = true;
            this.MembersTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.MembersTextLabel.ForeColor = System.Drawing.Color.Gold;
            this.MembersTextLabel.Location = new System.Drawing.Point(49, 378);
            this.MembersTextLabel.Name = "MembersTextLabel";
            this.MembersTextLabel.Size = new System.Drawing.Size(138, 13);
            this.MembersTextLabel.TabIndex = 13;
            this.MembersTextLabel.Text = "This item is a members item.";
            this.MembersTextLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.MembersTextLabel);
            this.Controls.Add(this.MembersIcon);
            this.Controls.Add(this.Day180TrendLabel);
            this.Controls.Add(this.Day90TrendLabel);
            this.Controls.Add(this.Day30TrendLabel);
            this.Controls.Add(this.ChangeTodayLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Grand Exchange Lookup";
            ((System.ComponentModel.ISupportInitialize)(this.MembersIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ChangeTodayLabel;
        private System.Windows.Forms.Label Day30TrendLabel;
        private System.Windows.Forms.Label Day90TrendLabel;
        private System.Windows.Forms.Label Day180TrendLabel;
        private System.Windows.Forms.PictureBox MembersIcon;
        private System.Windows.Forms.Label MembersTextLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

