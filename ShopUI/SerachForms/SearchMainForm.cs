using ShopLibrary;
using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI.SerachForms
{
    public partial class SearchMainForm : Form
    {
        MainForm parent;

        List<BookModel> books = GlobalConfig.Connection.GetAllBooks();
        List<AuthorModel> authors = GlobalConfig.Connection.GetAllAuthors();
        List<CategoryModel> categories = GlobalConfig.Connection.GetAllCategories();
        List<BookModel> alreadyBoughtBooks;
        private bool inForm;

        public SearchMainForm(MainForm p)
        {
            inForm = false;

            InitializeComponent();
            parent = p;
            parent.DisableParentMenu();
            alreadyBoughtBooks = GetAllBoughtBooks();

            this.FormClosing += new FormClosingEventHandler(SearchMainForm_FormClosing);

            books.Insert(0, new BookModel());
            authors.Insert(0, new AuthorModel());
            categories.Insert(0, new CategoryModel());

            WireUpBooks();
            WireUpAuthors();
            WireUpCategories();

            inForm = true;
        }

        private List<BookModel> GetAllBoughtBooks()
        {
            List<BookModel> list = new List<BookModel>();

            foreach (AuthorModel author in parent.personModel.BoutghtAuthors)
            {
                foreach (BookModel book in author.Books)
                {
                    list.Add(book);
                }
            }

            return list;
        }

        private void SearchMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inForm = false;
            parent.EnableParentMenu();
        }

        private void WireUpBooks()
        {
            searchByTitleComboBox.DataSource = null;
            searchByTitleComboBox.DataSource = books;
            searchByTitleComboBox.DisplayMember = "BookName";
            searchByTitleComboBox.SelectedIndex = 0;
        }

        private void WireUpAuthors()
        {
            searchByAuthorComboBox.DataSource = null;
            searchByAuthorComboBox.DataSource = authors;
            searchByAuthorComboBox.DisplayMember = "FullName";
            searchByAuthorComboBox.SelectedIndex = 0;
        }
        private void WireUpCategories()
        {
            searchByCategoryComboBox.DataSource = null;
            searchByCategoryComboBox.DataSource = categories;
            searchByCategoryComboBox.DisplayMember = "Category";
            searchByCategoryComboBox.SelectedIndex = 0;
        }

        private void searchByTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchByTitleComboBox.SelectedIndex == 0 && 
                searchByAuthorComboBox.SelectedIndex == 0 &&
                searchByCategoryComboBox.SelectedIndex == 0)
            {
                infoPanel.Controls.Clear();
            }

            if (inForm && searchByTitleComboBox.SelectedIndex != 0)
            {
                infoPanel.Controls.Clear();

                searchByAuthorComboBox.SelectedIndex = 0;
                searchByCategoryComboBox.SelectedIndex = 0;
                infoPanel.Select();

                BookModel book = (BookModel)searchByTitleComboBox.SelectedItem;
                book.Category = GlobalConfig.Connection.GetCategory_ByBook(book);
                AuthorModel author = GlobalConfig.Connection.GetAuthor_ByBook(book);

                infoPanel.Controls.Add(CreateItemPanel(book, author));
            }
        }

        private void searchByAuthorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchByTitleComboBox.SelectedIndex == 0 &&
                searchByAuthorComboBox.SelectedIndex == 0 &&
                searchByCategoryComboBox.SelectedIndex == 0)
            {
                infoPanel.Controls.Clear();
            }

            if (inForm && searchByAuthorComboBox.SelectedIndex != 0)
            {
                infoPanel.Controls.Clear();

                searchByTitleComboBox.SelectedIndex = 0;
                searchByCategoryComboBox.SelectedIndex = 0;
                infoPanel.Select();

                AuthorModel author = (AuthorModel)searchByAuthorComboBox.SelectedItem;

                foreach (BookModel book in author.Books)
                {
                    book.Category = GlobalConfig.Connection.GetCategory_ByBook(book);
                    infoPanel.Controls.Add(CreateItemPanel(book, author));
                }
            }
        }

        private void searchByCategoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchByTitleComboBox.SelectedIndex == 0 &&
                searchByAuthorComboBox.SelectedIndex == 0 &&
                searchByCategoryComboBox.SelectedIndex == 0)
            {
                infoPanel.Controls.Clear();
            }

            if (inForm && searchByCategoryComboBox.SelectedIndex != 0)
            {
                infoPanel.Controls.Clear();

                searchByTitleComboBox.SelectedIndex = 0;
                searchByAuthorComboBox.SelectedIndex = 0;
                infoPanel.Select();

                CategoryModel category = (CategoryModel)searchByCategoryComboBox.SelectedItem;
                List<BookModel> books = GlobalConfig.Connection.GetBooksByCategory(category);
                foreach (BookModel book in books)
                {
                    book.Category = category;
                    AuthorModel author = GlobalConfig.Connection.GetAuthor_ByBook(book);

                    infoPanel.Controls.Add(CreateItemPanel(book, author));
                }
            }
        }

        private Panel CreateItemPanel(BookModel book, AuthorModel author)
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            Button addToCartButton = new System.Windows.Forms.Button();
            Button shortDescriptionButton = new System.Windows.Forms.Button();
            Label inCartLabel = new System.Windows.Forms.Label();
            Label priceLabel = new System.Windows.Forms.Label();
            Label pagesLabel = new System.Windows.Forms.Label();
            Label categoryLabel = new System.Windows.Forms.Label();
            Label authorLabel = new System.Windows.Forms.Label();
            Label titleLabel = new System.Windows.Forms.Label();
            PictureBox itemPictureBox = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(itemPictureBox)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(addToCartButton);
            panel1.Controls.Add(shortDescriptionButton);
            panel1.Controls.Add(inCartLabel);
            panel1.Controls.Add(priceLabel);
            panel1.Controls.Add(pagesLabel);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(authorLabel);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(itemPictureBox);
            panel1.Location = new System.Drawing.Point(10, 3);
            panel1.Name = "panel";
            panel1.Size = new System.Drawing.Size(960, 240);
            panel1.TabIndex = 0;
            // 
            // inCartLabel
            // 
            inCartLabel.AutoSize = true;
            inCartLabel.Location = new System.Drawing.Point(250, 10);
            inCartLabel.Name = "inCartLabel";
            inCartLabel.Size = new System.Drawing.Size(35, 13);
            inCartLabel.TabIndex = 5;

            bool isAlreadyBoughtBook = alreadyBoughtBooks.Any(b => b.Id == book.Id);
            if (!isAlreadyBoughtBook)
            {
                bool isAuthorExists = parent.personModel.CartAuthors.Any(a => a.Id == author.Id);
                if (isAuthorExists)
                {
                    AuthorModel at = parent.personModel.CartAuthors.Find(a => a.Id == author.Id);
                    bool isBookExists = at.Books.Any(books => books.Id == book.Id);
                    if (isBookExists)
                    {
                        inCartLabel.Text = "In Your Cart";
                    }
                }
                else
                {
                    inCartLabel.Text = "";
                }
            }
            else
            {
                inCartLabel.Text = "Already Bought";
            }
            
            inCartLabel.ForeColor = Color.Red;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(436, 199);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(35, 13);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "$" + book.Price.ToString();
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new System.Drawing.Point(436, 157);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(35, 13);
            pagesLabel.TabIndex = 4;
            pagesLabel.Text = "Number of Pages: " + book.Pages.ToString();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(436, 115);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(35, 13);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = book.Category.Category;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(436, 73);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(35, 13);
            authorLabel.TabIndex = 2;
            authorLabel.Text = author.FullName;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(436, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(35, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = book.BookName;
            // 
            // itemPictureBox
            // 
            itemPictureBox.Location = new System.Drawing.Point(20, 9);
            itemPictureBox.Name = "itemPictureBox";
            itemPictureBox.Size = new System.Drawing.Size(162, 227);
            itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            itemPictureBox.TabIndex = 0;
            itemPictureBox.TabStop = false;
            itemPictureBox.Image = ByteArrayToImage(book.Photo);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(itemPictureBox)).EndInit();
            ResumeLayout(false);
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new System.Drawing.Point(214, 135);
            addToCartButton.Name = book.Id.ToString() + ',' + author.Id.ToString() + ',' + book.Category.Id.ToString();
            addToCartButton.Size = new System.Drawing.Size(192, 53);
            addToCartButton.TabIndex = 7;
            addToCartButton.Text = "Add to Cart";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += new EventHandler(buttonAddToCart_Click);
            // 
            // shortDescriptionButton
            // 
            shortDescriptionButton.Location = new System.Drawing.Point(214, 56);
            shortDescriptionButton.Name = book.Id.ToString() + ',' + author.Id.ToString();
            shortDescriptionButton.Size = new System.Drawing.Size(192, 53);
            shortDescriptionButton.TabIndex = 6;
            shortDescriptionButton.Text = "Short Description";
            shortDescriptionButton.UseVisualStyleBackColor = true;
            shortDescriptionButton.Click += new EventHandler(buttonDescription_Click);

            return panel1;
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            string[] arr = (((Button)sender).Name).Split(',');
            int bookId = int.Parse(arr[0]);
            int authorId = int.Parse(arr[1]);
            int categoryId = int.Parse(arr[2]);

            AuthorModel author = GlobalConfig.Connection.GetAuthorById(authorId);
            author.Books = new List<BookModel>();
            BookModel bk = new BookModel();
            bk.Id = bookId;
            bk = (GlobalConfig.Connection.GetBookById(bk))[0];
            bk.Category = GlobalConfig.Connection.GetCategory_ByBook(bk);
            author.Books.Add(bk);

            bool isAlreadyBoughtBook = alreadyBoughtBooks.Any(b => b.Id == bookId);
            if (!isAlreadyBoughtBook)
            {
                bool isAuthorExists = parent.personModel.CartAuthors.Any(a => a.Id == author.Id);
                if (isAuthorExists)
                {
                    AuthorModel aut = parent.personModel.CartAuthors.Find(a => a.Id == author.Id);
                    bool isBookExists = aut.Books.Any(b => b.Id == bk.Id);
                    if (isBookExists)
                    {
                        return;
                    }

                    parent.personModel.CartAuthors.Find(authors => authors.Id == author.Id).Books.Add(bk);
                }
                else
                {
                    parent.personModel.CartAuthors.Add(author);
                }

            ((Button)sender).Parent.Controls.Find("inCartLabel", true).First().Text = "In Your Cart";
                GlobalConfig.Connection.PersonCartBook_Insert(parent.personModel, bk);
            }
        }

        private void buttonDescription_Click(object sender, EventArgs e)
        {
            string[] arr = (((Button)sender).Name).Split(',');
            int bookId = int.Parse(arr[0]);
            int authorId = int.Parse(arr[1]);
            
            string description = books.Find(x => x.Id == bookId).Description;
            string bookTitle = books.Find(x => x.Id == bookId).BookName;
            string author = authors.Find(x => x.Id == authorId).FullName;

            ShowDescriptionForm newForm = new ShowDescriptionForm((bookTitle + " BY " + author), description);
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
        }

        private Image ByteArrayToImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            Image i = Image.FromStream(ms);
            return i;
        }
    }
}
