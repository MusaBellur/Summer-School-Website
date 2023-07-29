using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityTeachers
    {
        private int teacherId;
        private string teacherName;
        private string branch;

        public int TeacherId { get => teacherId; set => teacherId = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public string Branch { get => branch; set => branch = value; }
        
    }
}
