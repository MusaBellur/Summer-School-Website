using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALStudents
    {
        public static int StudentsAdd(EntityStudents paramater) 
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Students (stuName,stuLastName,stuNumber,stuPhoto,stuPassword) values (@p1,@p2,@p3,@p4,@p5)", Connection.bgl);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", paramater.StuName);
            cmd.Parameters.AddWithValue("@p2", paramater.Lastname);
            cmd.Parameters.AddWithValue("@p3", paramater.Number);
            cmd.Parameters.AddWithValue("@p4", paramater.Photo);
            cmd.Parameters.AddWithValue("@p5", paramater.Password);
            return cmd.ExecuteNonQuery();
        }
        public static List<EntityStudents> StudentList()
        {
            List<EntityStudents> entityStudents = new List<EntityStudents>();
            SqlCommand cmd1 = new SqlCommand("Select * From Tbl_Students", Connection.bgl);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                EntityStudents ent = new EntityStudents();
                ent.StuId = Convert.ToInt32(dr["StuID"].ToString());
                ent.StuName = dr["StuName"].ToString();
                ent.Lastname = dr["StuLastName"].ToString();
                ent.Number = dr["StuNumber"].ToString();
                ent.Password = dr["StuPassword"].ToString();
                ent.Photo = dr["StuPhoto"].ToString();
                ent.Balance = Convert.ToDecimal(dr["StuBalance"].ToString());
                entityStudents.Add(ent);
            }
            dr.Close();
            return entityStudents;
        }
    }
}
