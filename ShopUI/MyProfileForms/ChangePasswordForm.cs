using ShopLibrary;
using ShopLibrary.Models;
using ShopLibrary.ValidationsAndHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI.ProfileForms
{
    public partial class ChangePasswordForm : Form
    {
        public PersonModel p = new PersonModel();

        public ChangePasswordForm(PersonModel personModel)
        {
            InitializeComponent();
            p = personModel;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateNewPasswordForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                p.Password = enterNewPasswordValue.Text;

                this.Close();
            }
        }

        private string ValidateNewPasswordForm()
        {
            string errors = "";

            if (Validations.IfEmptyField(enterNewPasswordValue.Text) ||
                Validations.IfEmptyField(repeatNewPasswordValue.Text) ||
                Validations.IfEmptyField(enterOldPasswordValue.Text) ||
                Validations.IfEmptyField(repeatOldPasswordValue.Text))
            {
                errors += "All fields must be filled." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanFour(enterNewPasswordValue.Text))
            {
                errors += "New Password should contain at least 4 characters." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanFour(enterOldPasswordValue.Text))
            {
                errors += "Old Password should contain at least 4 characters." + Environment.NewLine;
            }
            if (Validations.IfPasswordsDoesntMatch(enterNewPasswordValue.Text, repeatNewPasswordValue.Text))
            {
                errors += "Repeat of new password must be identical to the enter of new password." + Environment.NewLine;
            }
            if (Validations.IfPasswordsDoesntMatch(enterOldPasswordValue.Text, repeatOldPasswordValue.Text))
            {
                errors += "Repeat of old password must be identical to the enter of old password." + Environment.NewLine;
            }
            if (!Validations.IfPasswordsDoesntMatch(enterNewPasswordValue.Text, enterOldPasswordValue.Text))
            {
                errors += "The new  password must differ from the old one." + Environment.NewLine;
            }

            return errors;
        }
    }
}
