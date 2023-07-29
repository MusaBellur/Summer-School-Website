namespace EntityLayer
{
    public class EntityStudents
    {
        private int stuId;
        private string stuName;
        private string lastname;
        private string number;
        private string picture;
        private decimal balance;

        public int StuId 
        { 
            get => stuId; set => stuId = value; 
        }
        public string StuName 
        { 
            get => stuName; set => stuName = value; 
        }
        public string Lastname
        { 
            get => lastname; 
            set => lastname = value; 
        }
        public string Number 
        { 
            get => number; 
            set => number = value; 
        }
        public string Picture 
        { 
            get => picture; 
            set => picture = value; 
        }
        public decimal Balance 
        { 
            get => balance; 
            set => balance = value; 
        }

    }
}