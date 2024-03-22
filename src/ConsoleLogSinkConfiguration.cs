// ----------------------------------------------------------------------------
// <copyright file="ConsoleLogSinkConfiguration.cs" company="L0gg3r">
// Copyright (c) L0gg3r Project
// </copyright>
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace L0gg3r.LogSinks.Console;

public struct ConsoleLogSinkConfiguration
{
    public ConsoleLogSinkConfiguration()
    {
        string test = TimestampFormat;

        Renderables = logMessage => [
            logMessage.Timestamp.ToString(test, CultureInfo.InvariantCulture),
            logMessage.LogLevel.ToString(),
            logMessage.Senders.First(),
            logMessage.Payload?.ToString() ?? string.Empty,
        ];
    }

    /// <summary>
    /// Gets or sets the timestamp format used to format the timestamp in the log message.
    /// </summary>
    public string TimestampFormat { get; set; } = "yyyy-MM-dd HH:mm:ss.fff";

    public string Spacing { get; set; } = " ";

    public Func<LogLevel, string> LogLevelToString { get; set; } = (LogLevel logLevel) =>
    {
        if (logLevel == LogLevel.Info)
        {
            return "INFO";
        }
        else if (logLevel == LogLevel.Warning)
        {
            return "WARN";
        }
        else if (logLevel == LogLevel.Error)
        {
            return "ERRO";
        }
        else
        {
            return "UNKN";
        }
    };

    public Func<LogMessage, IEnumerable<string>> Renderables { get; set; }
}
