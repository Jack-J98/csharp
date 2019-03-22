using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Lap2WinForm
{
    class Category
    {   
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Category(int CategoryID, string CategoryName, string Description)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.Description = Description;
        }
        public static List<Category> getAllCategories()
        {
            DataTable dt = new DataTable();
            List<Category> cateList = new List<Category>();
            dt = DataAccess.getAllCategory();
            foreach (DataRow dr in dt.Rows)
            {
                cateList.Add(new Category(
                    Convert.ToInt32(dr["CategoryID"]),
                    dr["CategoryName"].ToString(),
                    dr["Description"].ToString()
                ));
            }
            return cateList;
        }
    }
}
