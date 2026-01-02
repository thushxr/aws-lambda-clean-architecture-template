using MySql.Data.MySqlClient;
using System.Data;
using Thushar.Project.Kasaragod.Core.Helpers;

namespace Thushar.Project.Kasaragod.Infrastructure.Helpers;

public class DatabaseHelper(Log log)
{
    private static string GetRdsDatabaseConnectionString(string databaseName)
    {
        return $"Server={SecretManagerHelper.RdsProxyHost};Port={SecretManagerHelper.Port};Database={databaseName};Uid={SecretManagerHelper.UserName};Pwd={SecretManagerHelper.Password}";
    }

    public async Task<IDbConnection> ConnectDatabase(string databaseName = "db_settlement")
    {
        try
        {
            var connection = new MySqlConnection();
            var connectionString = GetRdsDatabaseConnectionString(databaseName);
            connection.ConnectionString = connectionString;
            log.Info($"Connecting to MySQL database: {databaseName}");
            connection.Open();
            log.Info($"Successfully connected to MySQL database: {databaseName}");
            return connection;
        }
        catch (Exception ex)
        {
            log.Error($"Exception from ConnectDatabase while connnecting to {databaseName} : {ex.Message}");
            log.Exception(ex);
            throw;
        }
    }
}
