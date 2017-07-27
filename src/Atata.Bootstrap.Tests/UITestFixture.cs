using System.Configuration;
using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    [TestFixture]
    public abstract class UITestFixture
    {
        [SetUp]
        public virtual void SetUp()
        {
            string baseUrl = ConfigurationManager.AppSettings["TestAppUrl"];

            AtataContext.Build().
                UseChrome().
                    WithArguments("disable-extensions", "no-sandbox", "start-maximized").
                UseBaseUrl(baseUrl).
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                    WithMinLevel(LogLevel.Info).
                LogNUnitError().
                SetUp();
        }

        [TearDown]
        public virtual void TearDown()
        {
            AtataContext.Current.CleanUp();
        }
    }
}
