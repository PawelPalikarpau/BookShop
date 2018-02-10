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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopUI
{
    public partial class LoginForm : Form
    {
        public PersonModel model { get; set; }
        private MainForm parent;

        public LoginForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.StartPosition = FormStartPosition.CenterParent;
            parent.DisableParentMenu();

            this.DialogResult = DialogResult.Cancel;
            loginButton.DialogResult = DialogResult.OK;

            this.FormClosing += new FormClosingEventHandler(loginForm_Closing);

            enterPasswordValue.Text = "qwer";
            emailAddressValue.Text = "pawel@gmail.com";
        }

        private void loginForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void registrateButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.FormClosed += new FormClosedEventHandler(registrationForm_FormClosed);
            this.Enabled = false;
            registrationForm.StartPosition = FormStartPosition.CenterParent;
            registrationForm.Show();
        }

        void registrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Enabled = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateLoginForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                List<PersonModel> models = GlobalConfig.Connection.GetAllPersons_ByEmail(emailAddressValue.Text);

                if (models.Count < 1)
                {
                    MessageBox.Show("There is no user with such email. Please try again.");
                    return;
                }
                else
                {
                    if (enterPasswordValue.Text != models[0].Password)
                    {
                        MessageBox.Show("The password is inccorect. Please try again.");
                        return;
                    }
                    else if (enterPasswordValue.Text == models[0].Password)
                    {
                        parent.personModel = models[0];

                        if (parent.Log == null)
                        {
                            parent.Log = new LogModel();
                        }

                        parent.Log.PersonId = parent.personModel.Id;
                        parent.Log.FirstName = parent.personModel.FirstName;
                        parent.Log.LastName = parent.personModel.LastName;
                        parent.Log.LogIn = DateTime.Now;

                        parent.EnableParentMenu();
                        this.Close();
                    }
                }
            }
        }

        private string ValidateLoginForm()
        {
            string errors = "";

            if (Validations.IfEmptyField(emailAddressValue.Text) || Validations.IfEmptyField(enterPasswordValue.Text))
            {
                errors += "All fields must be filled." + Environment.NewLine;
            }
            if (!Validations.IsValidEmail(emailAddressValue.Text))
            {
                errors += "Email addres is not in correct form." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanFour(enterPasswordValue.Text))
            {
                errors += "Password should contain at least 4 characters." + Environment.NewLine;
            }

            return errors;
        }
    }
}
