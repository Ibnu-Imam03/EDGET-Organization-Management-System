
using System.Data;
using EDGET.DataAccess;

namespace EDGET.Business
{
    public class ClsPersonBusiness
    {
        private enum enMode { New = 0, Update = 1 }
        private enMode _Mode;

        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string TelegramUserName { get; set; }

        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Phone4 { get; set; }

        public ClsPersonBusiness()
        {
            PersonID = -1;
            FullName = string.Empty;
            Gender = string.Empty;
            TelegramUserName = string.Empty;

            Phone1 = string.Empty;
            Phone2 = string.Empty;
            Phone3 = string.Empty;
            Phone4 = string.Empty;

            _Mode = enMode.New;
        }

        private ClsPersonBusiness(int PersonID,string FullName,string Gender,string TelegramUserName,string Phone1,
            string Phone2,string Phone3,string Phone4){
            this.PersonID = PersonID;
            this.FullName = FullName;
            this.Gender = Gender;
            this.TelegramUserName = TelegramUserName;

            this.Phone1 = Phone1;
            this.Phone2 = Phone2;
            this.Phone3 = Phone3;
            this.Phone4 = Phone4;

            _Mode = enMode.Update;
        }

        public static DataTable GetAllPeople()
        {
            return ClsPersonDataAccess.GetAllPeople();
        }

        private bool UpdatePerson()
        {
            return ClsPersonDataAccess.UpdatePerson(
                PersonID, FullName, Gender, TelegramUserName);
        }

        private bool AddNewPerson()
        {
            int ID = ClsPersonDataAccess.AddNewPerson(FullName, Gender, TelegramUserName, Phone1, Phone2, Phone3, Phone4);

            if (ID != -1)
            {
                PersonID = ID;
                _Mode = enMode.Update;
                return true;
            }

            return false;
        }

        public bool DeletePerson(int PersonID)
        {
            return ClsPersonDataAccess.DeletePerson(PersonID);
        }

        public static ClsPersonBusiness GetPersonByID(int PersonID)
        {
            string FullName = string.Empty;
            string Gender = string.Empty;
            string TelegramUserName = string.Empty;

            string Phone1 = string.Empty;
            string Phone2 = string.Empty;
            string Phone3 = string.Empty;
            string Phone4 = string.Empty;

            if (ClsPersonDataAccess.GetPersonByID(PersonID,ref FullName,ref Gender,ref TelegramUserName,ref Phone1,ref Phone2,ref Phone3,ref Phone4))
            {
                return new ClsPersonBusiness(PersonID,FullName,Gender,TelegramUserName,Phone1,Phone2,Phone3,Phone4);
            }

            return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.New:
                    return AddNewPerson();

                case enMode.Update:
                    return UpdatePerson();

                default:
                    return false;
            }
        }
    }
}
