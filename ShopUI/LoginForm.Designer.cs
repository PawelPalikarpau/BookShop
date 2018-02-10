namespace ShopUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginLabel = new System.Windows.Forms.Label();
            this.enterPasswordValue = new System.Windows.Forms.TextBox();
            this.enterPasswordLabel = new System.Windows.Forms.Label();
            this.emailAddressValue = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.registrateButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(235, 25);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(99, 45);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // enterPasswordValue
            // 
            this.enterPasswordValue.Location = new System.Drawing.Point(97, 201);
            this.enterPasswordValue.Name = "enterPasswordValue";
            this.enterPasswordValue.PasswordChar = '*';
            this.enterPasswordValue.Size = new System.Drawing.Size(396, 35);
            this.enterPasswordValue.TabIndex = 8;
            // 
            // enterPasswordLabel
            // 
            this.enterPasswordLabel.AutoSize = true;
            this.enterPasswordLabel.Location = new System.Drawing.Point(92, 168);
            this.enterPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterPasswordLabel.Name = "enterPasswordLabel";
            this.enterPasswordLabel.Size = new System.Drawing.Size(217, 30);
            this.enterPasswordLabel.TabIndex = 7;
            this.enterPasswordLabel.Text = "Enter Your Password*:";
            // 
            // emailAddressValue
            // 
            this.emailAddressValue.Location = new System.Drawing.Point(97, 130);
            this.emailAddressValue.Name = "emailAddressValue";
            this.emailAddressValue.Size = new System.Drawing.Size(396, 35);
            this.emailAddressValue.TabIndex = 6;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(92, 97);
            this.emailAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(260, 30);
            this.emailAddressLabel.TabIndex = 5;
            this.emailAddressLabel.Text = "Enter Your Email Address*:";
            // 
            // registrateButton
            // 
            this.registrateButton.Location = new System.Drawing.Point(332, 275);
            this.registrateButton.Name = "registrateButton";
            this.registrateButton.Size = new System.Drawing.Size(123, 47);
            this.registrateButton.TabIndex = 10;
            this.registrateButton.Text = "Registrate";
            this.registrateButton.UseVisualStyleBackColor = true;
            this.registrateButton.Click += new System.EventHandler(this.registrateButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(145, 275);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(123, 47);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 351);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registrateButton);
            this.Controls.Add(this.enterPasswordValue);
            this.Controls.Add(this.enterPasswordLabel);
            this.Controls.Add(this.emailAddressValue);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.loginLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox enterPasswordValue;
        private System.Windows.Forms.Label enterPasswordLabel;
        private System.Windows.Forms.TextBox emailAddressValue;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Button registrateButton;
        private System.Windows.Forms.Button loginButton;
    }
}