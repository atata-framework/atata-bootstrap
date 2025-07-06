namespace Atata.Bootstrap.Tests;

public class DropdownToggleTests : UITestFixture
{
    private DropdownTogglePage _page = null!;

    public DropdownToggleTests(string bootstrapVersionString)
        : base(bootstrapVersionString)
    {
    }

    public override void SetUp()
    {
        base.SetUp();

        _page = Go.To<DropdownTogglePage>();
    }

    [Test]
    public void BSDropdownToggle()
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
    public void BSDropdownToggle_Disabled()
    {
        var control = _page.Disabled;

        control.Should.BeVisible();
        control.Should.Not.BeEnabled();
    }
}
