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

            AtataContext.Configure().
                UseChrome().
                    WithArguments("disable-extensions", "no-sandbox", "start-maximized").
                UseBaseUrl(baseUrl).
                UseCulture("en-us").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                    WithMinLevel(LogLevel.Info).
                LogNUnitError().
                Build();
        }

        [TearDown]
        public virtual void TearDown()
        {
            AtataContext.Current.CleanUp();
        }
    }
}
