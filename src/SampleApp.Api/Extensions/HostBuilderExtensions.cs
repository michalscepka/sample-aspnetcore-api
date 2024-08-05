﻿using SampleApp.Logging;
using Serilog;

namespace SampleApp.Api.Extensions;

internal static class HostBuilderExtensions
{
    public static IHostBuilder ConfigureSerilog(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureLogging((builder, logging) =>
        {
            logging.ClearProviders();
            LoggerConfigurationHelper.SetupLoggerConfiguration(builder.Configuration);
        }).UseSerilog();

        return hostBuilder;
    }
}
