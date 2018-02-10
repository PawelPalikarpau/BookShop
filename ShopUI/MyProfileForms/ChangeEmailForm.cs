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
    public partial class ChangeEmailForm : Form
    {
        public PersonModel p = new PersonModel();

        public ChangeEmailForm(PersonModel pm)
        {
            InitializeComponent();
            p = pm;
            enterEmailValue.Text = p.EmailAddress;
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateNewEmailForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                List<PersonModel> models = GlobalConfig.Connection.GetAllPersons_ByEmail(enterEmailValue.Text);
                if (models.Count > 0)
                {
                    MessageBox.Show("User with such email already exist. Please try again.");
                    return;
                }
                else
                { 
                    p.EmailAddress = enterEmailValue.Text;

                    this.Close();                    
                }
            }
        }

        private string ValidateNewEmailForm()
        {
            string errors = "";

            if (Validations.IfEmptyField(enterEmailValue.Text) ||
                Validations.IfEmptyField(enterEmailValue.Text) ||
                Validations.IfEmptyField(repeatPasswordValue.Text))
            {
                errors += "All fields must be filled" + Environment.NewLine;
            }
            if (!Validations.IsValidEmail(enterEmailValue.Text))
            {
                errors += "Email addres is not in correct form." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanFour(enterPasswordrValue.Text))
            {
                errors = "Password should contain at least 4 characters." + Environment.NewLine;
            }
            if (Validations.IfPasswordsDoesntMatch(enterPasswordrValue.Text, repeatPasswordValue.Text))
            {
                errors += "Repeat password must be identical to the password." + Environment.NewLine;
            }

            return errors;
        }
    }
}
