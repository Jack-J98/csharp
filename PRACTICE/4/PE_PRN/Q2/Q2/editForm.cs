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
    public partial class editForm : Form
    {
        private int memberID;

        public editForm()
        {
            InitializeComponent();
        }

        public editForm(int memberID)
        {
            InitializeComponent();
            this.memberID = memberID;
        }

        private void editForm_Load(object sender, EventArgs e)
        {
            Member member = DataMember.GetMemByID(memberID);
            txtFirstName.Text = member.FirstName;
            txtLastName.Text = member.LastName;
        }
    }
}
