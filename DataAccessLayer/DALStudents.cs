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
    internal class DALStudents
    {
        public static int StudentsAdd(EntityStudents paramater) 
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Students (stuName,stuLastName,stuNumber,stuFoto,stuPassword) value (@p1,@p2,@p3,@p4,@p5)", Connection.bgl);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", paramater.StuName);
            cmd.Parameters.AddWithValue("@p2", paramater.Lastname);
            cmd.Parameters.AddWithValue("@p3", paramater.Number);
            cmd.Parameters.AddWithValue("@p4", paramater.Foto);
            cmd.Parameters.AddWithValue("@p5", paramater.Password);
            return cmd.ExecuteNonQuery();
        }
    }
}
