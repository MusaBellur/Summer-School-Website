using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLAppForm
    {
        public static List<EntityAppForm> BLLApp() 
        {
            return DALAppForm.AppList();
        }
    }
}
