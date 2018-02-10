namespace ShopUI.EditForms
{
    partial class EditCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategoryForm));
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.editCategoryValue = new System.Windows.Forms.TextBox();
            this.setCategoryLabel = new System.Windows.Forms.Label();
            this.editCategoryLabel = new System.Windows.Forms.Label();
            this.chooseCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.chooseCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.Location = new System.Drawing.Point(210, 158);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(148, 44);
            this.editCategoryButton.TabIndex = 7;
            this.editCategoryButton.Text = "Edit Category";
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Click += new System.EventHandler(this.editCategoryButton_Click);
            // 
            // editCategoryValue
            // 
            this.editCategoryValue.Location = new System.Drawing.Point(253, 101);
            this.editCategoryValue.Name = "editCategoryValue";
            this.editCategoryValue.Size = new System.Drawing.Size(280, 35);
            this.editCategoryValue.TabIndex = 6;
            // 
            // setCategoryLabel
            // 
            this.setCategoryLabel.AutoSize = true;
            this.setCategoryLabel.Location = new System.Drawing.Point(36, 104);
            this.setCategoryLabel.Name = "setCategoryLabel";
            this.setCategoryLabel.Size = new System.Drawing.Size(142, 30);
            this.setCategoryLabel.TabIndex = 5;
            this.setCategoryLabel.Text = "Edit Category:";
            // 
            // editCategoryLabel
            // 
            this.editCategoryLabel.AutoSize = true;
            this.editCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCategoryLabel.Location = new System.Drawing.Point(179, 9);
            this.editCategoryLabel.Name = "editCategoryLabel";
            this.editCategoryLabel.Size = new System.Drawing.Size(211, 45);
            this.editCategoryLabel.TabIndex = 4;
            this.editCategoryLabel.Text = "Edit Category";
            // 
            // chooseCategoryComboBox
            // 
            this.chooseCategoryComboBox.FormattingEnabled = true;
            this.chooseCategoryComboBox.Location = new System.Drawing.Point(253, 57);
            this.chooseCategoryComboBox.Name = "chooseCategoryComboBox";
            this.chooseCategoryComboBox.Size = new System.Drawing.Size(280, 38);
            this.chooseCategoryComboBox.Sorted = true;
            this.chooseCategoryComboBox.TabIndex = 8;
            this.chooseCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseCategoryComboBox_SelectedIndexChanged);
            // 
            // chooseCategoryLabel
            // 
            this.chooseCategoryLabel.AutoSize = true;
            this.chooseCategoryLabel.Location = new System.Drawing.Point(36, 60);
            this.chooseCategoryLabel.Name = "chooseCategoryLabel";
            this.chooseCategoryLabel.Size = new System.Drawing.Size(212, 30);
            this.chooseCategoryLabel.TabIndex = 9;
            this.chooseCategoryLabel.Text = "Choose the Category:";
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 219);
            this.Controls.Add(this.chooseCategoryLabel);
            this.Controls.Add(this.chooseCategoryComboBox);
            this.Controls.Add(this.editCategoryButton);
            this.Controls.Add(this.editCategoryValue);
            this.Controls.Add(this.setCategoryLabel);
            this.Controls.Add(this.editCategoryLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditCategoryForm";
            this.Text = "Edit Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editCategoryButton;
        private System.Windows.Forms.TextBox editCategoryValue;
        private System.Windows.Forms.Label setCategoryLabel;
        private System.Windows.Forms.Label editCategoryLabel;
        private System.Windows.Forms.ComboBox chooseCategoryComboBox;
        private System.Windows.Forms.Label chooseCategoryLabel;
    }
}