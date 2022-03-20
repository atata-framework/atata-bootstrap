using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class DropdownTests : UITestFixture
    {
        private DropdownPage page;

        public DropdownTests(string bootstrapVersionString)
            : base(bootstrapVersionString)
        {
        }

        public override void SetUp()
        {
            base.SetUp();

            page = Go.To<DropdownPage>();
        }

        [Test]
        public void BSDropdown()
        {
            var control = page.Regular;

            control.Should.BeVisible();
            control.Should.BeEnabled();

            control.Item1.Click();
            control.Item3.Click();

            control.Item2.Content.Should.Equal("Item 2");
            control.Item3.Content.Should.Equal("Item 3");
        }

        [Test]
        public void BSDropdown_Disabled()
        {
            var control = page.Disabled;

            control.Should.BeVisible();
            control.Should.Not.BeEnabled();
        }
    }
}
