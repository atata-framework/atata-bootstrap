using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class DropdownToggleTests : UITestFixture
    {
        private DropdownTogglePage page;

        public DropdownToggleTests(string bootstrapVersionString)
            : base(bootstrapVersionString)
        {
        }

        public override void SetUp()
        {
            base.SetUp();

            page = Go.To<DropdownTogglePage>();
        }

        [Test]
        public void BSDropdownToggle()
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
        public void BSDropdownToggle_Disabled()
        {
            var control = page.Disabled;

            control.Should.BeVisible();
            control.Should.Not.BeEnabled();
        }
    }
}
