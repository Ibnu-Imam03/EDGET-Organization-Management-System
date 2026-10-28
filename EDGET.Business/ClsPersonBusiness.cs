
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

        public ClsPersonBusiness()
        {
            PersonID = -1;
            FullName = string.Empty;
            Gender = string.Empty;
            TelegramUserName = string.Empty;
            _Mode = enMode.New;
        }

        private ClsPersonBusiness(int PersonID,string FullName,string Gender,string TelegramUserName)
        {
            this.PersonID = PersonID;
            this.FullName = FullName;
            this.Gender = Gender;
            this.TelegramUserName = TelegramUserName;
            _Mode = enMode.Update;
        }

        public static DataTable GetAllPeople()
        {
            return ClsPersonDataAccess.GetAllPeople();
        }

        private bool UpdatePerson()
        {
            return ClsPersonDataAccess.UpdatePerson(PersonID,FullName,Gender,TelegramUserName);
        }

        private bool AddNewPerson()
        {
            int ID = ClsPersonDataAccess.AddNewPerson(FullName,Gender,TelegramUserName);

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

        public static ClsPersonBusiness IsPersonExist(int PersonID)
        {
            string FullName = string.Empty;
            string Gender = string.Empty;
            string TelegramUserName = string.Empty;

            if (ClsPersonDataAccess.GetPersonByID(PersonID,ref FullName,ref Gender,ref TelegramUserName))
            {
                return new ClsPersonBusiness(PersonID,FullName,Gender,TelegramUserName);
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
