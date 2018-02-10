namespace ShopUI.MyProfileForms
{
    partial class MyCartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCartForm));
            this.myCartLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.depositMoneyButton = new System.Windows.Forms.Button();
            this.boosCostLabel = new System.Windows.Forms.Label();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.buyBooksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // myCartLabel
            // 
            this.myCartLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myCartLabel.AutoSize = true;
            this.myCartLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCartLabel.Location = new System.Drawing.Point(479, 9);
            this.myCartLabel.Name = "myCartLabel";
            this.myCartLabel.Size = new System.Drawing.Size(131, 45);
            this.myCartLabel.TabIndex = 0;
            this.myCartLabel.Text = "My Cart";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(194, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 30);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // depositMoneyButton
            // 
            this.depositMoneyButton.Location = new System.Drawing.Point(12, 55);
            this.depositMoneyButton.Name = "depositMoneyButton";
            this.depositMoneyButton.Size = new System.Drawing.Size(176, 39);
            this.depositMoneyButton.TabIndex = 2;
            this.depositMoneyButton.Text = "Deposit money";
            this.depositMoneyButton.UseVisualStyleBackColor = true;
            this.depositMoneyButton.Click += new System.EventHandler(this.depositMoneyButton_Click);
            // 
            // boosCostLabel
            // 
            this.boosCostLabel.AutoSize = true;
            this.boosCostLabel.Location = new System.Drawing.Point(695, 59);
            this.boosCostLabel.Name = "boosCostLabel";
            this.boosCostLabel.Size = new System.Drawing.Size(68, 30);
            this.boosCostLabel.TabIndex = 3;
            this.boosCostLabel.Text = "label1";
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable.Location = new System.Drawing.Point(12, 116);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(1064, 460);
            this.dataTable.TabIndex = 4;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            // 
            // buyBooksButton
            // 
            this.buyBooksButton.Location = new System.Drawing.Point(565, 55);
            this.buyBooksButton.Name = "buyBooksButton";
            this.buyBooksButton.Size = new System.Drawing.Size(124, 39);
            this.buyBooksButton.TabIndex = 5;
            this.buyBooksButton.Text = "Buy Books";
            this.buyBooksButton.UseVisualStyleBackColor = true;
            this.buyBooksButton.Click += new System.EventHandler(this.buyBooksButton_Click);
            // 
            // MyCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 588);
            this.Controls.Add(this.buyBooksButton);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.boosCostLabel);
            this.Controls.Add(this.depositMoneyButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.myCartLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MyCartForm";
            this.Text = "My Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myCartLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button depositMoneyButton;
        private System.Windows.Forms.Label boosCostLabel;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button buyBooksButton;
    }
}