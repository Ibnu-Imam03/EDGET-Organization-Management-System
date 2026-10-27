using EDGET.DataAccess;

namespace EDGET.Business
{
    public class ArchitectureTest
    {
        public string GetMessage()
        {
            ConnectionTest dataAccess = new ConnectionTest();
            return "Business Layer → " + dataAccess.GetMessage();
        }
    }
}