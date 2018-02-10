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

namespace ShopUI.EditForms
{
    public partial class EditCategoryForm : Form
    {
        List<CategoryModel> categories = GlobalConfig.Connection.GetAllCategories();
        bool inForm;

        public EditCategoryForm()
        {
            InitializeComponent();

            categories.Insert(0, new CategoryModel());
            WireUpList();
        }

        private void WireUpList()
        {
            inForm = false;

            chooseCategoryComboBox.DataSource = null;
            chooseCategoryComboBox.DataSource = categories;
            chooseCategoryComboBox.DisplayMember = "Category";
            chooseCategoryComboBox.SelectedIndex = 0;

            inForm = true;
        }

        private void editCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryModel category = (CategoryModel)chooseCategoryComboBox.SelectedItem;
            string errors = ValidateEditCategoryForm(category);

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                if (category.Category == editCategoryValue.Text)
                {
                    WireUpList();
                    return;
                }
                else
                {
                    CategoryModel newCategory = new CategoryModel();
                    newCategory.Id = category.Id;
                    newCategory.Category = editCategoryValue.Text;

                    GlobalConfig.Connection.UpdateCategory(newCategory);

                    foreach (CategoryModel c in categories)
                    {
                        if (c.Category == category.Category)
                        {
                            c.Category = newCategory.Category;
                            break;
                        }
                    }

                    WireUpList();
                }
            }
        }

        private string ValidateEditCategoryForm(CategoryModel category)
        {
            string errors = "";

            if (category.Category == null)
            {
                errors += "You must choose a category to edit" + Environment.NewLine;
                return errors;
            }
            if (Validations.IfEmptyField(editCategoryValue.Text))
            {
                errors += "All fields must be filled" + Environment.NewLine;
            }
            if (Validations.IfFieldLessThanThree(editCategoryValue.Text))
            {
                errors += "Category name must consist at least of 3 characters" + Environment.NewLine;
            }

            return errors;
        }

        private void chooseCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseCategoryComboBox.SelectedIndex == 0)
            {
                editCategoryButton.Enabled = false;
                editCategoryValue.Enabled = false;
                editCategoryValue.Text = "";
            }
            else
            {
                editCategoryButton.Enabled = true;
                editCategoryValue.Enabled = true;
            }

            if (inForm && chooseCategoryComboBox.SelectedIndex != 0)
            {
                CategoryModel category = (CategoryModel)chooseCategoryComboBox.SelectedItem;
                editCategoryValue.Text = category.Category;
                editCategoryValue.Select();
            }
        }
    }
}
