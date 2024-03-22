// ----------------------------------------------------------------------------
// <copyright file="ConsoleLogSink.cs" company="L0gg3r">
// Copyright (c) L0gg3r Project
// </copyright>
// ----------------------------------------------------------------------------

using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace L0gg3r.LogSinks.Console;

public sealed class ConsoleLogSink : LogSinkBase
{
    public string TimestampFormat { get; set; } = "yyyy-MM-dd HH:mm:ss.fff";

    // ┌────────────────────────────────────────────────────────────────────────────────┐
    // │ Protected Methods                                                              │
    // └────────────────────────────────────────────────────────────────────────────────┘

    protected override ValueTask WriteAsync(in LogMessage logMessage)
    {
        string[] parts =
        [
            logMessage.Timestamp.ToString(TimestampFormat, CultureInfo.InvariantCulture),
            LogLevelToString(logMessage.LogLevel),
            string.Join("|", logMessage.Senders),
            logMessage.Payload?.ToString() ?? string.Empty
        ];

        System.Console.WriteLine(string.Join(" ", parts));

        return ValueTask.CompletedTask;
    }

    private string LogLevelToString(LogLevel logLevel)
    {
        if (logLevel == LogLevel.Info)
        {
            return "[INFO]";
        }
        else if (logLevel == LogLevel.Warning)
        {
            return "[WARN]";
        }
        else if (logLevel == LogLevel.Error)
        {
            return "[ERRO]";
        }
        else
        {
            return "[UNKN]";
        }
    }
}
