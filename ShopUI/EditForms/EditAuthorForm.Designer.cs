namespace ShopUI.EditForms
{
    partial class EditAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAuthorForm));
            this.editAuthorButton = new System.Windows.Forms.Button();
            this.authorsPhotoBox = new System.Windows.Forms.PictureBox();
            this.editPhotoButton = new System.Windows.Forms.Button();
            this.editAuthorsLastNameValue = new System.Windows.Forms.TextBox();
            this.editAuthorsLastNameLabel = new System.Windows.Forms.Label();
            this.editAuthorsFirstNameValue = new System.Windows.Forms.TextBox();
            this.editAuthorsFirstNameLabel = new System.Windows.Forms.Label();
            this.editAuthorLabel = new System.Windows.Forms.Label();
            this.chooseAuthorLabel = new System.Windows.Forms.Label();
            this.chooseAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.photoPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.authorsPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // editAuthorButton
            // 
            this.editAuthorButton.Location = new System.Drawing.Point(201, 595);
            this.editAuthorButton.Name = "editAuthorButton";
            this.editAuthorButton.Size = new System.Drawing.Size(166, 59);
            this.editAuthorButton.TabIndex = 16;
            this.editAuthorButton.Text = "Edit Author";
            this.editAuthorButton.UseVisualStyleBackColor = true;
            this.editAuthorButton.Click += new System.EventHandler(this.editAuthorButton_Click);
            // 
            // authorsPhotoBox
            // 
            this.authorsPhotoBox.Location = new System.Drawing.Point(158, 278);
            this.authorsPhotoBox.Name = "authorsPhotoBox";
            this.authorsPhotoBox.Size = new System.Drawing.Size(252, 311);
            this.authorsPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.authorsPhotoBox.TabIndex = 15;
            this.authorsPhotoBox.TabStop = false;
            // 
            // editPhotoButton
            // 
            this.editPhotoButton.Location = new System.Drawing.Point(201, 183);
            this.editPhotoButton.Name = "editPhotoButton";
            this.editPhotoButton.Size = new System.Drawing.Size(166, 47);
            this.editPhotoButton.TabIndex = 14;
            this.editPhotoButton.Text = "Edit Photo";
            this.editPhotoButton.UseVisualStyleBackColor = true;
            this.editPhotoButton.Click += new System.EventHandler(this.editPhotoButton_Click);
            // 
            // editAuthorsLastNameValue
            // 
            this.editAuthorsLastNameValue.Location = new System.Drawing.Point(240, 142);
            this.editAuthorsLastNameValue.Name = "editAuthorsLastNameValue";
            this.editAuthorsLastNameValue.Size = new System.Drawing.Size(292, 35);
            this.editAuthorsLastNameValue.TabIndex = 13;
            // 
            // editAuthorsLastNameLabel
            // 
            this.editAuthorsLastNameLabel.AutoSize = true;
            this.editAuthorsLastNameLabel.Location = new System.Drawing.Point(37, 145);
            this.editAuthorsLastNameLabel.Name = "editAuthorsLastNameLabel";
            this.editAuthorsLastNameLabel.Size = new System.Drawing.Size(158, 30);
            this.editAuthorsLastNameLabel.TabIndex = 12;
            this.editAuthorsLastNameLabel.Text = "Edit Last Name:";
            // 
            // editAuthorsFirstNameValue
            // 
            this.editAuthorsFirstNameValue.Location = new System.Drawing.Point(240, 101);
            this.editAuthorsFirstNameValue.Name = "editAuthorsFirstNameValue";
            this.editAuthorsFirstNameValue.Size = new System.Drawing.Size(292, 35);
            this.editAuthorsFirstNameValue.TabIndex = 11;
            // 
            // editAuthorsFirstNameLabel
            // 
            this.editAuthorsFirstNameLabel.AutoSize = true;
            this.editAuthorsFirstNameLabel.Location = new System.Drawing.Point(37, 104);
            this.editAuthorsFirstNameLabel.Name = "editAuthorsFirstNameLabel";
            this.editAuthorsFirstNameLabel.Size = new System.Drawing.Size(159, 30);
            this.editAuthorsFirstNameLabel.TabIndex = 10;
            this.editAuthorsFirstNameLabel.Text = "Edit First Name:";
            // 
            // editAuthorLabel
            // 
            this.editAuthorLabel.AutoSize = true;
            this.editAuthorLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAuthorLabel.Location = new System.Drawing.Point(194, 9);
            this.editAuthorLabel.Name = "editAuthorLabel";
            this.editAuthorLabel.Size = new System.Drawing.Size(181, 45);
            this.editAuthorLabel.TabIndex = 9;
            this.editAuthorLabel.Text = "Edit Author";
            // 
            // chooseAuthorLabel
            // 
            this.chooseAuthorLabel.AutoSize = true;
            this.chooseAuthorLabel.Location = new System.Drawing.Point(37, 60);
            this.chooseAuthorLabel.Name = "chooseAuthorLabel";
            this.chooseAuthorLabel.Size = new System.Drawing.Size(197, 30);
            this.chooseAuthorLabel.TabIndex = 17;
            this.chooseAuthorLabel.Text = "Choose The Author:";
            // 
            // chooseAuthorComboBox
            // 
            this.chooseAuthorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.chooseAuthorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.chooseAuthorComboBox.FormattingEnabled = true;
            this.chooseAuthorComboBox.Location = new System.Drawing.Point(240, 57);
            this.chooseAuthorComboBox.Name = "chooseAuthorComboBox";
            this.chooseAuthorComboBox.Size = new System.Drawing.Size(292, 38);
            this.chooseAuthorComboBox.Sorted = true;
            this.chooseAuthorComboBox.TabIndex = 18;
            this.chooseAuthorComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseAuthorComboBox_SelectedIndexChanged);
            // 
            // photoPathLabel
            // 
            this.photoPathLabel.AutoSize = true;
            this.photoPathLabel.Location = new System.Drawing.Point(38, 245);
            this.photoPathLabel.Name = "photoPathLabel";
            this.photoPathLabel.Size = new System.Drawing.Size(0, 30);
            this.photoPathLabel.TabIndex = 19;
            // 
            // EditAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 658);
            this.Controls.Add(this.photoPathLabel);
            this.Controls.Add(this.chooseAuthorComboBox);
            this.Controls.Add(this.chooseAuthorLabel);
            this.Controls.Add(this.editAuthorButton);
            this.Controls.Add(this.authorsPhotoBox);
            this.Controls.Add(this.editPhotoButton);
            this.Controls.Add(this.editAuthorsLastNameValue);
            this.Controls.Add(this.editAuthorsLastNameLabel);
            this.Controls.Add(this.editAuthorsFirstNameValue);
            this.Controls.Add(this.editAuthorsFirstNameLabel);
            this.Controls.Add(this.editAuthorLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditAuthorForm";
            this.Text = "Edit Author";
            ((System.ComponentModel.ISupportInitialize)(this.authorsPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editAuthorButton;
        private System.Windows.Forms.PictureBox authorsPhotoBox;
        private System.Windows.Forms.Button editPhotoButton;
        private System.Windows.Forms.TextBox editAuthorsLastNameValue;
        private System.Windows.Forms.Label editAuthorsLastNameLabel;
        private System.Windows.Forms.TextBox editAuthorsFirstNameValue;
        private System.Windows.Forms.Label editAuthorsFirstNameLabel;
        private System.Windows.Forms.Label editAuthorLabel;
        private System.Windows.Forms.Label chooseAuthorLabel;
        private System.Windows.Forms.ComboBox chooseAuthorComboBox;
        private System.Windows.Forms.Label photoPathLabel;
    }
}