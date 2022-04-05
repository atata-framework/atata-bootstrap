using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class DropdownTests : UITestFixture
    {
        private DropdownPage _page;

        public DropdownTests(string bootstrapVersionString)
            : base(bootstrapVersionString)
        {
        }

        public override void SetUp()
        {
            base.SetUp();

            _page = Go.To<DropdownPage>();
        }

        [Test]
        public void BSDropdown()
        {
            var control = _page.Regular;

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
            var control = _page.Disabled;

            control.Should.BeVisible();
            control.Should.Not.BeEnabled();
        }
    }
}
