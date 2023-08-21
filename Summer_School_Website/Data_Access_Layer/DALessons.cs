using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class DALessons
    {
        public static List<EntityLessons> LessonsList()
        {
            List<EntityLessons> entityLessons = new List<EntityLessons>();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Lessons", Connection.bgl);
            if(cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                EntityLessons ent = new EntityLessons();
                ent.LesId = Convert.ToInt32(dr["LesID"].ToString());
                ent.LesName = dr["LesName"].ToString();
                ent.Min = dr["LesMinQuota"].ToString();
                ent.Max = dr["LesMaxQuota"].ToString();
                entityLessons.Add(ent);
            }
            dr.Close();
            return entityLessons;
        }
        public static int Demand(EntityAppForm p)
        {
            SqlCommand cmd1 = new SqlCommand("insert into Tbl_AppForms (StuId,LesId) values (@p1,@p2)", Connection.bgl);
            cmd1.Parameters.AddWithValue("@p1", p.AppStuId);
            cmd1.Parameters.AddWithValue("@p2", p.AppLesId);
            if(cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            return cmd1.ExecuteNonQuery();
        }
    }
}
