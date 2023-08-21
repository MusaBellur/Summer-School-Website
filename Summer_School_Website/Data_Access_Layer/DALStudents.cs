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

        public static bool StudentDelete(int StudentId)
        {
            SqlCommand cmd2 = new SqlCommand("Delete From Tbl_Students where StuId=@p1", Connection.bgl);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            cmd2.Parameters.AddWithValue("@p1", StudentId);
            return cmd2.ExecuteNonQuery() > 0;

        }

        public static List<EntityStudents> StudentUpdList(int id)
        {
            List<EntityStudents> entityStudents = new List<EntityStudents>();
            SqlCommand cmd3 = new SqlCommand("Select * From Tbl_Students where StuId = @p1", Connection.bgl);
            cmd3.Parameters.AddWithValue("p1", id);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            SqlDataReader dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                EntityStudents ent = new EntityStudents();
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

        public static bool StudentUpdate(EntityStudents stu)
        {
            SqlCommand cmd4 = new SqlCommand("Update Tbl_Students SET stuName=@p1,stuLastName=@p2,stuNumber=@p3,stuPhoto=@p4,stuPassword=@p5 WHERE StuId = @p6;", Connection.bgl);

            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@p1", stu.StuName);
            cmd4.Parameters.AddWithValue("@p2", stu.Lastname);
            cmd4.Parameters.AddWithValue("@p3", stu.Number);
            cmd4.Parameters.AddWithValue("@p4", stu.Photo);
            cmd4.Parameters.AddWithValue("@p5", stu.Password);
            cmd4.Parameters.AddWithValue("@p6", stu.StuId);
            return cmd4.ExecuteNonQuery() > 0;
        }
    }
}
