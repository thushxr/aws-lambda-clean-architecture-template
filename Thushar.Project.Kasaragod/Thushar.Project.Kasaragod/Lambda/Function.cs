using Amazon.Lambda.Core;
using System.Text.Json;
using Thushar.Project.Kasaragod.Infrastructure.Helpers;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Thushar.Project.Kasaragod.Lambda;

public class Function : FunctionBase
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input">The event for the Lambda function handler to process.</param>
    /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>
    public async Task<string> FunctionHandler(string request, ILambdaContext context)
    {
        Logger.SetLogger(context.Logger);
        Logger.Trace($"Program started : {JsonSerializer.Serialize(request)}");
        try
        {
            Logger.Info("Setting secret manager data");
            await SecretManagerHelper.SetSecretManagerData();
        }
        catch (Exception ex)
        {
            Logger.Error($"Error setting secret manager data: {ex.Message}");
            return null;
        }

        return null;
    }
}
