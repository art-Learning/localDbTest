using Dapper;
using ScheduleSms.Database;

namespace ScheduleSms.Service
{
    internal class SmsService
    {
        private IDatabaseConnectionFactory DatabaseConnectionFactory { get; }

        public SmsService(IDatabaseConnectionFactory connectionFactory)
        {
            DatabaseConnectionFactory = connectionFactory;
        }

        public bool CheckSmsEnable()
        {
            bool isEnable;
            using (var sql = DatabaseConnectionFactory.Create())
            {
                isEnable = sql.QuerySingle<bool>(GetCheckSmsEnableSqlCmd());
            }
            return isEnable;
        }

        private static string GetCheckSmsEnableSqlCmd()
        {
            return "SELECT SMS_ENABLE_FG FROM TEST";
        }
    }
}