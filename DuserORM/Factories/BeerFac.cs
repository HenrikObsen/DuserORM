using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Duser;
using System.Data.SqlClient;

namespace DuserORM
{
    public class BeerFac: AutoFac<Beer>
    {
        string sql = "SELECT B.ID, B.Name, C.Name AS CategoryName FROM Beer AS B INNER JOIN Category as C ON B.CategoryID = C.ID ORDER BY C.Name";
           
        public List<JoinVM> GetAllBeersWithCategories1()
        {
             return ExecuteSQL<JoinVM>(sql);
        }

        public List<JoinVM> GetAllBeersWithCategories2()
        {
            using(SqlCommand cmd = new SqlCommand(sql,Conn.CreateConnection()))
            {
                Mapper<JoinVM> m = new Mapper<JoinVM>();
                List<JoinVM> list = m.MapList(cmd.ExecuteReader());
                cmd.Connection.Close();
                return list;
            }          
        }
    }
}