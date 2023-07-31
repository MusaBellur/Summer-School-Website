namespace EntityLayer
{
    public class EntityStudents
    {
        private int stuId;
        private string stuName;
        private string lastname;
        private string number;
        private string foto;
        private decimal balance;
        private string password;

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
        public string Foto 
        { 
            get => foto; 
            set => foto = value; 
        }
        public decimal Balance 
        { 
            get => balance; 
            set => balance = value; 
        }
        public string Password 
        { 
            get => password; set => password = value; 
        }
    }
}