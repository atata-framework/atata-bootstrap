using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    [TestFixture]
    [Parallelizable]
    public abstract class UITestFixture
    {
        public const string BaseUrl = "http://localhost:59372/";

        [SetUp]
        public virtual void SetUp()
        {
            AtataContext.Configure().
                UseChrome().
                    WithArguments("start-maximized").
                UseBaseUrl(BaseUrl).
                UseCulture("en-US").
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
