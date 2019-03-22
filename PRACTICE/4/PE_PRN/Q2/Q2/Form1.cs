using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "Select";
            dataGridView1.Columns.Add(checkCol);

            dataGridView1.DataSource = DataMember.GetAllMembers();

            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "editcol";
            editCol.Text = "Edit";
            editCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editCol);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "editcol")
            {
                int memberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                editForm editForm = new editForm(memberID);
                editForm.Show();
            }
        }
    }
}
