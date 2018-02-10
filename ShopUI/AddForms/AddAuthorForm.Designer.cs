namespace ShopUI.AddForms
{
    partial class AddAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthorForm));
            this.addNewAuthorLabel = new System.Windows.Forms.Label();
            this.authorsFirstNameLabel = new System.Windows.Forms.Label();
            this.authorsFirstNameValue = new System.Windows.Forms.TextBox();
            this.authorsLastNameValue = new System.Windows.Forms.TextBox();
            this.authorsLastNameLabel = new System.Windows.Forms.Label();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.photosPathLabel = new System.Windows.Forms.Label();
            this.authorsPhotoBox = new System.Windows.Forms.PictureBox();
            this.addAuthorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorsPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewAuthorLabel
            // 
            this.addNewAuthorLabel.AutoSize = true;
            this.addNewAuthorLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewAuthorLabel.Location = new System.Drawing.Point(155, 9);
            this.addNewAuthorLabel.Name = "addNewAuthorLabel";
            this.addNewAuthorLabel.Size = new System.Drawing.Size(259, 45);
            this.addNewAuthorLabel.TabIndex = 0;
            this.addNewAuthorLabel.Text = "Add New Author";
            // 
            // authorsFirstNameLabel
            // 
            this.authorsFirstNameLabel.AutoSize = true;
            this.authorsFirstNameLabel.Location = new System.Drawing.Point(37, 76);
            this.authorsFirstNameLabel.Name = "authorsFirstNameLabel";
            this.authorsFirstNameLabel.Size = new System.Drawing.Size(197, 30);
            this.authorsFirstNameLabel.TabIndex = 1;
            this.authorsFirstNameLabel.Text = "Authors First Name:";
            // 
            // authorsFirstNameValue
            // 
            this.authorsFirstNameValue.Location = new System.Drawing.Point(240, 73);
            this.authorsFirstNameValue.Name = "authorsFirstNameValue";
            this.authorsFirstNameValue.Size = new System.Drawing.Size(292, 35);
            this.authorsFirstNameValue.TabIndex = 2;
            // 
            // authorsLastNameValue
            // 
            this.authorsLastNameValue.Location = new System.Drawing.Point(240, 114);
            this.authorsLastNameValue.Name = "authorsLastNameValue";
            this.authorsLastNameValue.Size = new System.Drawing.Size(292, 35);
            this.authorsLastNameValue.TabIndex = 4;
            // 
            // authorsLastNameLabel
            // 
            this.authorsLastNameLabel.AutoSize = true;
            this.authorsLastNameLabel.Location = new System.Drawing.Point(37, 117);
            this.authorsLastNameLabel.Name = "authorsLastNameLabel";
            this.authorsLastNameLabel.Size = new System.Drawing.Size(196, 30);
            this.authorsLastNameLabel.TabIndex = 3;
            this.authorsLastNameLabel.Text = "Authors Last Name:";
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.Location = new System.Drawing.Point(201, 155);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(166, 47);
            this.addPhotoButton.TabIndex = 5;
            this.addPhotoButton.Text = "Add Photo";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // photosPathLabel
            // 
            this.photosPathLabel.AutoSize = true;
            this.photosPathLabel.Location = new System.Drawing.Point(37, 203);
            this.photosPathLabel.Name = "photosPathLabel";
            this.photosPathLabel.Size = new System.Drawing.Size(0, 30);
            this.photosPathLabel.TabIndex = 6;
            // 
            // authorsPhotoBox
            // 
            this.authorsPhotoBox.Location = new System.Drawing.Point(158, 250);
            this.authorsPhotoBox.Name = "authorsPhotoBox";
            this.authorsPhotoBox.Size = new System.Drawing.Size(252, 311);
            this.authorsPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.authorsPhotoBox.TabIndex = 7;
            this.authorsPhotoBox.TabStop = false;
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(201, 567);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(166, 59);
            this.addAuthorButton.TabIndex = 8;
            this.addAuthorButton.Text = "Add Author";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 638);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.authorsPhotoBox);
            this.Controls.Add(this.photosPathLabel);
            this.Controls.Add(this.addPhotoButton);
            this.Controls.Add(this.authorsLastNameValue);
            this.Controls.Add(this.authorsLastNameLabel);
            this.Controls.Add(this.authorsFirstNameValue);
            this.Controls.Add(this.authorsFirstNameLabel);
            this.Controls.Add(this.addNewAuthorLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddAuthorForm";
            this.Text = "Add Author";
            ((System.ComponentModel.ISupportInitialize)(this.authorsPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewAuthorLabel;
        private System.Windows.Forms.Label authorsFirstNameLabel;
        private System.Windows.Forms.TextBox authorsFirstNameValue;
        private System.Windows.Forms.TextBox authorsLastNameValue;
        private System.Windows.Forms.Label authorsLastNameLabel;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.Label photosPathLabel;
        private System.Windows.Forms.PictureBox authorsPhotoBox;
        private System.Windows.Forms.Button addAuthorButton;
    }
}