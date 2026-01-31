namespace Atata.Bootstrap.Tests;

[SetUpFixture]
public sealed class GlobalFixture : AtataGlobalFixture
{
    protected override void OnBeforeGlobalSetup() =>
        ThreadPool.SetMinThreads(Environment.ProcessorCount * 4, Environment.ProcessorCount);

    protected override void ConfigureAtataContextBaseConfiguration(AtataContextBuilder builder)
    {
        builder.LogConsumers.AddNLogFile();

        builder.Sessions.AddWebDriver(x => x
            .UseStartScopes(AtataContextScopes.Test)
            .UseChrome(x => x
                .WithArguments(
                    "window-size=1200,800",
                    "headless=new",
                    "disable-search-engine-choice-screen")));
    }

    protected override void ConfigureGlobalAtataContext(AtataContextBuilder builder)
    {
        builder.SetUpWebDriversForUse();

        builder.Sessions.AddWebApplication(x => x
            .Use<Program>()
            .UseKestrel(UITestSuite.TestAppPort)
            .UseStartWhenKestrelPortIsAvailable()
            .UseMinimumApplicationLogLevel(Microsoft.Extensions.Logging.LogLevel.Warning));
    }
}
