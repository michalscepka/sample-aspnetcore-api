using Microsoft.Extensions.Configuration;
using Serilog;

namespace SampleApp.Logging;

public static class LoggerConfigurationHelper
{
    public static void SetupLoggerConfiguration(IConfiguration configuration)
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .Enrich.FromLogContext()
            .CreateLogger();
    }
}
