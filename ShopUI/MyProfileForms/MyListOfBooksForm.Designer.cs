namespace ShopUI.MyProfileForms
{
    partial class MyListOfBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyListOfBooksForm));
            this.listOfBooksTable = new System.Windows.Forms.DataGridView();
            this.myListOfBooksLabel = new System.Windows.Forms.Label();
            this.createExcelButton = new System.Windows.Forms.Button();
            this.createPDFButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfBooksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfBooksTable
            // 
            this.listOfBooksTable.AllowUserToAddRows = false;
            this.listOfBooksTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfBooksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.listOfBooksTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listOfBooksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listOfBooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listOfBooksTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.listOfBooksTable.Location = new System.Drawing.Point(12, 78);
            this.listOfBooksTable.Name = "listOfBooksTable";
            this.listOfBooksTable.Size = new System.Drawing.Size(1125, 476);
            this.listOfBooksTable.TabIndex = 6;
            // 
            // myListOfBooksLabel
            // 
            this.myListOfBooksLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myListOfBooksLabel.AutoSize = true;
            this.myListOfBooksLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myListOfBooksLabel.Location = new System.Drawing.Point(445, 19);
            this.myListOfBooksLabel.Name = "myListOfBooksLabel";
            this.myListOfBooksLabel.Size = new System.Drawing.Size(259, 45);
            this.myListOfBooksLabel.TabIndex = 5;
            this.myListOfBooksLabel.Text = "My List Of Books";
            // 
            // createExcelButton
            // 
            this.createExcelButton.Location = new System.Drawing.Point(91, 19);
            this.createExcelButton.Name = "createExcelButton";
            this.createExcelButton.Size = new System.Drawing.Size(173, 39);
            this.createExcelButton.TabIndex = 7;
            this.createExcelButton.Text = "Create Excel";
            this.createExcelButton.UseVisualStyleBackColor = true;
            this.createExcelButton.Click += new System.EventHandler(this.createExcelButton_Click);
            // 
            // createPDFButton
            // 
            this.createPDFButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createPDFButton.Location = new System.Drawing.Point(884, 19);
            this.createPDFButton.Name = "createPDFButton";
            this.createPDFButton.Size = new System.Drawing.Size(173, 39);
            this.createPDFButton.TabIndex = 8;
            this.createPDFButton.Text = "Create PDF";
            this.createPDFButton.UseVisualStyleBackColor = true;
            // 
            // MyListOfBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 566);
            this.Controls.Add(this.createPDFButton);
            this.Controls.Add(this.createExcelButton);
            this.Controls.Add(this.listOfBooksTable);
            this.Controls.Add(this.myListOfBooksLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MyListOfBooksForm";
            this.Text = "My List Of Books";
            ((System.ComponentModel.ISupportInitialize)(this.listOfBooksTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfBooksTable;
        private System.Windows.Forms.Label myListOfBooksLabel;
        private System.Windows.Forms.Button createExcelButton;
        private System.Windows.Forms.Button createPDFButton;
    }
}