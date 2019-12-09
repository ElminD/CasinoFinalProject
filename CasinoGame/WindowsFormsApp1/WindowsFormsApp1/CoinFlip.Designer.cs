namespace WindowsFormsApp1
{
    partial class CoinFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinFlip));
            this.button1 = new System.Windows.Forms.Button();
            this.headPictureBox = new System.Windows.Forms.PictureBox();
            this.tailPictureBox = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // headPictureBox
            // 
            this.headPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.headPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headPictureBox.Image")));
            this.headPictureBox.Location = new System.Drawing.Point(184, 70);
            this.headPictureBox.Name = "headPictureBox";
            this.headPictureBox.Size = new System.Drawing.Size(182, 168);
            this.headPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headPictureBox.TabIndex = 1;
            this.headPictureBox.TabStop = false;
            this.headPictureBox.Click += new System.EventHandler(this.headPictureBox_Click);
            // 
            // tailPictureBox
            // 
            this.tailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tailPictureBox.Image")));
            this.tailPictureBox.Location = new System.Drawing.Point(593, 82);
            this.tailPictureBox.Name = "tailPictureBox";
            this.tailPictureBox.Size = new System.Drawing.Size(182, 168);
            this.tailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tailPictureBox.TabIndex = 2;
            this.tailPictureBox.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(420, 122);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(90, 30);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Score:";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(414, 70);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 36);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "0 are Tails and 1 are Heads";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = " Enter one of those values:";
            // 
            // CoinFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.tailPictureBox);
            this.Controls.Add(this.headPictureBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoinFlip";
            this.Text = "CoinFlip";
            this.Load += new System.EventHandler(this.CoinFlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox headPictureBox;
        private System.Windows.Forms.PictureBox tailPictureBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}