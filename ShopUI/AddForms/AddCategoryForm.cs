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

namespace ShopUI.AddForms
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            string errors = ValidateAddCategoryForm();

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                List<CategoryModel> categories = GlobalConfig.Connection.GetCategories_ByName(addNewCategoryValue.Text);

                if (categories.Count > 0)
                {
                    MessageBox.Show("Such category already exists.");
                    return;
                }
                else
                {
                    GlobalConfig.Connection.CreateCategory(addNewCategoryValue.Text);
                    this.Close();
                }
            }
        }

        private string ValidateAddCategoryForm()
        {
            string errors = "";

            if (Validations.IfEmptyField(addNewCategoryValue.Text))
            {
                errors += "Fild must be filled." + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(addNewCategoryValue.Text))
            {
                errors += "Field should contain at least 3 characters." + Environment.NewLine;
            }

            return errors;
        }
    }
}
