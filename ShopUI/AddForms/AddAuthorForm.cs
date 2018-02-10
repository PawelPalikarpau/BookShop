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
    public partial class AddAuthorForm : Form
    {
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateAddAuthorForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                List<AuthorModel> m = GlobalConfig.Connection.GetAuthor_ByName(authorsFirstNameValue.Text, authorsLastNameValue.Text);

                if (m.Count < 1)
                {
                    AuthorModel model = new AuthorModel();
                    model.FirstName = authorsFirstNameValue.Text;
                    model.LastName = authorsLastNameValue.Text;
                    model.Photo = ImageToByteArray(authorsPhotoBox.Image);

                    GlobalConfig.Connection.CreateAuthor(model);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Author with this first and last name already exists.");
                    return;
                }
            }
        }

        private string ValidateAddAuthorForm()
        {
            string errors = "";

            if (Validations.IfEmptyField(authorsFirstNameValue.Text) || Validations.IfEmptyField(authorsLastNameValue.Text))
            {
                errors += "All fields must be filled." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(authorsFirstNameValue.Text))
            {
                errors += "First Name must be at least of 3 characters." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(authorsLastNameValue.Text))
            {
                errors += "Last Name must be at least of 3 characters." + Environment.NewLine;
            }
            if (authorsPhotoBox.Image == null)
            {
                errors += "You must to add photo to author." + Environment.NewLine;
            }

            return errors;
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Images only.|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult dr = fileDialog.ShowDialog();

            authorsPhotoBox.Image = Image.FromFile(fileDialog.FileName);

            photosPathLabel.Text = fileDialog.FileName;
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
