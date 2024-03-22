// ----------------------------------------------------------------------------
// <copyright file="LogSinkBuilderExtensions.cs" company="L0gg3r">
// Copyright (c) L0gg3r Project
// </copyright>
// ----------------------------------------------------------------------------

using System;

namespace L0gg3r.LogSinks.Console;

/// <summary>
/// Provides extension methods for <see cref="LogSinkBuilder"/>.
/// </summary>
public static class ConsoleLogSinkBuilderExtensions
{
    /// <summary>
    /// Creates a new <see cref="ConsoleLogSink"/> and adds it to the <see cref="LogSinkBuilder"/>.
    /// </summary>
    /// <param name="this">This <see cref="LogSinkBuilder"/>.</param>
    /// <returns>The <see cref="LoggerBuilder"/>.</returns>
    public static LoggerBuilder Console(this LogTo @this)
    {
        ConsoleLogSinkBuilder consoleLogSinkBuilder = new();

        return @this.LogSink(consoleLogSinkBuilder);
    }

    public static LoggerBuilder Console(this LogTo @this, Action<ConsoleLogSinkBuilder> logSinkBuilder)
    {
        ArgumentNullException.ThrowIfNull(logSinkBuilder, nameof(logSinkBuilder));

        ConsoleLogSinkBuilder consoleLogSinkBuilder = new();

        logSinkBuilder(consoleLogSinkBuilder);

        return @this.LogSink(consoleLogSinkBuilder);
    }
}
