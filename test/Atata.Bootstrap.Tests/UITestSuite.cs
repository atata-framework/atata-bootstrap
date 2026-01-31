namespace Atata.Bootstrap.Tests;

[TestFixture("v3")]
[TestFixture("v4")]
[TestFixture("v5")]
public abstract class UITestSuite : AtataTestSuite
{
    public const int TestAppPort = 59372;

    private readonly string _bootstrapVersionString;

    protected UITestSuite(string bootstrapVersionString) =>
        _bootstrapVersionString = bootstrapVersionString;

    public static string BaseUrl { get; } = $"http://localhost:{TestAppPort}/";

    protected override void ConfigureTestAtataContext(AtataContextBuilder builder) =>
        builder.Sessions.ConfigureWebDriver(x => x
            .UseBaseUrl(BaseUrl + _bootstrapVersionString));
}
