using ShopLibrary;
using ShopLibrary.Models;
using ShopLibrary.ValidationsAndHelpers;
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

namespace ShopUI.EditForms
{
    public partial class EditBookForm : Form
    {
        List<BookModel> books = GlobalConfig.Connection.GetAllBooks();
        List<AuthorModel> authors = GlobalConfig.Connection.GetAllAuthors();
        List<CategoryModel> categories = GlobalConfig.Connection.GetAllCategories();
        bool inForm;

        public EditBookForm()
        {
            InitializeComponent();

            books.Insert(0, new BookModel());
            authors.Insert(0, new AuthorModel());
            categories.Insert(0, new CategoryModel());

            WireUpList();
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateEditBookForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                BookModel bookModel = (BookModel)chooseBookComboBox.SelectedItem;
                CategoryModel categoryModel = (CategoryModel)editCategoryComboBox.SelectedItem;
                AuthorModel authorModel = (AuthorModel)editAuthorComboBox.SelectedItem;
                AuthorModel oldAuthor = GlobalConfig.Connection.GetAuthor_ByBook(bookModel);

                BookModel newBook = new BookModel();
                newBook.Id = bookModel.Id;
                newBook.BookName = editBookTitleValue.Text;
                newBook.Pages = int.Parse(editNumberOfPagesValue.Text);
                newBook.Price = int.Parse(editPriceBookValue.Text);
                newBook.Category = categoryModel;
                newBook.Description = editShortDescriptionValue.Text;
                newBook.Photo = ImageToByteArray(uploadPictureBox.Image);

                GlobalConfig.Connection.UpdateBook(newBook, authorModel);

                if (bookModel.Category.Id != categoryModel.Id)
                {
                    GlobalConfig.Connection.UpdateBookCategory(newBook, newBook.Category);
                }

                if (authorModel.Id != oldAuthor.Id)
                {
                    GlobalConfig.Connection.UpdateAuthorBook(newBook, authorModel);
                }

                WireUpList();
            }
        }

        private void WireUpList()
        {
            inForm = false;

            editCategoryComboBox.DataSource = null;
            editCategoryComboBox.DataSource = categories;
            editCategoryComboBox.DisplayMember = "Category";
            editCategoryComboBox.SelectedIndex = 0;

            editAuthorComboBox.DataSource = null;
            editAuthorComboBox.DataSource = authors;
            editAuthorComboBox.DisplayMember = "FullName";
            editAuthorComboBox.SelectedIndex = 0;

            chooseBookComboBox.DataSource = null;
            chooseBookComboBox.DataSource = books;
            chooseBookComboBox.DisplayMember = "BookName";
            chooseBookComboBox.SelectedIndex = 0;

            inForm = true;
        }

        private void chooseBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseBookComboBox.SelectedIndex == 0)
            {
                DisableForm();
            }
            else
            {
                EnableForm();
            }

            if (inForm && chooseBookComboBox.SelectedIndex != 0)
            {
                BookModel b = (BookModel)chooseBookComboBox.SelectedItem;
                b.Category = GlobalConfig.Connection.GetCategory_ByBook(b);
                AuthorModel a = GlobalConfig.Connection.GetAuthor_ByBook(b);

                editBookTitleValue.Text = b.BookName;
                editNumberOfPagesValue.Text = b.Pages.ToString();
                editPriceBookValue.Text = b.Price.ToString();

                editCategoryComboBox.SelectedIndex = editCategoryComboBox.FindString(b.Category.Category);
                editAuthorComboBox.SelectedIndex = editAuthorComboBox.FindString(a.FullName);

                editShortDescriptionValue.Text = b.Description;
                uploadPictureBox.Image = ByteArrayToImage(b.Photo);

                editBookTitleValue.Select();
            }
        }

        private void DisableForm()
        {
            editBookTitleValue.Enabled = false;
            editNumberOfPagesValue.Enabled = false;
            editPriceBookValue.Enabled = false;
            editCategoryComboBox.Enabled = false;
            editAuthorComboBox.Enabled = false;
            editShortDescriptionValue.Enabled = false;
            editPictureButton.Enabled = false;
            editBookButton.Enabled = false;

            editBookTitleValue.Text = "";
            editNumberOfPagesValue.Text = "";
            editPriceBookValue.Text = "";
            editCategoryComboBox.SelectedIndex = 0;
            editAuthorComboBox.SelectedIndex = 0;
            editShortDescriptionValue.Text = "";
            picturePathLabel.Text = "";
            uploadPictureBox.Image = null;
        }

        private void EnableForm()
        {
            editBookTitleValue.Enabled = true;
            editNumberOfPagesValue.Enabled = true;
            editPriceBookValue.Enabled = true;
            editCategoryComboBox.Enabled = true;
            editAuthorComboBox.Enabled = true;
            editShortDescriptionValue.Enabled = true;
            editPictureButton.Enabled = true;
            editBookButton.Enabled = true;
        }

        private Image ByteArrayToImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            Image i = Image.FromStream(ms);
            return i;
        }

        private byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null)
            {
                return null;
            }
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        private void editPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Images only.|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult dr = fileDialog.ShowDialog();

            uploadPictureBox.Image = Image.FromFile(fileDialog.FileName);

            picturePathLabel.Text = fileDialog.FileName;
        }

        private string ValidateEditBookForm()
        {
            string errors = "";

            if (Validations.IfEmptyField(editBookTitleValue.Text) ||
                Validations.IfEmptyField(editNumberOfPagesValue.Text) ||
                Validations.IfEmptyField(editPriceBookValue.Text) ||
                Validations.IfEmptyField(editShortDescriptionValue.Text))
            {
                errors += "All fields must be filled." + Environment.NewLine;
            }
            if (!Validations.IsNumeric(editNumberOfPagesValue.Text))
            {
                errors += "Pages must be in a numeric form." + Environment.NewLine;
            }
            if (!Validations.IsMoney(editPriceBookValue.Text))
            {
                errors += "Price must be in a numeric form." + Environment.NewLine;
            }
            if (editCategoryComboBox.SelectedIndex == 0)
            {
                errors += "Book must have a category." + Environment.NewLine;
            }
            if (editAuthorComboBox.SelectedIndex == 0)
            {
                errors += "Book must have an author." + Environment.NewLine;
            }
            if (Validations.IfEmptyField(editShortDescriptionValue.Text))
            {
                errors += "Book must have a short description" + Environment.NewLine;
            }
            if (uploadPictureBox.Image == null)
            {
                errors += "Book must have an illustration" + Environment.NewLine;
            }

            return errors;
        }
    }
}
