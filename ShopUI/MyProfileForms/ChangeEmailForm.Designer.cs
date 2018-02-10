namespace ShopUI.ProfileForms
{
    partial class ChangeEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeEmailForm));
            this.changeEmailLabel = new System.Windows.Forms.Label();
            this.changeEmailButton = new System.Windows.Forms.Button();
            this.enterPasswordrValue = new System.Windows.Forms.TextBox();
            this.enterPasswordLabel = new System.Windows.Forms.Label();
            this.enterEmailValue = new System.Windows.Forms.TextBox();
            this.newEmailLabel = new System.Windows.Forms.Label();
            this.repeatPasswordValue = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeEmailLabel
            // 
            this.changeEmailLabel.AutoSize = true;
            this.changeEmailLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeEmailLabel.Location = new System.Drawing.Point(140, 9);
            this.changeEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changeEmailLabel.Name = "changeEmailLabel";
            this.changeEmailLabel.Size = new System.Drawing.Size(288, 45);
            this.changeEmailLabel.TabIndex = 2;
            this.changeEmailLabel.Text = "Change Your Email";
            // 
            // changeEmailButton
            // 
            this.changeEmailButton.Location = new System.Drawing.Point(179, 245);
            this.changeEmailButton.Name = "changeEmailButton";
            this.changeEmailButton.Size = new System.Drawing.Size(208, 54);
            this.changeEmailButton.TabIndex = 12;
            this.changeEmailButton.Text = "Change Email";
            this.changeEmailButton.UseVisualStyleBackColor = true;
            this.changeEmailButton.Click += new System.EventHandler(this.changeEmailButton_Click);
            // 
            // enterPasswordrValue
            // 
            this.enterPasswordrValue.Location = new System.Drawing.Point(252, 139);
            this.enterPasswordrValue.Margin = new System.Windows.Forms.Padding(2);
            this.enterPasswordrValue.Name = "enterPasswordrValue";
            this.enterPasswordrValue.PasswordChar = '*';
            this.enterPasswordrValue.Size = new System.Drawing.Size(299, 35);
            this.enterPasswordrValue.TabIndex = 11;
            // 
            // enterPasswordLabel
            // 
            this.enterPasswordLabel.AutoSize = true;
            this.enterPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPasswordLabel.Location = new System.Drawing.Point(18, 142);
            this.enterPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterPasswordLabel.Name = "enterPasswordLabel";
            this.enterPasswordLabel.Size = new System.Drawing.Size(217, 30);
            this.enterPasswordLabel.TabIndex = 10;
            this.enterPasswordLabel.Text = "Enter Your Password*:";
            // 
            // enterEmailValue
            // 
            this.enterEmailValue.Location = new System.Drawing.Point(252, 76);
            this.enterEmailValue.Margin = new System.Windows.Forms.Padding(2);
            this.enterEmailValue.Name = "enterEmailValue";
            this.enterEmailValue.Size = new System.Drawing.Size(299, 35);
            this.enterEmailValue.TabIndex = 9;
            // 
            // newEmailLabel
            // 
            this.newEmailLabel.AutoSize = true;
            this.newEmailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmailLabel.Location = new System.Drawing.Point(18, 79);
            this.newEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newEmailLabel.Name = "newEmailLabel";
            this.newEmailLabel.Size = new System.Drawing.Size(175, 30);
            this.newEmailLabel.TabIndex = 8;
            this.newEmailLabel.Text = "Enter new Email*:";
            // 
            // repeatPasswordValue
            // 
            this.repeatPasswordValue.Location = new System.Drawing.Point(252, 178);
            this.repeatPasswordValue.Margin = new System.Windows.Forms.Padding(2);
            this.repeatPasswordValue.Name = "repeatPasswordValue";
            this.repeatPasswordValue.PasswordChar = '*';
            this.repeatPasswordValue.Size = new System.Drawing.Size(299, 35);
            this.repeatPasswordValue.TabIndex = 14;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordLabel.Location = new System.Drawing.Point(18, 181);
            this.repeatPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(234, 30);
            this.repeatPasswordLabel.TabIndex = 13;
            this.repeatPasswordLabel.Text = "Repeat Your Password*:";
            // 
            // ChangeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 321);
            this.Controls.Add(this.repeatPasswordValue);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.changeEmailButton);
            this.Controls.Add(this.enterPasswordrValue);
            this.Controls.Add(this.enterPasswordLabel);
            this.Controls.Add(this.enterEmailValue);
            this.Controls.Add(this.newEmailLabel);
            this.Controls.Add(this.changeEmailLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ChangeEmailForm";
            this.Text = "Change Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changeEmailLabel;
        private System.Windows.Forms.Button changeEmailButton;
        private System.Windows.Forms.TextBox enterPasswordrValue;
        private System.Windows.Forms.Label enterPasswordLabel;
        private System.Windows.Forms.TextBox enterEmailValue;
        private System.Windows.Forms.Label newEmailLabel;
        private System.Windows.Forms.TextBox repeatPasswordValue;
        private System.Windows.Forms.Label repeatPasswordLabel;
    }
}