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
                    WithArguments("start-maximized").
                UseBaseUrl(baseUrl).
                UseCulture("en-us").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
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
