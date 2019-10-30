namespace CRM
{
    partial class loginForm
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
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(80, 211);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(180, 20);
            this.passwordTextbox.TabIndex = 0;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(80, 134);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(180, 20);
            this.usernameTextbox.TabIndex = 1;
            // 
            // loginTitleLabel
            // 
            this.loginTitleLabel.AutoSize = true;
            this.loginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitleLabel.Location = new System.Drawing.Point(142, 46);
            this.loginTitleLabel.Name = "loginTitleLabel";
            this.loginTitleLabel.Size = new System.Drawing.Size(68, 24);
            this.loginTitleLabel.TabIndex = 2;
            this.loginTitleLabel.Text = "Log In";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(143, 118);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(55, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(143, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(135, 272);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 393);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.loginTitleLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Name = "loginForm";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label loginTitleLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
    }
}