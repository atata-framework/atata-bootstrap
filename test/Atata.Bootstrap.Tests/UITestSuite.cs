namespace Atata.Bootstrap.Tests;

[TestFixture("v3")]
[TestFixture("v4")]
[TestFixture("v5")]
[Parallelizable]
public abstract class UITestSuite : AtataTestSuite
{
    public const int TestAppPort = 59372;

    private readonly string _bootstrapVersionString;

    protected UITestSuite(string bootstrapVersionString) =>
        _bootstrapVersionString = bootstrapVersionString;

    public static string BaseUrl { get; } = $"http://localhost:{TestAppPort}/";

    protected override void ConfigureTestAtataContext(AtataContextBuilder builder) =>
        builder.Sessions.AddWebDriver(x => x
            .UseChrome(x => x
                .WithArguments(
                    "window-size=1200,800",
                    "headless=new",
                    "disable-search-engine-choice-screen"))
            .UseBaseUrl(BaseUrl + _bootstrapVersionString));
}
