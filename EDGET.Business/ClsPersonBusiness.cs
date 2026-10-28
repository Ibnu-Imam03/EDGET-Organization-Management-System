using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDGET.DataAccess;

namespace EDGET.Business
{
    public class ClsPersonBusiness
    {
        private enum enMode { New=0, Update =1};
        private enMode _Mode;
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string TelegramUserName {  get; set; }

        public  ClsPersonBusiness()
        {

            this.PersonID = -1;
            this.FullName = string.Empty;
            this.Gender = string.Empty;
            this.TelegramUserName = string.Empty;
            _Mode = enMode.New;
            
        }

        public static DataTable GetAllPeople()
        {
            return ClsPersonDataAccess.GetAllPeople();
        }


    }
}
