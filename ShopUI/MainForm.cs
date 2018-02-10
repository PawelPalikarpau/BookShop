using ShopLibrary;
using ShopLibrary.Models;
using ShopUI.AddForms;
using ShopUI.EditForms;
using ShopUI.MyProfileForms;
using ShopUI.SerachForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI
{
    public partial class MainForm : Form, IDisableEnable
    {
        public PersonModel personModel { get; set; }
        public LogModel Log { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += new FormClosingEventHandler(MainForm_Closing);
            Log = new LogModel();
            
            OpenLoginForm();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (personModel != null)
            {
                Log.LogOut = DateTime.Now;
                GlobalConfig.FileConnection.UpdateLogFile(Log);
            }
        }

        public void DisableParentMenu()
        {
            this.profileToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.Enabled = false;
            this.searchToolStripMenuItemMainForm.Enabled = false;
            this.editToolStripMenuItemMainMenu.Enabled = false;
        }

        public void EnableParentMenu()
        {
            this.profileToolStripMenuItem.Enabled = true;
            this.addToolStripMenuItem.Enabled = true;
            this.searchToolStripMenuItemMainForm.Enabled = true;
            this.editToolStripMenuItemMainMenu.Enabled = true;
        }

        private void OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.MdiParent = this;
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void logOutToolStripMenuItemMainMenu_Click(object sender, EventArgs e)
        {
            Log.LogOut = DateTime.Now;
            GlobalConfig.FileConnection.UpdateLogFile(Log);
            Log = null;
            personModel = null;
            OpenLoginForm();
        }
        private void myProfileToolStripMenuItemMainMenu_Click(object sender, EventArgs e)
        {
            MyProfileForm profileForm = new MyProfileForm(this);
            profileForm.MdiParent = this;
            profileForm.StartPosition = FormStartPosition.CenterScreen;
            profileForm.Show();
        }

        private void categoryToolStripMenuItemMainForm_Click(object sender, EventArgs e)
        {
            AddCategoryForm newForm = new AddCategoryForm();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void authorToolStripMenuItemMainForm_Click(object sender, EventArgs e)
        {
            AddAuthorForm newForm = new AddAuthorForm();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void bookToolStripMenuItemMainForm_Click(object sender, EventArgs e)
        {
            AddBookForm newForm = new AddBookForm();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void searchToolStripMenuItemMainForm_Click(object sender, EventArgs e)
        {
            SearchMainForm newForm = new SearchMainForm(this);
            newForm.MdiParent = this;
            newForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.Show();
        }

        private void editAuthorToolStripMenuItemMainMenu_Click(object sender, EventArgs e)
        {
            EditAuthorForm newForm = new EditAuthorForm();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void editCategoryToolStripMenuItemMainMenu_Click(object sender, EventArgs e)
        {
            EditCategoryForm newForm = new EditCategoryForm();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void editBookToolStripMenuItemMainManu_Click(object sender, EventArgs e)
        {
            EditBookForm newForm = new EditBookForm();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private void myCartToolStripMenuItemMainMenu_Click(object sender, EventArgs e)
        {
            MyCartForm newForm = new MyCartForm(this);
            newForm.MdiParent = this;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show();
        }

        private void myListOfBooksToolStripMenuItemMainMenu_Click(object sender, EventArgs e)
        {
            MyListOfBooksForm newForm = new MyListOfBooksForm(this);
            newForm.MdiParent = this;
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show();
        }
    }
}
