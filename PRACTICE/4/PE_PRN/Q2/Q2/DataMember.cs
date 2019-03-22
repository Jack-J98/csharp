using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Q2
{
    public class DataMember
    {
        public static DataTable GetAllMembers()
        {
            string sql = @"SELECT [member_no],[lastname],[firstname], firstname +' ' + lastname as Name FROM [dbo].[member]";
            return DataAccess.GetTableBySql(sql);
        }
        static public DataRow GetMemberByID(int MemID)
        {
            string sql = "SELECT [member_no],[lastname],[firstname], firstname +' ' + lastname as Name FROM [dbo].[member] where member_no = " + MemID;
            return DataAccess.GetTableBySql(sql).Rows[0];
        }

        public static List<Member> GetMembers()
        {
            DataTable dt = new DataTable();
            List<Member> memList = new List<Member>();
            dt = GetAllMembers();
            foreach (DataRow dr in dt.Rows)
            {
                memList.Add(new Member(
                    Convert.ToInt32(dr["member_no"]),
                    dr["lastname"].ToString(),
                    dr["firstname"].ToString(),
                    dr["Name"].ToString()
                    ));
            }

            return memList;
        }
        public static Member GetMemByID(int MemID)
        {
            DataRow dr = GetMemberByID(MemID);
            return new Member(
                Convert.ToInt32(dr["member_no"]),
                dr["lastname"].ToString(),
                dr["firstname"].ToString(),
                dr["Name"].ToString()
                );
        }
    }
}
