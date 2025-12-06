using Amazon.Lambda.Core;
using System.Runtime.CompilerServices;

namespace Tangonet.Settlement.VisualReport.Core.Helpers;

public class Log
{
    ILambdaLogger _logger;

    public void SetLogger(ILambdaLogger context) =>
        _logger = context;

    void WriteLog(string message)
    {
        if (_logger != null)
            _logger.LogLine(message);
        else
            Console.WriteLine(message);
    }

    private string GetFileName(string filePath) => 
        Path.GetFileNameWithoutExtension(filePath);

    public void Info(
        string message,
        [CallerFilePath] string filePath = null,
        [CallerMemberName] string caller = null) =>
        WriteLog($"[🟨 INFO] [{GetFileName(filePath)}:{caller}] MSG : {message}");

    public void Error(
        string message,
        [CallerFilePath] string filePath = null,
        [CallerMemberName] string caller = null) =>
        WriteLog($"[🟦 ERROR] [{GetFileName(filePath)}:{caller}] MSG : {message}");

    public void Exception(
        Exception ex,
        [CallerFilePath] string filePath = null, 
        [CallerMemberName] string caller = null) =>
        WriteLog($"[🟥 EXCEPTION] [{GetFileName(filePath)}:{caller}] MSG : {ex}");

    public void Success(
        string message,
        [CallerFilePath] string filePath = null,
        [CallerMemberName] string caller = null) =>
        WriteLog($"[🟩 SUCCESS] [{GetFileName(filePath)}:{caller}] MSG : {message}");

    public void Trace(
        string message,
        [CallerFilePath] string filePath = null,
        [CallerMemberName] string caller = null) =>
        WriteLog($"[⬜ TRACE] [{GetFileName(filePath)}:{caller}] MSG : {message}");
}