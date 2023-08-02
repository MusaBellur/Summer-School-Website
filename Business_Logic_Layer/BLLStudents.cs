﻿using EntityLayer;
using DataAccessLayer;
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
    }
}