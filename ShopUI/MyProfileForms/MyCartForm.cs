using ShopLibrary;
using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ShopUI.MyProfileForms
{
    public partial class MyCartForm : Form
    {
        private MainForm parent;
        private List<AuthorModel> authors;
        private decimal priceSumm;

        public MyCartForm(MainForm p)
        {
            this.parent = p;
            parent.DisableParentMenu();
            authors = parent.personModel.CartAuthors;

            this.FormClosing += new FormClosingEventHandler(myCartForm_Closing);
            InitializeComponent();

            CreateTable();

            InsertPersonData();
        }

        private void myCartForm_Closing(object sender, FormClosingEventArgs e)
        {
            parent.EnableParentMenu();
        }

        private void InsertPersonData()
        {
            priceSumm = 0;

            foreach (DataGridViewRow row in dataTable.Rows)
            {
                string data = row.Cells["Price"].Value.ToString();
                data = data.Substring(1, data.Length - 1);
                priceSumm += decimal.Parse(data);
            }

            nameLabel.Text = parent.personModel.FirstName + " " + parent.personModel.LastName + ", You have: " + "$" + parent.personModel.Money;
            boosCostLabel.Text = "Cost of all books in your cart: $" + priceSumm.ToString();
        }

        private void depositMoneyButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string code = rnd.Next(100000, 10000000).ToString();
        }

        private void CreateTable()
        {
            dataTable.DataSource = null;

            DataTable table = new DataTable();

            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Pages", typeof(int));
            table.Columns.Add("Price", typeof(string));

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Delete";
            deleteButton.Name = "deleteButton";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            int i = 1;

            foreach (AuthorModel author in authors)
            {
                foreach (BookModel book in author.Books)
                {
                    table.Rows.Add(i, book.BookName, author.FullName, book.Category.Category, book.Pages, "$" + book.Price.ToString());
                    i++;
                }
            }
            dataTable.DataSource = table;

            dataTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataTable.Columns.Add(deleteButton);
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                string bookTitle = dataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                string authorName = dataTable.Rows[e.RowIndex].Cells[3].Value.ToString();

                dataTable.Rows.RemoveAt(e.RowIndex);

                BookModel book = parent.personModel.CartAuthors.Find(a => a.FullName == authorName).Books.Find(b => b.BookName == bookTitle);
                GlobalConfig.Connection.PersonCartBook_DeleteBook(parent.personModel, book);

                parent.personModel.CartAuthors.Find(a => a.FullName == authorName).Books.RemoveAll(b => b.BookName == bookTitle);
                
                for (int i = 1; i <= dataTable.RowCount; i++)
                {
                    dataTable.Rows[i - 1].Cells[1].Value = i;
                }

                InsertPersonData();
            }
        }

        private void buyBooksButton_Click(object sender, EventArgs e)
        {
            
            if (parent.personModel.Money < priceSumm)
            {
                MessageBox.Show("There is not enought money on your profile!");
                return;
            }
            else
            {
                UpdateBoughtBookList();

                parent.personModel.CartAuthors = new List<AuthorModel>();
                parent.personModel.Money = parent.personModel.Money - priceSumm;

                GlobalConfig.Connection.UpdatePerson(parent.personModel);
                GlobalConfig.Connection.PersonCartBook_DeletePerson(parent.personModel);
                
                int numberOfRows = dataTable.Rows.Count;
                for (int x = 0; x < numberOfRows; x++)
                {
                    dataTable.Rows.RemoveAt(0);
                }

                InsertPersonData();
            }
        }

        private void UpdateBoughtBookList()
        {
            List<BookModel> bookList = new List<BookModel>();

            foreach (AuthorModel author in parent.personModel.CartAuthors)
            {
                foreach (BookModel book in author.Books)
                {
                    bool isAlreadyBoughtAuthor = parent.personModel.BoutghtAuthors.Any(a => a.Id == author.Id);
                    if (isAlreadyBoughtAuthor)
                    {
                        parent.personModel.BoutghtAuthors.Find(a => a.Id == author.Id).Books.Add(book);
                    }
                    else
                    {
                        AuthorModel at = author;
                        at.Books = new List<BookModel>();
                        at.Books.Add(book);
                        parent.personModel.BoutghtAuthors.Add(at);
                    }
                    bookList.Add(book);
                }
            }

            GlobalConfig.Connection.PersonBoughtBooks_InsertBooks(parent.personModel, bookList);
        }
    }
}