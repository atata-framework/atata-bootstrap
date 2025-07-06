namespace Atata.Bootstrap.Tests;

public class BSNavTests : UITestFixture
{
    public BSNavTests(string bootstrapVersionString)
        : base(bootstrapVersionString)
    {
    }

    [Test]
    public void BSTabPane_Pills() =>
        Go.To<PillsPage>()
            .Pane1.TextInput.Set("abc")
            .Pane2.Header.Should.Be("Menu 2")
            .Pane2.CheckBox.Check()
            .Pane3.Text.Should.Contain("Eaque ipsa")
            .Pane2.CheckBox.Should.BeChecked()
            .Pane1.TextInput.Should.Be("abc")
            .Pane2.Content.Should.Contain("Sed ut perspiciatis");

    [Test]
    public void BSPill() =>
        Go.To<PillsPage>()
            .Menu1.IsActive.Should.BeTrue()
            .Menu2.IsActive.Should.BeFalse()
            .ActiveMenu.Content.Should.Be("Menu 1")

            .Menu2.Click()
            .Menu1.IsActive.Should.BeFalse()
            .Menu2.IsActive.Should.BeTrue()
            .ActiveMenu.Content.Should.Be("Menu 2")

            .Menu3.Click()
            .Menu2.IsActive.Should.BeFalse()
            .Menu3.IsActive.Should.BeTrue()
            .ActiveMenu.Content.Should.Be("Menu 3")

            .Menu1.Should.BeEnabled()
            .Menu3.Should.BeEnabled()
            .Menu4.Should.BeDisabled();

    [Test]
    public void BSTabPane_Tabs() =>
        Go.To<TabsPage>()
            .Pane1.TextInput.Set("abc")
            .Pane2.Header.Should.Be("Menu 2")
            .Pane2.CheckBox.Check()
            .Pane3.Text.Should.Contain("Eaque ipsa")
            .Pane2.CheckBox.Should.BeChecked()
            .Pane1.TextInput.Should.Be("abc")
            .Pane2.Content.Should.Contain("Sed ut perspiciatis");

    [Test]
    public void BSTab() =>
        Go.To<TabsPage>()
            .Menu1.IsActive.Should.BeTrue()
            .Menu2.IsActive.Should.BeFalse()
            .ActiveMenu.Content.Should.Be("Menu 1")

            .Menu2.Click()
            .Menu1.IsActive.Should.BeFalse()
            .Menu2.IsActive.Should.BeTrue()
            .ActiveMenu.Content.Should.Be("Menu 2")

            .Menu3.Click()
            .Menu2.IsActive.Should.BeFalse()
            .Menu3.IsActive.Should.BeTrue()
            .ActiveMenu.Content.Should.Be("Menu 3")

            .Menu1.Should.BeEnabled()
            .Menu3.Should.BeEnabled()
            .Menu4.Should.BeDisabled();
}
