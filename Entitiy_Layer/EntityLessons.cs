using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityLessons
    {
        private int lesId;
        private string lesName;
        private string min;
        private string max;

        public int LesId 
        {
            get => lesId; set => lesId = value; 
        }
        public string LesName 
        { 
            get => lesName; set => lesName = value; 
        }
        public string Min 
        { 
            get => min; set => min = value; 
        }
        public string Max 
        { 
            get => max; set => max = value; 
        }

    }
}
