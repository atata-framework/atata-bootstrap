namespace Atata.Bootstrap.Tests;

public sealed class DropdownTests : UITestSuite
{
    private DropdownPage _page = null!;

    public DropdownTests(string bootstrapVersionString)
        : base(bootstrapVersionString)
    {
    }

    [SetUp]
    public void SetUp() =>
        _page = Go.To<DropdownPage>();

    [Test]
    public void BSDropdown()
    {
        var control = _page.Regular;

        control.Should.BeVisible();
        control.Should.BeEnabled();

        control.Item1.Click();
        control.Item3.Click();

        control.Item2.Content.Should.Be("Item 2");
        control.Item3.Content.Should.Be("Item 3");
    }

    [Test]
    public void BSDropdown_Disabled()
    {
        var control = _page.Disabled;

        control.Should.BeVisible();
        control.Should.Not.BeEnabled();
    }
}
