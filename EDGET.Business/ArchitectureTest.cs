using EDGET.DataAccess;

namespace EDGET.Business
{
    public class DatabaseConnectionManager
    {
        public string TestConnection()
        {
            DatabaseConnectionTest test =
                new DatabaseConnectionTest();

            return test.TestConnection();
        }
    }
}