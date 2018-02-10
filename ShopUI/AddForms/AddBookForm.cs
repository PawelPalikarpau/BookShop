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

namespace ShopUI.AddForms
{
    public partial class AddBookForm : Form
    {
        List<CategoryModel> categories = GlobalConfig.Connection.GetAllCategories();
        List<AuthorModel> authors = GlobalConfig.Connection.GetAllAuthors();

        public AddBookForm()
        {
            InitializeComponent();

            categories.Insert(0, new CategoryModel());
            authors.Insert(0, new AuthorModel());
            
            WireUpList();
        }

        private void WireUpList()
        {
            categoryComboBox.DataSource = null;
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Category";
            
            authorComboBox.DataSource = null;
            authorComboBox.DataSource = authors;
            authorComboBox.DisplayMember = "FullName";
        }

        private void createBookButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateAddBookForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                List<BookModel> list = GlobalConfig.Connection.GetBookByName(bookTitleValue.Text);
                if (list.Count > 0)
                {
                    MessageBox.Show("Book with this Title already exists");
                    return;
                }
                else
                {
                    BookModel bookModel = new BookModel();
                    AuthorModel authorModel = (AuthorModel)authorComboBox.SelectedItem;
                    CategoryModel categoryModel = (CategoryModel)categoryComboBox.SelectedItem;

                    bookModel.BookName = bookTitleValue.Text;
                    bookModel.Pages = int.Parse(numberOfPagesValue.Text);
                    bookModel.Price = decimal.Parse(priceBookValue.Text);
                    bookModel.Description = shortDescriptionValue.Text;
                    bookModel.Photo = ImageToByteArray(uploadPictureBox.Image);

                    bookModel.Id = GlobalConfig.Connection.CreateBook(bookModel).Id;

                    GlobalConfig.Connection.InsertBookCategory(bookModel, categoryModel);
                    GlobalConfig.Connection.InsertAuthorBook(bookModel, authorModel);

                    this.Close();
                }
            }
        }

        private string ValidateAddBookForm()
        {
            CategoryModel tempCat = (CategoryModel)categoryComboBox.SelectedItem;
            AuthorModel tempAut = (AuthorModel)authorComboBox.SelectedItem;

            string errors = "";

            if (Validations.IfEmptyField(bookTitleValue.Text) ||
                Validations.IfEmptyField(numberOfPagesValue.Text) ||
                Validations.IfEmptyField(priceBookValue.Text))
            {
                errors += "All fields must be filled." + Environment.NewLine;
            }
            if (!Validations.IsNumeric(numberOfPagesValue.Text))
            {
                errors += "Pages must be in a numeric form." + Environment.NewLine;
            }
            if (!Validations.IsMoney(priceBookValue.Text))
            {
                errors += "Price must be in a numeric form." + Environment.NewLine;
            }
            if (tempCat.Category == null)
            {
                errors += "Book must have a category." + Environment.NewLine;
            }
            if (tempAut.FirstName == null)
            {
                errors += "Book must have an author." + Environment.NewLine;
            }
            if (Validations.IfEmptyField(shortDescriptionValue.Text))
            {
                errors += "Book must have a short description" + Environment.NewLine;
            }
            if (uploadPictureBox.Image == null)
            {
                errors += "Book must have an illustration" + Environment.NewLine;
            }

            return errors;
        }

        private void uploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Images only.|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult dr = fileDialog.ShowDialog();

            uploadPictureBox.Image = Image.FromFile(fileDialog.FileName);

            picturePathLabel.Text = fileDialog.FileName;
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

        private void addCategoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCategoryForm newForm = new AddCategoryForm();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();

            categories = GlobalConfig.Connection.GetAllCategories();
            categories.Insert(0, new CategoryModel());
            WireUpList();
        }

        private void addAuthorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddAuthorForm newForm = new AddAuthorForm();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();

            authors = GlobalConfig.Connection.GetAllAuthors();
            authors.Insert(0, new AuthorModel());
            WireUpList();
        }
    }
}
