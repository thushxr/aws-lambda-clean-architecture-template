using Amazon;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using Newtonsoft.Json.Linq;
using Tangonet.Settlement.VisualReport.Core.Consts;

namespace Tangonet.Settlement.VisualReport.Infrastructure.Helpers;

public class SecretManagerHelper
{
    public static string RdsProxyHost { get; set; } = "localhost";
    public static string UserName { get; set; } = "root";
    public static string Password { get; set; } = "root";
    public static string Port { get; set; } = "3306";

    public static async Task SetSecretManagerData()
    {
        using AmazonSecretsManagerClient secretsManagerClient = new(RegionEndpoint.USEast1);
        GetSecretValueRequest request = new()
        {
            SecretId = EnvironmentVariableConsts.SecretName,
            VersionStage = EnvironmentVariableConsts.Version,
        };
        try
        {
            var response = await secretsManagerClient.GetSecretValueAsync(request);
            var secret = response.SecretString;
            var secretObject = JObject.Parse(secret);

            RdsProxyHost = secretObject["rds_proxy_host"].ToString();
            UserName = secretObject["user_name"].ToString();
            Port = secretObject["port"].ToString();
            Password = secretObject["password"].ToString();

        }
        catch (Exception)
        {
            throw;
        }
    }
}
