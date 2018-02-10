namespace ShopUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.myCartToolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.myListOfBooksToolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItemMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItemMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItemMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItemMainForm = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItemMainManu = new System.Windows.Forms.ToolStripMenuItem();
            this.editAuthorToolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategoryToolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.searchToolStripMenuItemMainForm,
            this.editToolStripMenuItemMainMenu});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(928, 45);
            this.menuStripMainForm.TabIndex = 7;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItemMainMenu,
            this.myCartToolStripMenuItemMainMenu,
            this.myListOfBooksToolStripMenuItemMainMenu,
            this.logOutToolStripMenuItemMainMenu});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(105, 41);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // myProfileToolStripMenuItemMainMenu
            // 
            this.myProfileToolStripMenuItemMainMenu.Name = "myProfileToolStripMenuItemMainMenu";
            this.myProfileToolStripMenuItemMainMenu.Size = new System.Drawing.Size(287, 42);
            this.myProfileToolStripMenuItemMainMenu.Text = "My Profile";
            this.myProfileToolStripMenuItemMainMenu.Click += new System.EventHandler(this.myProfileToolStripMenuItemMainMenu_Click);
            // 
            // myCartToolStripMenuItemMainMenu
            // 
            this.myCartToolStripMenuItemMainMenu.Name = "myCartToolStripMenuItemMainMenu";
            this.myCartToolStripMenuItemMainMenu.Size = new System.Drawing.Size(287, 42);
            this.myCartToolStripMenuItemMainMenu.Text = "My Cart";
            this.myCartToolStripMenuItemMainMenu.Click += new System.EventHandler(this.myCartToolStripMenuItemMainMenu_Click);
            // 
            // myListOfBooksToolStripMenuItemMainMenu
            // 
            this.myListOfBooksToolStripMenuItemMainMenu.Name = "myListOfBooksToolStripMenuItemMainMenu";
            this.myListOfBooksToolStripMenuItemMainMenu.Size = new System.Drawing.Size(287, 42);
            this.myListOfBooksToolStripMenuItemMainMenu.Text = "My List of Books";
            this.myListOfBooksToolStripMenuItemMainMenu.Click += new System.EventHandler(this.myListOfBooksToolStripMenuItemMainMenu_Click);
            // 
            // logOutToolStripMenuItemMainMenu
            // 
            this.logOutToolStripMenuItemMainMenu.Name = "logOutToolStripMenuItemMainMenu";
            this.logOutToolStripMenuItemMainMenu.Size = new System.Drawing.Size(287, 42);
            this.logOutToolStripMenuItemMainMenu.Text = "Log Out";
            this.logOutToolStripMenuItemMainMenu.Click += new System.EventHandler(this.logOutToolStripMenuItemMainMenu_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItemMainForm,
            this.categoryToolStripMenuItemMainForm,
            this.authorToolStripMenuItemMainForm});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(78, 41);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // bookToolStripMenuItemMainForm
            // 
            this.bookToolStripMenuItemMainForm.Name = "bookToolStripMenuItemMainForm";
            this.bookToolStripMenuItemMainForm.Size = new System.Drawing.Size(202, 42);
            this.bookToolStripMenuItemMainForm.Text = "Book";
            this.bookToolStripMenuItemMainForm.Click += new System.EventHandler(this.bookToolStripMenuItemMainForm_Click);
            // 
            // categoryToolStripMenuItemMainForm
            // 
            this.categoryToolStripMenuItemMainForm.Name = "categoryToolStripMenuItemMainForm";
            this.categoryToolStripMenuItemMainForm.Size = new System.Drawing.Size(202, 42);
            this.categoryToolStripMenuItemMainForm.Text = "Category";
            this.categoryToolStripMenuItemMainForm.Click += new System.EventHandler(this.categoryToolStripMenuItemMainForm_Click);
            // 
            // authorToolStripMenuItemMainForm
            // 
            this.authorToolStripMenuItemMainForm.Name = "authorToolStripMenuItemMainForm";
            this.authorToolStripMenuItemMainForm.Size = new System.Drawing.Size(202, 42);
            this.authorToolStripMenuItemMainForm.Text = "Author";
            this.authorToolStripMenuItemMainForm.Click += new System.EventHandler(this.authorToolStripMenuItemMainForm_Click);
            // 
            // searchToolStripMenuItemMainForm
            // 
            this.searchToolStripMenuItemMainForm.Name = "searchToolStripMenuItemMainForm";
            this.searchToolStripMenuItemMainForm.Size = new System.Drawing.Size(107, 41);
            this.searchToolStripMenuItemMainForm.Text = "Search";
            this.searchToolStripMenuItemMainForm.Click += new System.EventHandler(this.searchToolStripMenuItemMainForm_Click);
            // 
            // editToolStripMenuItemMainMenu
            // 
            this.editToolStripMenuItemMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBookToolStripMenuItemMainManu,
            this.editAuthorToolStripMenuItemMainMenu,
            this.editCategoryToolStripMenuItemMainMenu});
            this.editToolStripMenuItemMainMenu.Name = "editToolStripMenuItemMainMenu";
            this.editToolStripMenuItemMainMenu.Size = new System.Drawing.Size(75, 41);
            this.editToolStripMenuItemMainMenu.Text = "Edit";
            // 
            // editBookToolStripMenuItemMainManu
            // 
            this.editBookToolStripMenuItemMainManu.Name = "editBookToolStripMenuItemMainManu";
            this.editBookToolStripMenuItemMainManu.Size = new System.Drawing.Size(202, 42);
            this.editBookToolStripMenuItemMainManu.Text = "Book";
            this.editBookToolStripMenuItemMainManu.Click += new System.EventHandler(this.editBookToolStripMenuItemMainManu_Click);
            // 
            // editAuthorToolStripMenuItemMainMenu
            // 
            this.editAuthorToolStripMenuItemMainMenu.Name = "editAuthorToolStripMenuItemMainMenu";
            this.editAuthorToolStripMenuItemMainMenu.Size = new System.Drawing.Size(202, 42);
            this.editAuthorToolStripMenuItemMainMenu.Text = "Author";
            this.editAuthorToolStripMenuItemMainMenu.Click += new System.EventHandler(this.editAuthorToolStripMenuItemMainMenu_Click);
            // 
            // editCategoryToolStripMenuItemMainMenu
            // 
            this.editCategoryToolStripMenuItemMainMenu.Name = "editCategoryToolStripMenuItemMainMenu";
            this.editCategoryToolStripMenuItemMainMenu.Size = new System.Drawing.Size(202, 42);
            this.editCategoryToolStripMenuItemMainMenu.Text = "Category";
            this.editCategoryToolStripMenuItemMainMenu.Click += new System.EventHandler(this.editCategoryToolStripMenuItemMainMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(928, 725);
            this.Controls.Add(this.menuStripMainForm);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMainForm;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MainForm";
            this.Text = "Book Shop Manager";
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem myCartToolStripMenuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem myListOfBooksToolStripMenuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItemMainForm;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItemMainForm;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItemMainForm;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItemMainForm;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItemMainManu;
        private System.Windows.Forms.ToolStripMenuItem editAuthorToolStripMenuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem editCategoryToolStripMenuItemMainMenu;
    }
}