namespace ShopUI.AddForms
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.addNewBookLabel = new System.Windows.Forms.Label();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.bookTitleValue = new System.Windows.Forms.TextBox();
            this.numberOfPagesValue = new System.Windows.Forms.TextBox();
            this.numberOfPagesLabel = new System.Windows.Forms.Label();
            this.shortDescriptionLabel = new System.Windows.Forms.Label();
            this.shortDescriptionValue = new System.Windows.Forms.TextBox();
            this.createBookButton = new System.Windows.Forms.Button();
            this.priceBookValue = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.uploadPictureButton = new System.Windows.Forms.Button();
            this.picturePathLabel = new System.Windows.Forms.Label();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.addCategoryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addAuthorLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewBookLabel
            // 
            this.addNewBookLabel.AutoSize = true;
            this.addNewBookLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBookLabel.Location = new System.Drawing.Point(327, 9);
            this.addNewBookLabel.Name = "addNewBookLabel";
            this.addNewBookLabel.Size = new System.Drawing.Size(233, 45);
            this.addNewBookLabel.TabIndex = 0;
            this.addNewBookLabel.Text = "Add New Book";
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(23, 78);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(210, 30);
            this.bookTitleLabel.TabIndex = 1;
            this.bookTitleLabel.Text = "The Title of the Book:";
            // 
            // bookTitleValue
            // 
            this.bookTitleValue.Location = new System.Drawing.Point(239, 73);
            this.bookTitleValue.Name = "bookTitleValue";
            this.bookTitleValue.Size = new System.Drawing.Size(307, 35);
            this.bookTitleValue.TabIndex = 2;
            // 
            // numberOfPagesValue
            // 
            this.numberOfPagesValue.Location = new System.Drawing.Point(239, 114);
            this.numberOfPagesValue.Name = "numberOfPagesValue";
            this.numberOfPagesValue.Size = new System.Drawing.Size(307, 35);
            this.numberOfPagesValue.TabIndex = 4;
            // 
            // numberOfPagesLabel
            // 
            this.numberOfPagesLabel.AutoSize = true;
            this.numberOfPagesLabel.Location = new System.Drawing.Point(23, 119);
            this.numberOfPagesLabel.Name = "numberOfPagesLabel";
            this.numberOfPagesLabel.Size = new System.Drawing.Size(180, 30);
            this.numberOfPagesLabel.TabIndex = 3;
            this.numberOfPagesLabel.Text = "Number of Pages:";
            // 
            // shortDescriptionLabel
            // 
            this.shortDescriptionLabel.AutoSize = true;
            this.shortDescriptionLabel.Location = new System.Drawing.Point(195, 287);
            this.shortDescriptionLabel.Name = "shortDescriptionLabel";
            this.shortDescriptionLabel.Size = new System.Drawing.Size(178, 30);
            this.shortDescriptionLabel.TabIndex = 5;
            this.shortDescriptionLabel.Text = "Short Description:";
            // 
            // shortDescriptionValue
            // 
            this.shortDescriptionValue.Location = new System.Drawing.Point(28, 326);
            this.shortDescriptionValue.Multiline = true;
            this.shortDescriptionValue.Name = "shortDescriptionValue";
            this.shortDescriptionValue.Size = new System.Drawing.Size(518, 168);
            this.shortDescriptionValue.TabIndex = 7;
            // 
            // createBookButton
            // 
            this.createBookButton.Location = new System.Drawing.Point(333, 523);
            this.createBookButton.Name = "createBookButton";
            this.createBookButton.Size = new System.Drawing.Size(221, 60);
            this.createBookButton.TabIndex = 8;
            this.createBookButton.Text = "Create Book";
            this.createBookButton.UseVisualStyleBackColor = true;
            this.createBookButton.Click += new System.EventHandler(this.createBookButton_Click);
            // 
            // priceBookValue
            // 
            this.priceBookValue.Location = new System.Drawing.Point(239, 155);
            this.priceBookValue.Name = "priceBookValue";
            this.priceBookValue.Size = new System.Drawing.Size(307, 35);
            this.priceBookValue.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(23, 160);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(216, 30);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "The Price of the Book:";
            // 
            // uploadPictureButton
            // 
            this.uploadPictureButton.Location = new System.Drawing.Point(651, 63);
            this.uploadPictureButton.Name = "uploadPictureButton";
            this.uploadPictureButton.Size = new System.Drawing.Size(165, 45);
            this.uploadPictureButton.TabIndex = 11;
            this.uploadPictureButton.Text = "Upload Picture";
            this.uploadPictureButton.UseVisualStyleBackColor = true;
            this.uploadPictureButton.Click += new System.EventHandler(this.uploadPictureButton_Click);
            // 
            // picturePathLabel
            // 
            this.picturePathLabel.AutoSize = true;
            this.picturePathLabel.Location = new System.Drawing.Point(598, 111);
            this.picturePathLabel.Name = "picturePathLabel";
            this.picturePathLabel.Size = new System.Drawing.Size(0, 30);
            this.picturePathLabel.TabIndex = 12;
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.Location = new System.Drawing.Point(603, 144);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(262, 350);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uploadPictureBox.TabIndex = 13;
            this.uploadPictureBox.TabStop = false;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(33, 203);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(101, 30);
            this.categoryLabel.TabIndex = 14;
            this.categoryLabel.Text = "Category:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(294, 203);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(82, 30);
            this.authorLabel.TabIndex = 15;
            this.authorLabel.Text = "Author:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(38, 236);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(247, 38);
            this.categoryComboBox.Sorted = true;
            this.categoryComboBox.TabIndex = 16;
            // 
            // authorComboBox
            // 
            this.authorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.authorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Items.AddRange(new object[] {
            ""});
            this.authorComboBox.Location = new System.Drawing.Point(299, 236);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(247, 38);
            this.authorComboBox.Sorted = true;
            this.authorComboBox.TabIndex = 17;
            // 
            // addCategoryLinkLabel
            // 
            this.addCategoryLinkLabel.AutoSize = true;
            this.addCategoryLinkLabel.Location = new System.Drawing.Point(145, 203);
            this.addCategoryLinkLabel.Name = "addCategoryLinkLabel";
            this.addCategoryLinkLabel.Size = new System.Drawing.Size(140, 30);
            this.addCategoryLinkLabel.TabIndex = 18;
            this.addCategoryLinkLabel.TabStop = true;
            this.addCategoryLinkLabel.Text = "Add Category";
            this.addCategoryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addCategoryLinkLabel_LinkClicked);
            // 
            // addAuthorLinkLabel
            // 
            this.addAuthorLinkLabel.AutoSize = true;
            this.addAuthorLinkLabel.Location = new System.Drawing.Point(425, 203);
            this.addAuthorLinkLabel.Name = "addAuthorLinkLabel";
            this.addAuthorLinkLabel.Size = new System.Drawing.Size(121, 30);
            this.addAuthorLinkLabel.TabIndex = 19;
            this.addAuthorLinkLabel.TabStop = true;
            this.addAuthorLinkLabel.Text = "Add Author";
            this.addAuthorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addAuthorLinkLabel_LinkClicked);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 595);
            this.Controls.Add(this.addAuthorLinkLabel);
            this.Controls.Add(this.addCategoryLinkLabel);
            this.Controls.Add(this.authorComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.uploadPictureBox);
            this.Controls.Add(this.picturePathLabel);
            this.Controls.Add(this.uploadPictureButton);
            this.Controls.Add(this.priceBookValue);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.createBookButton);
            this.Controls.Add(this.shortDescriptionValue);
            this.Controls.Add(this.shortDescriptionLabel);
            this.Controls.Add(this.numberOfPagesValue);
            this.Controls.Add(this.numberOfPagesLabel);
            this.Controls.Add(this.bookTitleValue);
            this.Controls.Add(this.bookTitleLabel);
            this.Controls.Add(this.addNewBookLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewBookLabel;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.TextBox bookTitleValue;
        private System.Windows.Forms.TextBox numberOfPagesValue;
        private System.Windows.Forms.Label numberOfPagesLabel;
        private System.Windows.Forms.Label shortDescriptionLabel;
        private System.Windows.Forms.TextBox shortDescriptionValue;
        private System.Windows.Forms.Button createBookButton;
        private System.Windows.Forms.TextBox priceBookValue;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button uploadPictureButton;
        private System.Windows.Forms.Label picturePathLabel;
        private System.Windows.Forms.PictureBox uploadPictureBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.LinkLabel addCategoryLinkLabel;
        private System.Windows.Forms.LinkLabel addAuthorLinkLabel;
    }
}