namespace ShopUI.AddForms
{
    partial class AddCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            this.addNewCategoryLabel = new System.Windows.Forms.Label();
            this.newCategoryLabel = new System.Windows.Forms.Label();
            this.addNewCategoryValue = new System.Windows.Forms.TextBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewCategoryLabel
            // 
            this.addNewCategoryLabel.AutoSize = true;
            this.addNewCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCategoryLabel.Location = new System.Drawing.Point(140, 9);
            this.addNewCategoryLabel.Name = "addNewCategoryLabel";
            this.addNewCategoryLabel.Size = new System.Drawing.Size(289, 45);
            this.addNewCategoryLabel.TabIndex = 0;
            this.addNewCategoryLabel.Text = "Add New Category";
            // 
            // newCategoryLabel
            // 
            this.newCategoryLabel.AutoSize = true;
            this.newCategoryLabel.Location = new System.Drawing.Point(36, 74);
            this.newCategoryLabel.Name = "newCategoryLabel";
            this.newCategoryLabel.Size = new System.Drawing.Size(211, 30);
            this.newCategoryLabel.TabIndex = 1;
            this.newCategoryLabel.Text = "New Category Name:";
            // 
            // addNewCategoryValue
            // 
            this.addNewCategoryValue.Location = new System.Drawing.Point(253, 71);
            this.addNewCategoryValue.Name = "addNewCategoryValue";
            this.addNewCategoryValue.Size = new System.Drawing.Size(280, 35);
            this.addNewCategoryValue.TabIndex = 2;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(210, 128);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(148, 44);
            this.addCategoryButton.TabIndex = 3;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 191);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.addNewCategoryValue);
            this.Controls.Add(this.newCategoryLabel);
            this.Controls.Add(this.addNewCategoryLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddCategoryForm";
            this.Text = "Add Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewCategoryLabel;
        private System.Windows.Forms.Label newCategoryLabel;
        private System.Windows.Forms.TextBox addNewCategoryValue;
        private System.Windows.Forms.Button addCategoryButton;
    }
}