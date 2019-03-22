using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lap2WinForm
{
    public partial class FormAddEdit : Form
    {
        int CurrentProductID = -1;
        bool DisContinue = true;
        public FormAddEdit()
        {
            InitializeComponent();
        }
        public FormAddEdit(int p)
        {
            InitializeComponent();
            CurrentProductID = p;
        }

        public void loadCBox()
        {
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DataSource = Category.getAllCategories();

            cbSupplier.DisplayMember = "CompanyName";
            cbSupplier.ValueMember = "SupplierID";
            cbSupplier.DataSource = Supplier.GetAllSupplier();
        }
        private void EditProduct_Load(object sender, EventArgs e)
        {
            if (CurrentProductID != -1)
            {
                this.Text = "Edit Product";
                btnAddEdit.Text = "Edit Product";
                loadProductEdit();
            }
            else
            {
                loadCBox();
                this.Text = "Add Product";
                btnAddEdit.Text = "Add Product";

            }

        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (btnAddEdit.Text == "Edit Product")
            {
                editProduct();
            }
            if(btnAddEdit.Text == "Add Product")
            {
                addProduct();
            }
        }

        private void rdYes_CheckedChanged(object sender, EventArgs e)
        {
            DisContinue = true;
        }

        private void rdNo_CheckedChanged(object sender, EventArgs e)
        {
            DisContinue = false;
        }

        public void loadProductEdit()
        {
            Product myProduct = Product.GetProductByID(CurrentProductID);
            tbProductID.Text = myProduct.ProductID.ToString();
            tbProductName.Text = myProduct.ProductName;

            tbPrice.Text = myProduct.UnitPrice.ToString();
            loadCBox();
            cbCategory.Text = myProduct.CategoryName;
            cbSupplier.Text = myProduct.CompanyName;


            if (myProduct.Discontinued)
            {
                rdYes.Checked = true;
            }
            else
            {
                rdNo.Checked = true;
            }
        }

        public void editProduct()
        {
            bool checkName = false;
            bool checkPrice = false;
            string productName = "";
            double price = 0;
            if (tbProductName.Text != "")
            {
                productName = tbProductName.Text;
                checkName = true;
            }
            else
            {
                checkName = false;
                MessageBox.Show("Please enter Product Name");

            }
            int subId = Convert.ToInt32(cbSupplier.SelectedValue);
            int catID = Convert.ToInt32(cbCategory.SelectedValue);
            if (tbPrice.Text != "")
            {
                try
                {
                    price = Convert.ToDouble(tbPrice.Text.Trim());
                    if(price < 0)
                    {
                        MessageBox.Show("Price must be Positive");
                        checkPrice = false;
                    }
                    else
                    {
                        checkPrice = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unit Price must be a number");
                    tbPrice.Text = "";
                    checkPrice = false;
                }

            }
            else
            {
                checkPrice = false;
                MessageBox.Show("Please Enter Unit Price");

            }
            if (checkName == true && checkPrice == true)
            {
                DialogResult result = MessageBox.Show("Do you want to Edit?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Product.EditProduct(CurrentProductID, productName, subId, catID, price, DisContinue);
                    Close();
                }

            }
        }
        public void addProduct()
        {
            bool checkName = false;
            bool checkPrice = false;
            string productName = "";
            double price = 0;
            if (tbProductName.Text != "")
            {
                productName = tbProductName.Text;
                checkName = true;
            }
            else
            {
                checkName = false;
                MessageBox.Show("Please enter Product Name");

            }
            int subId = Convert.ToInt32(cbSupplier.SelectedValue);
            int catID = Convert.ToInt32(cbCategory.SelectedValue);
            if (tbPrice.Text != "")
            {
                try
                {
                    price = Convert.ToDouble(tbPrice.Text.Trim());
                    if (price < 0)
                    {
                        MessageBox.Show("Price must be Positive");
                        checkPrice = false;
                    }
                    else
                    {
                        checkPrice = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unit Price must be a number");
                    tbPrice.Text = "";
                    checkPrice = false;
                }

            }
            else
            {
                checkPrice = false;
                MessageBox.Show("Please Enter Unit Price");

            }
            if (checkName == true && checkPrice == true)
            {
                DialogResult result = MessageBox.Show("Do you want to Add?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Product.AddProduct(productName, subId, catID, price, DisContinue);
                    Close();
                }

            }

        }
    }
}
