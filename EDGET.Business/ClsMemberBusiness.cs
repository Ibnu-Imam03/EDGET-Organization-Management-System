
using System.Data;
using EDGET.DataAccess;

namespace EDGET.Business
{
    public class ClsMemberBusiness
    {
        public static DataTable GetAllMembers()
        {
            return ClsMemberDataAccess.GetAllMembers();
        }
    }
}
