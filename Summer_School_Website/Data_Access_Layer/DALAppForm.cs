using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class DALAppForm
    {
        public static List<EntityAppForm> AppList()
        {
            List<EntityAppForm> entityLessons = new List<EntityAppForm>();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_AppForm", Connection.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityAppForm ent = new EntityAppForm();
                ent.AppId = Convert.ToInt32(dr["AppID"].ToString());
                ent.AppLesId = Convert.ToInt32(dr["LesID"].ToString());
                ent.AppStuId = Convert.ToInt32(dr["StuID"].ToString());
                entityLessons.Add(ent);
            }
            dr.Close();
            return entityLessons;
        }
    }
}
