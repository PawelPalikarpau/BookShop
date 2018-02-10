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

namespace ShopUI.ProfileForms
{
    public partial class ChangeProfileForm : Form
    {
        public PersonModel p = new PersonModel();

        public ChangeProfileForm(PersonModel personModel)
        {
            InitializeComponent();

            p = personModel;
            firstNameValue.Text = p.FirstName;
            lastNameValue.Text = p.LastName;
            phoneNumberValue.Text = p.PhoneNumber;
            photoBox.Image = ByteArrayToImage(p.Photo);
        }

        private string ValidateChangeProfileForm()
        {
            string errors = "";

            if (Validations.IfEmptyField(firstNameValue.Text) ||
                Validations.IfEmptyField(lastNameValue.Text) ||
                Validations.IfEmptyField(phoneNumberValue.Text))
            {
                errors += "All fields must be filled" + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(firstNameValue.Text))
            {
                errors += "First Name must be at least of 3 characters." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(lastNameValue.Text))
            {
                errors += "Last Name must be at least of 3 characters." + Environment.NewLine;
            }
            if (!Validations.IsNumeric(phoneNumberValue.Text))
            {
                errors += "Phone Number must consist of numbers" + Environment.NewLine;
            }

            return errors;
        }

        private void changePhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Images only.|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult dr = fileDialog.ShowDialog();

            photoBox.Image = Image.FromFile(fileDialog.FileName);

            photoPathLabel.Text = fileDialog.FileName;
        }

        private void changeProfileButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateChangeProfileForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.PhoneNumber = phoneNumberValue.Text;
                p.Photo = ImageToByteArray(photoBox.Image);
                
                this.Close();
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
