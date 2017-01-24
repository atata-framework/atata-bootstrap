using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class BSPillTest : AutoTest
    {
        [Test]
        public void BSPillPane()
        {
            Go.To<PillsPage>().
                Pane2.CheckBox.Check().
                Pane2.Header.Should.Equal("Menu 2");
        }
    }
}
