using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class BSCollapseWithHrefTests : UITestFixture
    {
        [Test]
        public void BSCollapseWithHref()
        {
            Go.To<CollapseWithHref>().
                Header.Should.Equal("Verify a specific page that you need in Collapse with href Bootstrap").
                MyCollapseWithHref.Click().Wait(1).
                MyCollapseWithHref.Click().Wait(1);
        }
    }
}