using Serilog;
using Serilog.Events;

namespace Logging.Core
{
  public static class Flogger
  {
    private static readonly ILogger PerfLogger;
    private static readonly ILogger UsageLogger;
    private static readonly ILogger ErrorLogger;
    private static readonly ILogger DiagnosticLogger;

    static Flogger()
    {
      PerfLogger = new LoggerConfiguration().WriteTo.File("perf.txt").CreateLogger();
      UsageLogger = new LoggerConfiguration().WriteTo.File("usage.txt").CreateLogger();
      ErrorLogger = new LoggerConfiguration().WriteTo.File("error.txt").CreateLogger();
      DiagnosticLogger = new LoggerConfiguration().WriteTo.File("diagnostic.txt").CreateLogger();
    }

    public static void WritePerf(FlogDetail perfLog) =>
      PerfLogger.Write(LogEventLevel.Information, $"@{nameof(FlogDetail)}", perfLog);

    public static void WriteUsage(FlogDetail usageLog) =>
      UsageLogger.Write(LogEventLevel.Information, $"@{nameof(FlogDetail)}", usageLog);

    public static void WriteError(FlogDetail errorfLog) =>
      ErrorLogger.Write(LogEventLevel.Information, $"@{nameof(FlogDetail)}", errorfLog);

    public static void WriteDiagnostic(FlogDetail diagnosticLog) =>
      DiagnosticLogger.Write(LogEventLevel.Information, $"@{nameof(FlogDetail)}", diagnosticLog);
  }
}
