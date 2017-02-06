using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class BSNavTest : AutoTest
    {
        [Test]
        public void BSTabPane_Pills()
        {
            Go.To<PillsPage>().
                Pane1.TextInput.Set("abc").
                Pane2.Header.Should.Equal("Menu 2").
                Pane2.CheckBox.Check().
                Pane3.Text.Should.Contain("Eaque ipsa").
                Pane2.CheckBox.Should.BeChecked().
                Pane1.TextInput.Should.Equal("abc");
        }

        [Test]
        public void BSPill()
        {
            Go.To<PillsPage>().
                Menu1.IsActive.Should.BeTrue().
                Menu2.IsActive.Should.BeFalse().
                ActiveMenu.Content.Should.Equal("Menu 1").

                Menu2.Click().
                Menu1.IsActive.Should.BeFalse().
                Menu2.IsActive.Should.BeTrue().
                ActiveMenu.Content.Should.Equal("Menu 2").

                Menu3.Click().
                Menu2.IsActive.Should.BeFalse().
                Menu3.IsActive.Should.BeTrue().
                ActiveMenu.Content.Should.Equal("Menu 3");
        }
    }
}
