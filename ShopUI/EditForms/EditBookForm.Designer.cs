namespace ShopUI.EditForms
{
    partial class EditBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBookForm));
            this.editAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.editCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.editAuthorLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.editPictureButton = new System.Windows.Forms.Button();
            this.editPriceBookValue = new System.Windows.Forms.TextBox();
            this.editPriceLabel = new System.Windows.Forms.Label();
            this.editBookButton = new System.Windows.Forms.Button();
            this.editShortDescriptionValue = new System.Windows.Forms.TextBox();
            this.editShortDescriptionLabel = new System.Windows.Forms.Label();
            this.editNumberOfPagesValue = new System.Windows.Forms.TextBox();
            this.editNumberOfPagesLabel = new System.Windows.Forms.Label();
            this.editBookTitleValue = new System.Windows.Forms.TextBox();
            this.editBookTitleLabel = new System.Windows.Forms.Label();
            this.editBookLabel = new System.Windows.Forms.Label();
            this.editCategoryLabel = new System.Windows.Forms.Label();
            this.picturePathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseBookComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // editAuthorComboBox
            // 
            this.editAuthorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.editAuthorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.editAuthorComboBox.FormattingEnabled = true;
            this.editAuthorComboBox.Items.AddRange(new object[] {
            ""});
            this.editAuthorComboBox.Location = new System.Drawing.Point(299, 284);
            this.editAuthorComboBox.Name = "editAuthorComboBox";
            this.editAuthorComboBox.Size = new System.Drawing.Size(247, 38);
            this.editAuthorComboBox.Sorted = true;
            this.editAuthorComboBox.TabIndex = 36;
            // 
            // editCategoryComboBox
            // 
            this.editCategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.editCategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.editCategoryComboBox.FormattingEnabled = true;
            this.editCategoryComboBox.Location = new System.Drawing.Point(38, 284);
            this.editCategoryComboBox.Name = "editCategoryComboBox";
            this.editCategoryComboBox.Size = new System.Drawing.Size(247, 38);
            this.editCategoryComboBox.Sorted = true;
            this.editCategoryComboBox.TabIndex = 35;
            // 
            // editAuthorLabel
            // 
            this.editAuthorLabel.AutoSize = true;
            this.editAuthorLabel.Location = new System.Drawing.Point(294, 251);
            this.editAuthorLabel.Name = "editAuthorLabel";
            this.editAuthorLabel.Size = new System.Drawing.Size(123, 30);
            this.editAuthorLabel.TabIndex = 34;
            this.editAuthorLabel.Text = "Edit Author:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(-127, 209);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(101, 30);
            this.categoryLabel.TabIndex = 33;
            this.categoryLabel.Text = "Category:";
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.Location = new System.Drawing.Point(603, 192);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(262, 350);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uploadPictureBox.TabIndex = 32;
            this.uploadPictureBox.TabStop = false;
            // 
            // editPictureButton
            // 
            this.editPictureButton.Location = new System.Drawing.Point(651, 111);
            this.editPictureButton.Name = "editPictureButton";
            this.editPictureButton.Size = new System.Drawing.Size(165, 45);
            this.editPictureButton.TabIndex = 30;
            this.editPictureButton.Text = "Edit Picture";
            this.editPictureButton.UseVisualStyleBackColor = true;
            this.editPictureButton.Click += new System.EventHandler(this.editPictureButton_Click);
            // 
            // editPriceBookValue
            // 
            this.editPriceBookValue.Location = new System.Drawing.Point(239, 203);
            this.editPriceBookValue.Name = "editPriceBookValue";
            this.editPriceBookValue.Size = new System.Drawing.Size(307, 35);
            this.editPriceBookValue.TabIndex = 29;
            // 
            // editPriceLabel
            // 
            this.editPriceLabel.AutoSize = true;
            this.editPriceLabel.Location = new System.Drawing.Point(23, 208);
            this.editPriceLabel.Name = "editPriceLabel";
            this.editPriceLabel.Size = new System.Drawing.Size(156, 30);
            this.editPriceLabel.TabIndex = 28;
            this.editPriceLabel.Text = "Edit Book Price:";
            // 
            // editBookButton
            // 
            this.editBookButton.Location = new System.Drawing.Point(334, 571);
            this.editBookButton.Name = "editBookButton";
            this.editBookButton.Size = new System.Drawing.Size(221, 60);
            this.editBookButton.TabIndex = 27;
            this.editBookButton.Text = "Edit Book";
            this.editBookButton.UseVisualStyleBackColor = true;
            this.editBookButton.Click += new System.EventHandler(this.editBookButton_Click);
            // 
            // editShortDescriptionValue
            // 
            this.editShortDescriptionValue.Location = new System.Drawing.Point(28, 374);
            this.editShortDescriptionValue.Multiline = true;
            this.editShortDescriptionValue.Name = "editShortDescriptionValue";
            this.editShortDescriptionValue.Size = new System.Drawing.Size(518, 168);
            this.editShortDescriptionValue.TabIndex = 26;
            // 
            // editShortDescriptionLabel
            // 
            this.editShortDescriptionLabel.AutoSize = true;
            this.editShortDescriptionLabel.Location = new System.Drawing.Point(195, 335);
            this.editShortDescriptionLabel.Name = "editShortDescriptionLabel";
            this.editShortDescriptionLabel.Size = new System.Drawing.Size(178, 30);
            this.editShortDescriptionLabel.TabIndex = 25;
            this.editShortDescriptionLabel.Text = "Short Description:";
            // 
            // editNumberOfPagesValue
            // 
            this.editNumberOfPagesValue.Location = new System.Drawing.Point(239, 162);
            this.editNumberOfPagesValue.Name = "editNumberOfPagesValue";
            this.editNumberOfPagesValue.Size = new System.Drawing.Size(307, 35);
            this.editNumberOfPagesValue.TabIndex = 24;
            // 
            // editNumberOfPagesLabel
            // 
            this.editNumberOfPagesLabel.AutoSize = true;
            this.editNumberOfPagesLabel.Location = new System.Drawing.Point(23, 167);
            this.editNumberOfPagesLabel.Name = "editNumberOfPagesLabel";
            this.editNumberOfPagesLabel.Size = new System.Drawing.Size(221, 30);
            this.editNumberOfPagesLabel.TabIndex = 23;
            this.editNumberOfPagesLabel.Text = "Edit Number of Pages:";
            // 
            // editBookTitleValue
            // 
            this.editBookTitleValue.Location = new System.Drawing.Point(239, 121);
            this.editBookTitleValue.Name = "editBookTitleValue";
            this.editBookTitleValue.Size = new System.Drawing.Size(307, 35);
            this.editBookTitleValue.TabIndex = 22;
            // 
            // editBookTitleLabel
            // 
            this.editBookTitleLabel.AutoSize = true;
            this.editBookTitleLabel.Location = new System.Drawing.Point(23, 126);
            this.editBookTitleLabel.Name = "editBookTitleLabel";
            this.editBookTitleLabel.Size = new System.Drawing.Size(150, 30);
            this.editBookTitleLabel.TabIndex = 21;
            this.editBookTitleLabel.Text = "Edit Book Title:";
            // 
            // editBookLabel
            // 
            this.editBookLabel.AutoSize = true;
            this.editBookLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookLabel.Location = new System.Drawing.Point(367, 9);
            this.editBookLabel.Name = "editBookLabel";
            this.editBookLabel.Size = new System.Drawing.Size(155, 45);
            this.editBookLabel.TabIndex = 20;
            this.editBookLabel.Text = "Edit Book";
            // 
            // editCategoryLabel
            // 
            this.editCategoryLabel.AutoSize = true;
            this.editCategoryLabel.Location = new System.Drawing.Point(33, 251);
            this.editCategoryLabel.Name = "editCategoryLabel";
            this.editCategoryLabel.Size = new System.Drawing.Size(142, 30);
            this.editCategoryLabel.TabIndex = 37;
            this.editCategoryLabel.Text = "Edit Category:";
            // 
            // picturePathLabel
            // 
            this.picturePathLabel.AutoSize = true;
            this.picturePathLabel.Location = new System.Drawing.Point(598, 159);
            this.picturePathLabel.Name = "picturePathLabel";
            this.picturePathLabel.Size = new System.Drawing.Size(0, 30);
            this.picturePathLabel.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Choose a Book:";
            // 
            // chooseBookComboBox
            // 
            this.chooseBookComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.chooseBookComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.chooseBookComboBox.FormattingEnabled = true;
            this.chooseBookComboBox.Items.AddRange(new object[] {
            ""});
            this.chooseBookComboBox.Location = new System.Drawing.Point(341, 66);
            this.chooseBookComboBox.Name = "chooseBookComboBox";
            this.chooseBookComboBox.Size = new System.Drawing.Size(368, 38);
            this.chooseBookComboBox.Sorted = true;
            this.chooseBookComboBox.TabIndex = 39;
            this.chooseBookComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseBookComboBox_SelectedIndexChanged);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 638);
            this.Controls.Add(this.chooseBookComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editCategoryLabel);
            this.Controls.Add(this.editAuthorComboBox);
            this.Controls.Add(this.editCategoryComboBox);
            this.Controls.Add(this.editAuthorLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.uploadPictureBox);
            this.Controls.Add(this.picturePathLabel);
            this.Controls.Add(this.editPictureButton);
            this.Controls.Add(this.editPriceBookValue);
            this.Controls.Add(this.editPriceLabel);
            this.Controls.Add(this.editBookButton);
            this.Controls.Add(this.editShortDescriptionValue);
            this.Controls.Add(this.editShortDescriptionLabel);
            this.Controls.Add(this.editNumberOfPagesValue);
            this.Controls.Add(this.editNumberOfPagesLabel);
            this.Controls.Add(this.editBookTitleValue);
            this.Controls.Add(this.editBookTitleLabel);
            this.Controls.Add(this.editBookLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditBookForm";
            this.Text = "Edit Book";
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox editAuthorComboBox;
        private System.Windows.Forms.ComboBox editCategoryComboBox;
        private System.Windows.Forms.Label editAuthorLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.PictureBox uploadPictureBox;
        private System.Windows.Forms.Button editPictureButton;
        private System.Windows.Forms.TextBox editPriceBookValue;
        private System.Windows.Forms.Label editPriceLabel;
        private System.Windows.Forms.Button editBookButton;
        private System.Windows.Forms.TextBox editShortDescriptionValue;
        private System.Windows.Forms.Label editShortDescriptionLabel;
        private System.Windows.Forms.TextBox editNumberOfPagesValue;
        private System.Windows.Forms.Label editNumberOfPagesLabel;
        private System.Windows.Forms.TextBox editBookTitleValue;
        private System.Windows.Forms.Label editBookTitleLabel;
        private System.Windows.Forms.Label editBookLabel;
        private System.Windows.Forms.Label editCategoryLabel;
        private System.Windows.Forms.Label picturePathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseBookComboBox;
    }
}