using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class BSCollapseWithButtonTests : UITestFixture
    {
        [Test]
        public void BSCollapseWithButton()
        {
            Go.To<CollapseWithButton>().
                Header.Should.Equal("Verify a specific page that you need in Collapse with button Bootstrap").
                MyCollapseWithButton.Click().Wait(1).
                MyCollapseWithButton.Click().Wait(1);
        }
    }
}