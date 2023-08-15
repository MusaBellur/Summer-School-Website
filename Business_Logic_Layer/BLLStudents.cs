using EntityLayer;
using DataAccessLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class BLLStudents
    {
        public static int AddStudentBLL(EntityStudents p)
        {
            if (p.StuName != null && p.Lastname != null && p.Number != null && p.Password != null && p.Photo != null)
            {
                return DALStudents.StudentsAdd(p);
            }
            return -1;
        }
        public static List<EntityStudents> BllList()
        {
            return DALStudents.StudentList();
        }
        public static bool DelStudentBLL(int id)
        {
            if(id != null)
            {
                return DALStudents.StudentDelete(id);
            }
            return false;
        }
        public static List<EntityStudents> BllUpdList(int p)
        {
            return DALStudents.StudentUpdList(p);
        }
        public static bool BllUpdate(EntityStudents p)
        {
            if (p.StuId > 0 && p.StuName != null && p.Lastname != null && p.Number != null && p.Password != null && p.Photo != null)
            {
                return DALStudents.StudentUpdate(p);
            }
            return false;
        }
    }
}