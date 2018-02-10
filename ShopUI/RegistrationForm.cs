using ShopLibrary;
using ShopLibrary.DataAccess;
using ShopLibrary.Models;
using ShopLibrary.ValidationsAndHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI
{
    public partial class RegistrationForm : Form
    {
        public object DataTime { get; private set; }

        public RegistrationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateRegistrationForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                List<PersonModel> models = new List<PersonModel>();
                models = GlobalConfig.Connection.GetAllPersons_ByEmail(emailAddressValue.Text);

                if (models.Count > 0)
                {
                    MessageBox.Show("User with such email already exist. Please try again.");
                    return;
                }
                else
                {
                    PersonModel pm = new PersonModel();
                    List<PersonModel> allPersons = GlobalConfig.Connection.GetAllPersons();

                    string unicueCode = "";
                    int i = 0;
                    do
                    {
                        unicueCode = Helpers.RandomString();

                        foreach (PersonModel person in allPersons)
                        {
                            if (person.UniqueCode == unicueCode)
                            {
                                i++;
                            }
                        }

                    } while (i > 1);

                    pm.UniqueCode = unicueCode;
                    pm.FirstName = firstNameValue.Text;
                    pm.LastName = lastNameValue.Text;
                    pm.Password = enterPasswordValue.Text;
                    pm.EmailAddress = emailAddressValue.Text;
                    pm.PhoneNumber = phoneNumberValue.Text;
                    pm.Photo = ImageToByteArray(uploadedPictureBox.Image);
                    pm.RegistrationDate = DateTime.Now;

                    //GlobalConfig.Connection.CreatePerson(pm);

                    GlobalConfig.FileConnection.CreatePerson(pm);

                    MessageBox.Show("Registration was successful");

                    this.Close();
                }
            }
        }

        private string ValidateRegistrationForm()
        {
            string errors = "";

            if(Validations.IfEmptyField(firstNameValue.Text) ||
                Validations.IfEmptyField(lastNameValue.Text) ||
                Validations.IfEmptyField(enterPasswordValue.Text) ||
                Validations.IfEmptyField(repeatPasswordValue.Text) ||
                Validations.IfEmptyField(emailAddressValue.Text) ||
                Validations.IfEmptyField(phoneNumberValue.Text))
            {
                errors += "All fields must be filled." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(firstNameValue.Text))
            {
                errors += "First Name must be at least of 3 characters." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(lastNameValue.Text))
            {
                errors += "Last Name must be at least of 3 characters." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanFour(enterPasswordValue.Text))
            {
                errors += "Password should contain at least 4 characters." + Environment.NewLine;
            }
            if (Validations.IfPasswordsDoesntMatch(enterPasswordValue.Text, repeatPasswordValue.Text))
            {
                errors += "Repeat password must be identical to the password." + Environment.NewLine;
            }
            if (!Validations.IsValidEmail(emailAddressValue.Text))
            {
                errors += "Email addres is not in correct form." + Environment.NewLine;
            }
            if (!Validations.IsNumeric(phoneNumberValue.Text))
            {
                errors += "Phone Number must consist of numbers" + Environment.NewLine;
            }

            return errors;
        }

        private void uploadedPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Images only.|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult dr = fileDialog.ShowDialog();

            uploadedPictureBox.Image = Image.FromFile(fileDialog.FileName);

            uploadPicturePathLabel.Text = fileDialog.FileName;
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
