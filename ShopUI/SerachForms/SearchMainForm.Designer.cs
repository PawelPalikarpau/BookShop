namespace ShopUI.SerachForms
{
    partial class SearchMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMainForm));
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchByCategoryLAbel = new System.Windows.Forms.Label();
            this.searchByCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchByAuthorLabel = new System.Windows.Forms.Label();
            this.searchByAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.searchByTitleComboBox = new System.Windows.Forms.ComboBox();
            this.searchByTitleLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(0, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(1083, 48);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchByCategoryLAbel
            // 
            this.searchByCategoryLAbel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByCategoryLAbel.AutoSize = true;
            this.searchByCategoryLAbel.Location = new System.Drawing.Point(727, 48);
            this.searchByCategoryLAbel.Name = "searchByCategoryLAbel";
            this.searchByCategoryLAbel.Size = new System.Drawing.Size(197, 30);
            this.searchByCategoryLAbel.TabIndex = 17;
            this.searchByCategoryLAbel.Text = "Search by Category:";
            // 
            // searchByCategoryComboBox
            // 
            this.searchByCategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByCategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchByCategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchByCategoryComboBox.FormattingEnabled = true;
            this.searchByCategoryComboBox.Location = new System.Drawing.Point(732, 81);
            this.searchByCategoryComboBox.Name = "searchByCategoryComboBox";
            this.searchByCategoryComboBox.Size = new System.Drawing.Size(263, 38);
            this.searchByCategoryComboBox.Sorted = true;
            this.searchByCategoryComboBox.TabIndex = 16;
            this.searchByCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByCategoComboBox_SelectedIndexChanged);
            // 
            // searchByAuthorLabel
            // 
            this.searchByAuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByAuthorLabel.AutoSize = true;
            this.searchByAuthorLabel.Location = new System.Drawing.Point(458, 48);
            this.searchByAuthorLabel.Name = "searchByAuthorLabel";
            this.searchByAuthorLabel.Size = new System.Drawing.Size(178, 30);
            this.searchByAuthorLabel.TabIndex = 15;
            this.searchByAuthorLabel.Text = "Search by Author:";
            // 
            // searchByAuthorComboBox
            // 
            this.searchByAuthorComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByAuthorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchByAuthorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchByAuthorComboBox.FormattingEnabled = true;
            this.searchByAuthorComboBox.Location = new System.Drawing.Point(463, 81);
            this.searchByAuthorComboBox.Name = "searchByAuthorComboBox";
            this.searchByAuthorComboBox.Size = new System.Drawing.Size(263, 38);
            this.searchByAuthorComboBox.Sorted = true;
            this.searchByAuthorComboBox.TabIndex = 14;
            this.searchByAuthorComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByAuthorComboBox_SelectedIndexChanged);
            // 
            // searchByTitleComboBox
            // 
            this.searchByTitleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByTitleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchByTitleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchByTitleComboBox.FormattingEnabled = true;
            this.searchByTitleComboBox.Location = new System.Drawing.Point(93, 81);
            this.searchByTitleComboBox.Name = "searchByTitleComboBox";
            this.searchByTitleComboBox.Size = new System.Drawing.Size(364, 38);
            this.searchByTitleComboBox.Sorted = true;
            this.searchByTitleComboBox.TabIndex = 12;
            this.searchByTitleComboBox.SelectedIndexChanged += new System.EventHandler(this.searchByTitleComboBox_SelectedIndexChanged);
            // 
            // searchByTitleLabel
            // 
            this.searchByTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchByTitleLabel.AutoSize = true;
            this.searchByTitleLabel.Location = new System.Drawing.Point(88, 48);
            this.searchByTitleLabel.Name = "searchByTitleLabel";
            this.searchByTitleLabel.Size = new System.Drawing.Size(153, 30);
            this.searchByTitleLabel.TabIndex = 13;
            this.searchByTitleLabel.Text = "Search by Title:";
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.infoPanel.AutoScroll = true;
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.Location = new System.Drawing.Point(90, 147);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(902, 453);
            this.infoPanel.TabIndex = 18;
            // 
            // SearchMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 612);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.searchByCategoryLAbel);
            this.Controls.Add(this.searchByCategoryComboBox);
            this.Controls.Add(this.searchByAuthorLabel);
            this.Controls.Add(this.searchByAuthorComboBox);
            this.Controls.Add(this.searchByTitleComboBox);
            this.Controls.Add(this.searchByTitleLabel);
            this.Controls.Add(this.searchLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SearchMainForm";
            this.Text = "Search Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label searchByCategoryLAbel;
        private System.Windows.Forms.ComboBox searchByCategoryComboBox;
        private System.Windows.Forms.Label searchByAuthorLabel;
        private System.Windows.Forms.ComboBox searchByAuthorComboBox;
        private System.Windows.Forms.ComboBox searchByTitleComboBox;
        private System.Windows.Forms.Label searchByTitleLabel;
        private System.Windows.Forms.FlowLayoutPanel infoPanel;
    }
}