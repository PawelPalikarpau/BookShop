using ShopLibrary;
using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI.MyProfileForms
{
    public partial class MyListOfBooksForm : Form
    {
        MainForm parent;

        public MyListOfBooksForm(MainForm p)
        {
            this.parent = p;
            parent.DisableParentMenu();

            this.FormClosing += new FormClosingEventHandler(myListOfbooksForm_Closing);
            InitializeComponent();
            CreateTable();
        }

        private void myListOfbooksForm_Closing(object sender, FormClosingEventArgs e)
        {
            parent.EnableParentMenu();
        }

        private void CreateTable()
        {
            listOfBooksTable.DataSource = null;

            DataTable table = new DataTable();

            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Pages", typeof(int));
            table.Columns.Add("Price", typeof(string));

            int i = 1;

            foreach (AuthorModel author in parent.personModel.BoutghtAuthors)
            {
                foreach (BookModel book in author.Books)
                {
                    table.Rows.Add(i, book.BookName, author.FullName, book.Category.Category, book.Pages, "$" + book.Price.ToString());
                    i++;
                }
            }
            listOfBooksTable.DataSource = table;

            listOfBooksTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            listOfBooksTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            listOfBooksTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            listOfBooksTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            listOfBooksTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            listOfBooksTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void createExcelButton_Click(object sender, EventArgs e)
        {
            GlobalConfig.FileConnection.CreateBoughtExcel(parent.personModel);
        }
    }
}
