using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLessons
    {
        public static List<EntityLessons> BLLesList()
        {
            return DALessons.LessonsList();
        }
        public static int BLLAddDemand(EntityAppForm p)
        {
            if(p.AppStuId != null && p.AppLesId != null)
            {
                return DALessons.Demand(p);
            }
            return -1;
        }
    }
}
