using System.Data;

namespace ScheduleSms.Database
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection Create();
    }
}