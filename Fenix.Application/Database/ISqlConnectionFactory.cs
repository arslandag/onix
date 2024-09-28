using System.Data;

namespace Fenix.Application.Database;

public interface ISqlConnectionFactory
{
    IDbConnection Create();
}