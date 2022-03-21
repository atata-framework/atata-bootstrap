using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    [TestFixture("v3")]
    [TestFixture("v4")]
    [TestFixture("v5")]
    [Parallelizable]
    public abstract class UITestFixture
    {
        public const string BaseUrl = "http://localhost:59372/";

        private readonly string _bootstrapVersionString;

        protected UITestFixture(string bootstrapVersionString)
        {
            _bootstrapVersionString = bootstrapVersionString;
        }

        [SetUp]
        public virtual void SetUp()
        {
            AtataContext.Configure()
                .UseChrome()
                    .WithArguments("start-maximized")
                .UseBaseUrl(BaseUrl + _bootstrapVersionString)
                .UseCulture("en-US")
                .UseNUnitTestName()
                .LogConsumers.AddNUnitTestContext()
                .LogNUnitError()
                .Build();
        }

        [TearDown]
        public virtual void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
