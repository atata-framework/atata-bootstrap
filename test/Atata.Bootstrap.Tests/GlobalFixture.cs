using System.Net.NetworkInformation;
using Atata.Cli;
using Atata.WebDriverSetup;

namespace Atata.Bootstrap.Tests;

[SetUpFixture]
public class GlobalFixture : AtataGlobalFixture
{
    private CliCommand? _dotnetRunCommand;

    protected override void OnBeforeGlobalSetup() =>
        ThreadPool.SetMinThreads(Environment.ProcessorCount * 4, Environment.ProcessorCount);

    protected override void ConfigureAtataContextBaseConfiguration(AtataContextBuilder builder) =>
        builder.Sessions.AddWebDriver(x => x
            .UseStartScopes(AtataContextScopes.Test)
            .UseChrome(x => x
                .WithArguments(
                    "window-size=1200,800",
                    "headless=new",
                    "disable-search-engine-choice-screen")));

    [OneTimeSetUp]
    public async Task GlobalSetUpAsync() =>
        await Task.WhenAll(
            DriverSetup.AutoSetUpAsync(BrowserNames.Chrome),
            Task.Run(SetUpTestApp));

    private static bool IsTestAppRunning() =>
        Array.Exists(
            IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners(),
            x => x.Port == UITestSuite.TestAppPort);

    private void SetUpTestApp()
    {
        if (!IsTestAppRunning())
            StartTestApp();
    }

    private void StartTestApp()
    {
        string testAppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "Atata.Bootstrap.TestApp");

        ProgramCli dotnetCli = new ProgramCli("dotnet", useCommandShell: true)
            .WithWorkingDirectory(testAppPath);

        _dotnetRunCommand = dotnetCli.Start("run");

        RetryWait testAppWait = new(TimeSpan.FromSeconds(40), TimeSpan.FromSeconds(0.2));
        testAppWait.Until(IsTestAppRunning);
    }

    [OneTimeTearDown]
    public void GlobalTearDown()
    {
        if (_dotnetRunCommand is not null)
        {
            _dotnetRunCommand.Kill(true);
            _dotnetRunCommand.Dispose();
        }
    }
}
