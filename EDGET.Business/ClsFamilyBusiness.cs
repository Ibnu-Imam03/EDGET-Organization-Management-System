using System.Data;
using EDGET.DataAccess;

namespace EDGET.Business
{
    public class ClsFamilyBusiness
    {
        private enum enMode { New = 0, Update = 1 }
        private enMode _Mode;

        public int FamilyID { get; set; }
        public int PersonID { get; set; }
        public string FamilyName { get; set; }
        public string Address { get; set; }
        public string Situation { get; set; }

        public ClsPersonBusiness Person
        {
            get
            {
                return ClsPersonBusiness.GetPersonByID(PersonID);
            }
        }
        public ClsFamilyBusiness()
        {
            FamilyID = -1;
            PersonID = -1;
            FamilyName = string.Empty;
            Address = string.Empty;
            Situation = string.Empty;

            _Mode = enMode.New;
        }

        private ClsFamilyBusiness(int FamilyID, int PersonID, string FamilyName,
            string Address, string Situation)
        {
            this.FamilyID = FamilyID;
            this.PersonID = PersonID;
            this.FamilyName = FamilyName;
            this.Address = Address;
            this.Situation = Situation;

            _Mode = enMode.Update;
        }

        public static DataTable GetAllFamilies()
        {
            return ClsFamilyDataAccess.GetAllFamilies();
        }

        private bool UpdateFamily()
        {
            return ClsFamilyDataAccess.UpdateFamily(
                FamilyID, PersonID, FamilyName, Address, Situation);
        }

        private bool AddNewFamily()
        {
            int ID = ClsFamilyDataAccess.AddNewFamily(
                PersonID, FamilyName, Address, Situation);

            if (ID != -1)
            {
                FamilyID = ID;
                _Mode = enMode.Update;
                return true;
            }

            return false;
        }

        public static bool DeleteFamily(int FamilyID)
        {
            return ClsFamilyDataAccess.DeleteFamily(FamilyID);
        }

        public static ClsFamilyBusiness GetFamilyByID(int FamilyID)
        {
            int PersonID = -1;
            string FamilyName = string.Empty;
            string Address = string.Empty;
            string Situation = string.Empty;

            if (ClsFamilyDataAccess.GetFamilyByID(FamilyID, ref PersonID, ref FamilyName,ref Address, ref Situation))
            {
                return new ClsFamilyBusiness(
                    FamilyID, PersonID, FamilyName, Address, Situation);
            }

            return null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.New:
                    return AddNewFamily();

                case enMode.Update:
                    return UpdateFamily();

                default:
                    return false;
            }
        }
    }
}