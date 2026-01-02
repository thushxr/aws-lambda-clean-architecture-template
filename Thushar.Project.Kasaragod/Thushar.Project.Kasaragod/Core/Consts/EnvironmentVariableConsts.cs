namespace Thushar.Project.Kasaragod.Core.Consts;

public class EnvironmentVariableConsts
{
    public static readonly string SecretName = Environment.GetEnvironmentVariable("SECRET_NAME");
    public static readonly string Version = Environment.GetEnvironmentVariable("VERSION");
    public static readonly string Region = Environment.GetEnvironmentVariable("REGION");
    public static readonly string DbName = Environment.GetEnvironmentVariable("Database");
}
