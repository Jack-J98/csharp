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
    public partial class Form1 : Form
    {
        Button btnAdd = new Button();
        
        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dtGridView.Columns.Clear();
            dtGridView.DataSource = Category.getAllCategories();
            btnAdd.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dtGridView.Columns.Clear();
            dtGridView.DataSource = Supplier.GetAllSupplier();
            btnAdd.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            loadProduct();

        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dtGridView.Columns.Clear();
            dtGridView.DataSource = Order.getAllOrder();
            btnAdd.Visible = false;
        }

        //------------------------------------------------------------------------------------------------------
        public void loadProduct()
        {
            dtGridView.Columns.Clear();
            dtGridView.DataSource = Product.getAllProduct();

            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "editColumn";
            editCol.Text = "Edit";
            editCol.UseColumnTextForButtonValue = true;
            dtGridView.Columns.Add(editCol);

            DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
            delCol.Name = "deleteColumn";
            delCol.Text = "Delete";
            delCol.UseColumnTextForButtonValue = true;
            dtGridView.Columns.Add(delCol);

            btnAdd.Text = "Add Product";
            btnAdd.Visible = true;
            btnAdd.Location = new Point(20, 600);
            btnAdd.Size = new Size(112, 32);
            this.Controls.Add(btnAdd);
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddEdit myFormEdit = new FormAddEdit();
            myFormEdit.FormClosed += MyFormEdit_FormClosed;
            myFormEdit.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            loadProduct();
        }
        //------------------------------------------------------------------------------------------------------

        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGridView.Columns[e.ColumnIndex].Name == "deleteColumn")
            {
                int ProductID = Convert.ToInt32(dtGridView.Rows[e.RowIndex].Cells[0].Value);
                DialogResult result = MessageBox.Show("Do you want to Delete?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int count = Product.DeleteProductByID(ProductID);
                    MessageBox.Show(count.ToString() + " Products were Deleted!");
                    loadProduct();
                }
            }
            if (dtGridView.Columns[e.ColumnIndex].Name == "editColumn")
            {
                int ProductID = Convert.ToInt32(dtGridView.Rows[e.RowIndex].Cells[0].Value);
                FormAddEdit myFormEdit = new FormAddEdit(ProductID);
                myFormEdit.FormClosed += MyFormEdit_FormClosed;
                myFormEdit.Show();
            }
        }

        private void MyFormEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadProduct();
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
