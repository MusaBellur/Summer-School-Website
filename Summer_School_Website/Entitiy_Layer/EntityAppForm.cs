using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAppForm
    {
        private int appId;
        private int appStuId;
        private int appLesId;

        public int AppId 
        { 
            get => appId; set => appId = value; 
        }
        public int AppStuId 
        {
            get => appStuId; set => appStuId = value; 
        }
        public int AppLesId 
        { 
            get => appLesId; set => appLesId = value; 
        }
    }
}
