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
    public partial class EditAuthorForm : Form
    {
        List<AuthorModel> authors = GlobalConfig.Connection.GetAllAuthors();
        bool inForm;

        public EditAuthorForm()
        {

            InitializeComponent();

            authors.Insert(0, new AuthorModel());

            WireUpList();
        }

        private void WireUpList()
        {
            inForm = false;

            chooseAuthorComboBox.DataSource = null;
            chooseAuthorComboBox.DataSource = authors;
            chooseAuthorComboBox.DisplayMember = "FullName";
            chooseAuthorComboBox.SelectedIndex = 0;

            inForm = true;
        }

        private void editAuthorButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateEditAuthorForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                AuthorModel a = (AuthorModel)chooseAuthorComboBox.SelectedItem;                

                if (editAuthorsFirstNameValue.Text == a.FirstName &&
                    editAuthorsLastNameValue.Text == a.LastName &&
                    authorsPhotoBox.Image == ByteArrayToImage(a.Photo))
                {
                    editAuthorsFirstNameValue.Text = "";
                    editAuthorsLastNameValue.Text = "";
                    authorsPhotoBox.Image = null;

                    WireUpList();

                    return;
                }
                else
                {
                    AuthorModel newAuthor = new AuthorModel();
                    newAuthor.Id = a.Id;
                    newAuthor.FirstName = editAuthorsFirstNameValue.Text;
                    newAuthor.LastName = editAuthorsLastNameValue.Text;
                    newAuthor.Photo = ImageToByteArray(authorsPhotoBox.Image);

                    GlobalConfig.Connection.UpdateAuthor(newAuthor);

                    foreach (AuthorModel aa in authors)
                    {
                        if (aa.Id == newAuthor.Id)
                        {
                            aa.FirstName = newAuthor.FirstName;
                            aa.LastName = newAuthor.LastName;
                            aa.Photo = newAuthor.Photo;
                            break;
                        }
                    }

                    WireUpList();
                }
            }
        }

        private string ValidateEditAuthorForm()
        {
            string errors = "";

            if (Validations.IfEmptyField(editAuthorsFirstNameValue.Text) || Validations.IfEmptyField(editAuthorsLastNameValue.Text))
            {
                errors += "All fields must be filled." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(editAuthorsFirstNameValue.Text))
            {
                errors += "First Name must be at least of 3 characters." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(editAuthorsLastNameValue.Text))
            {
                errors += "Last Name must be at least of 3 characters." + Environment.NewLine;
            }
            if (authorsPhotoBox.Image == null)
            {
                errors += "You must to add photo to author." + Environment.NewLine;
            }

            return errors;
        }

        private void editPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Images only.|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult dr = fileDialog.ShowDialog();

            authorsPhotoBox.Image = Image.FromFile(fileDialog.FileName);

            photoPathLabel.Text = fileDialog.FileName;
        }

        private void chooseAuthorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AuthorModel a = (AuthorModel)chooseAuthorComboBox.SelectedItem;

            if (chooseAuthorComboBox.SelectedIndex == 0)
            {
                editAuthorsFirstNameValue.Enabled = false;
                editAuthorsLastNameValue.Enabled = false;
                editPhotoButton.Enabled = false;
                editAuthorButton.Enabled = false;

                editAuthorsFirstNameValue.Text = "";
                editAuthorsLastNameValue.Text = "";
                authorsPhotoBox.Image = null;
            }
            else
            {
                editAuthorsFirstNameValue.Enabled = true;
                editAuthorsLastNameValue.Enabled = true;
                editPhotoButton.Enabled = true;
                editAuthorButton.Enabled = true;
            }

            if (inForm && chooseAuthorComboBox.SelectedIndex != 0)
            {
                editAuthorsFirstNameValue.Text = a.FirstName;
                editAuthorsLastNameValue.Text = a.LastName;
                authorsPhotoBox.Image = ByteArrayToImage(a.Photo);

                editAuthorsFirstNameValue.Select();
            }
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
    }
}
