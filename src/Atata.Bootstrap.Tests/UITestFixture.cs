using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    [TestFixture]
    public abstract class UITestFixture
    {
        public const string BaseUrl = "http://localhost:56073/";

        [SetUp]
        public virtual void SetUp()
        {
            AtataContext.Configure().
                UseChrome().
                    WithArguments("start-maximized", "disable-infobars", "disable-extensions").
                UseBaseUrl(BaseUrl).
                UseCulture("en-us").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                LogNUnitError().
                Build();
        }

        [TearDown]
        public virtual void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
