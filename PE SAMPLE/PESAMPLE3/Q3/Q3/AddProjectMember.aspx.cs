using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class AddProjectMember : System.Web.UI.Page
    {
        DataProvider dataProvider = new DataProvider();
       string curentRow;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                dataProvider.GRIDVIEW("select * from Employee", GridView1);
            dataProvider.DROP_DOWN_LIST("select * from Employee", "name", "id", DropDownList1);
            //GridView1.RowCommand += GridView1_RowCommand;
            }
            else
            {
                dataProvider.GRIDVIEW("select * from Employee", GridView1);
                dataProvider.DROP_DOWN_LIST("select * from Employee", "name", "id", DropDownList1);
                //GridView1.RowCommand += GridView1_RowCommand;
            }
        }

        private void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //tbPosition.Text = curentRow;
            //if (e.CommandName.Equals("Select"))
            //{
            //    tbPosition.Text = curentRow;
            //}
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPosition.Text = "change select";
            //GridViewRow abcde = GridView1.SelectedRow;
            //curentRow = abcde.Cells[1].Text;
            //tbPosition.Text = curentRow;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //dataProvider.ADD_UPDATE_DELETE("delete Employee WHERE ");

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
        }
    }
}