namespace Atata.Bootstrap.Tests;

[TestFixture("v3")]
[TestFixture("v4")]
[TestFixture("v5")]
[Parallelizable]
public abstract class UITestFixture
{
    public const int TestAppPort = 59372;

    private readonly string _bootstrapVersionString;

    protected UITestFixture(string bootstrapVersionString) =>
        _bootstrapVersionString = bootstrapVersionString;

    public static string BaseUrl { get; } = $"http://localhost:{TestAppPort}/";

    [SetUp]
    public virtual void SetUp() =>
        AtataContext.Configure()
            .UseChrome()
                .WithArguments(
                    "window-size=1200,800",
                    "headless",
                    "disable-search-engine-choice-screen")
            .UseBaseUrl(BaseUrl + _bootstrapVersionString)
            .UseCulture("en-US")
            .UseAllNUnitFeatures()
            .Build();

    [TearDown]
    public virtual void TearDown() =>
        AtataContext.Current?.Dispose();
}
