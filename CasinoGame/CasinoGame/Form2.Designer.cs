namespace CasinoGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.logoText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.username_Textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoText
            // 
            this.logoText.AutoSize = true;
            this.logoText.BackColor = System.Drawing.Color.Transparent;
            this.logoText.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoText.ForeColor = System.Drawing.Color.Gold;
            this.logoText.Location = new System.Drawing.Point(203, 83);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(384, 77);
            this.logoText.TabIndex = 1;
            this.logoText.Text = "Royal Casino";
            this.logoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.BackColor = System.Drawing.Color.Transparent;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.Gold;
            this.passwordText.Location = new System.Drawing.Point(333, 254);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(78, 20);
            this.passwordText.TabIndex = 9;
            this.passwordText.Text = "Password";
            this.toolTip1.SetToolTip(this.passwordText, resources.GetString("passwordText.ToolTip"));
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.BackColor = System.Drawing.Color.Transparent;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.Gold;
            this.usernameText.Location = new System.Drawing.Point(333, 190);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(83, 20);
            this.usernameText.TabIndex = 8;
            this.usernameText.Text = "Username";
            // 
            // password_Textbox
            // 
            this.password_Textbox.Location = new System.Drawing.Point(337, 277);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(123, 20);
            this.password_Textbox.TabIndex = 7;
            // 
            // username_Textbox
            // 
            this.username_Textbox.Location = new System.Drawing.Point(337, 213);
            this.username_Textbox.Name = "username_Textbox";
            this.username_Textbox.Size = new System.Drawing.Size(123, 20);
            this.username_Textbox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.username_Textbox);
            this.Controls.Add(this.logoText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.TextBox username_Textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}