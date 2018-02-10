namespace ShopUI
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.registrationLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.enterPasswordValue = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailAddressValue = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberValue = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.repeatPasswordValue = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.uploadedPictureBox = new System.Windows.Forms.PictureBox();
            this.uploadPicturePathLabel = new System.Windows.Forms.Label();
            this.uploadedPictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uploadedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.Location = new System.Drawing.Point(372, 16);
            this.registrationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(191, 45);
            this.registrationLabel.TabIndex = 0;
            this.registrationLabel.Text = "Registration";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(62, 70);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(127, 30);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name*:";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(67, 103);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(396, 35);
            this.firstNameValue.TabIndex = 2;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(67, 174);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(396, 35);
            this.lastNameValue.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(62, 141);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(126, 30);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name*:";
            // 
            // enterPasswordValue
            // 
            this.enterPasswordValue.Location = new System.Drawing.Point(67, 279);
            this.enterPasswordValue.Name = "enterPasswordValue";
            this.enterPasswordValue.PasswordChar = '*';
            this.enterPasswordValue.Size = new System.Drawing.Size(396, 35);
            this.enterPasswordValue.TabIndex = 6;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(62, 246);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(168, 30);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Enter Password*:";
            // 
            // emailAddressValue
            // 
            this.emailAddressValue.Location = new System.Drawing.Point(67, 449);
            this.emailAddressValue.Name = "emailAddressValue";
            this.emailAddressValue.Size = new System.Drawing.Size(396, 35);
            this.emailAddressValue.TabIndex = 8;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(62, 416);
            this.emailAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(157, 30);
            this.emailAddressLabel.TabIndex = 7;
            this.emailAddressLabel.Text = "Email Address*:";
            // 
            // phoneNumberValue
            // 
            this.phoneNumberValue.Location = new System.Drawing.Point(67, 520);
            this.phoneNumberValue.Name = "phoneNumberValue";
            this.phoneNumberValue.Size = new System.Drawing.Size(396, 35);
            this.phoneNumberValue.TabIndex = 10;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(62, 487);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(168, 30);
            this.phoneNumberLabel.TabIndex = 9;
            this.phoneNumberLabel.Text = "Phone Number*:";
            // 
            // repeatPasswordValue
            // 
            this.repeatPasswordValue.Location = new System.Drawing.Point(67, 347);
            this.repeatPasswordValue.Name = "repeatPasswordValue";
            this.repeatPasswordValue.PasswordChar = '*';
            this.repeatPasswordValue.Size = new System.Drawing.Size(396, 35);
            this.repeatPasswordValue.TabIndex = 12;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(62, 314);
            this.repeatPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(185, 30);
            this.repeatPasswordLabel.TabIndex = 11;
            this.repeatPasswordLabel.Text = "Repeat Password*:";
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(366, 578);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(202, 49);
            this.registrationButton.TabIndex = 13;
            this.registrationButton.Text = "Register";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // uploadedPictureBox
            // 
            this.uploadedPictureBox.Location = new System.Drawing.Point(516, 155);
            this.uploadedPictureBox.Name = "uploadedPictureBox";
            this.uploadedPictureBox.Size = new System.Drawing.Size(350, 400);
            this.uploadedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uploadedPictureBox.TabIndex = 14;
            this.uploadedPictureBox.TabStop = false;
            // 
            // uploadPicturePathLabel
            // 
            this.uploadPicturePathLabel.AutoSize = true;
            this.uploadPicturePathLabel.Location = new System.Drawing.Point(511, 122);
            this.uploadPicturePathLabel.Name = "uploadPicturePathLabel";
            this.uploadPicturePathLabel.Size = new System.Drawing.Size(0, 30);
            this.uploadPicturePathLabel.TabIndex = 16;
            // 
            // uploadedPictureButton
            // 
            this.uploadedPictureButton.Location = new System.Drawing.Point(602, 70);
            this.uploadedPictureButton.Name = "uploadedPictureButton";
            this.uploadedPictureButton.Size = new System.Drawing.Size(174, 41);
            this.uploadedPictureButton.TabIndex = 17;
            this.uploadedPictureButton.Text = "Upload Picture";
            this.uploadedPictureButton.UseVisualStyleBackColor = true;
            this.uploadedPictureButton.Click += new System.EventHandler(this.uploadedPictureButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 641);
            this.Controls.Add(this.uploadedPictureButton);
            this.Controls.Add(this.uploadPicturePathLabel);
            this.Controls.Add(this.uploadedPictureBox);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.repeatPasswordValue);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.phoneNumberValue);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailAddressValue);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.enterPasswordValue);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lastNameValue);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameValue);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.registrationLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.uploadedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox enterPasswordValue;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailAddressValue;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.TextBox phoneNumberValue;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox repeatPasswordValue;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.PictureBox uploadedPictureBox;
        private System.Windows.Forms.Button uploadPictureButton;
        private System.Windows.Forms.Label uploadPicturePathLabel;
        private System.Windows.Forms.Button uploadedPictureButton;
    }
}

