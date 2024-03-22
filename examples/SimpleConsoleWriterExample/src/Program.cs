using L0gg3r;
using L0gg3r.LogSinks.Console;

// await using (Logger logger = Logger.CreateLogger().LogTo.Console().Build())
// {
//     logger.Info("Hello, World!");
//     logger.Warning("Hello, World!");
//     logger.Error("Hello, World!");
// }

// await using (Logger logger = Logger
//     .CreateLogger()
//     .LogTo.Console(logSinkBuilder =>
//     {
//         logSinkBuilder.WithTimestampFormat("yyyy-MM-dd HH:mm:ss.fff");
//     })
//     .Build())
// {
//     logger.Info("Hello, World!");
//     logger.Warning("Hello, World!");
//     logger.Error("Hello, World!");
// }

await using (Logger logger = Logger.CreateLogger().WithChildLogger("Test").Build())
{
    Logger childLogger = logger.GetChildLogger("Test");

    childLogger.Info("Hello, World!");
    // childLogger.Warning("Hello, World!");
    // childLogger.Error("Hello, World!");
}
