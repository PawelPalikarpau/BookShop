using ShopLibrary;
using ShopLibrary.Models;
using ShopLibrary.ValidationsAndHelpers;
using ShopUI.ProfileForms;
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

namespace ShopUI
{
    public partial class MyProfileForm : Form
    {
        public PersonModel pm { get; set; }
        private MainForm parent;

        public MyProfileForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            pm = this.parent.personModel;
            UpdateUserData();
            parent.DisableParentMenu();
            this.FormClosing += new FormClosingEventHandler(MyProfileForm_FormClosing);
        }

        private void MyProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalConfig.Connection.UpdatePerson(pm);
            GlobalConfig.FileConnection.CreatePerson(pm);
            parent.EnableParentMenu();
        }

        private void UpdateUserData()
        {
            firstNameValue.Text = pm.FirstName;
            lastNameValue.Text = pm.LastName;
            emailValue.Text = pm.EmailAddress;
            phoneNumberValue.Text = pm.PhoneNumber;
            passwordValue.Text = pm.Password;
            registrationDateValue.Text = pm.RegistrationDate.ToShortDateString();
            photoBox.Image = ByteArrayToImage(pm.Photo);
        }

        private Image ByteArrayToImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            Image i = Image.FromStream(ms);
            return i;
        }

        private void changeProfileButton_Click(object sender, EventArgs e)
        {
            ChangeProfileForm newForm = new ChangeProfileForm(pm);
            newForm.ShowDialog();

            pm = newForm.p;

            UpdateUserData();
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            ChangeEmailForm newForm = new ChangeEmailForm(pm);
            newForm.ShowDialog();

            pm = newForm.p;

            UpdateUserData();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm newForm = new ChangePasswordForm(pm);
            newForm.ShowDialog();

            pm = newForm.p;

            UpdateUserData();
        }
    }
}
