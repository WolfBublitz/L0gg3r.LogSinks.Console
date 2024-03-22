// ----------------------------------------------------------------------------
// <copyright file="ConsoleLogSinkBuilder.cs" company="L0gg3r">
// Copyright (c) L0gg3r Project
// </copyright>
// ----------------------------------------------------------------------------

namespace L0gg3r.LogSinks.Console;

public class ConsoleLogSinkBuilder : LogSinkBuilder<ConsoleLogSink, ConsoleLogSinkBuilder>
{
    public ConsoleLogSinkBuilder WithTimestampFormat(string timestampFormat)
    {
        return WithModification(logSink => logSink.TimestampFormat = timestampFormat);
    }
}
