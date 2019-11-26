namespace CasinoGame
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
            this.logoText = new System.Windows.Forms.Label();
            this.login_Button = new System.Windows.Forms.Button();
            this.username_Textbox = new System.Windows.Forms.TextBox();
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.createAcc_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoText
            // 
            this.logoText.AutoSize = true;
            this.logoText.BackColor = System.Drawing.Color.Transparent;
            this.logoText.Font = new System.Drawing.Font("Script MT Bold", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoText.ForeColor = System.Drawing.Color.Gold;
            this.logoText.Location = new System.Drawing.Point(199, 124);
            this.logoText.Name = "logoText";
            this.logoText.Size = new System.Drawing.Size(384, 77);
            this.logoText.TabIndex = 0;
            this.logoText.Text = "Royal Casino";
            this.logoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(325, 353);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(123, 49);
            this.login_Button.TabIndex = 1;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            // 
            // username_Textbox
            // 
            this.username_Textbox.Location = new System.Drawing.Point(325, 247);
            this.username_Textbox.Name = "username_Textbox";
            this.username_Textbox.Size = new System.Drawing.Size(123, 20);
            this.username_Textbox.TabIndex = 2;
            // 
            // password_Textbox
            // 
            this.password_Textbox.Location = new System.Drawing.Point(325, 311);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(123, 20);
            this.password_Textbox.TabIndex = 3;
            this.password_Textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.BackColor = System.Drawing.Color.Transparent;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.Gold;
            this.usernameText.Location = new System.Drawing.Point(321, 224);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(83, 20);
            this.usernameText.TabIndex = 4;
            this.usernameText.Text = "Username";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.BackColor = System.Drawing.Color.Transparent;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.Gold;
            this.passwordText.Location = new System.Drawing.Point(321, 288);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(78, 20);
            this.passwordText.TabIndex = 5;
            this.passwordText.Text = "Password";
            // 
            // createAcc_Button
            // 
            this.createAcc_Button.Location = new System.Drawing.Point(336, 408);
            this.createAcc_Button.Name = "createAcc_Button";
            this.createAcc_Button.Size = new System.Drawing.Size(99, 23);
            this.createAcc_Button.TabIndex = 6;
            this.createAcc_Button.Text = "Create Account";
            this.createAcc_Button.UseVisualStyleBackColor = true;
            this.createAcc_Button.Click += new System.EventHandler(this.createAcc_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.createAcc_Button);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.username_Textbox);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.logoText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Royal Casino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoText;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.TextBox username_Textbox;
        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Button createAcc_Button;
    }
}

