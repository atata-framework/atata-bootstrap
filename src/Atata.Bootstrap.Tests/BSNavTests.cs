using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class BSNavTests : UITestFixture
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
                Pane1.TextInput.Should.Equal("abc").
                Pane2.Content.Should.Contain("Sed ut perspiciatis");
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
                ActiveMenu.Content.Should.Equal("Menu 3").

                Menu1.Should.BeEnabled().
                Menu3.Should.BeEnabled().
                Menu4.Should.BeDisabled();
        }

        [Test]
        public void BSTabPane_Tabs()
        {
            Go.To<TabsPage>().
                Pane1.TextInput.Set("abc").
                Pane1.TextInput.Set("def").
                Pane2.Header.Should.Equal("Menu 2").
                Pane2.CheckBox.Check().
                Pane3.Text.Should.Contain("Eaque ipsa").
                Pane2.CheckBox.Should.BeChecked().
                Pane1.TextInput.Should.Equal("def").
                Pane2.Content.Should.Contain("Sed ut perspiciatis");
        }

        [Test]
        public void BSTab()
        {
            Go.To<TabsPage>().
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
                ActiveMenu.Content.Should.Equal("Menu 3").

                Menu1.Should.BeEnabled().
                Menu3.Should.BeEnabled().
                Menu4.Should.BeDisabled();
        }


        [Test]
        public void BSAccordion()
        {
            Go.To<AccordionsPage>().
                PageTitle.Should.Equal("Accordions").
                Header.Should.Equal("Verify a specific page that you need of Accordion Bootstrap").
                Content.Should.Contain("Ad vegan excepteur").

                AccordionItems.Count.Should.Equal(3).

                AccordionItems[0].Header.Should.Equal("Menu 1").
                AccordionItems[1].Header.Should.Equal("Menu 2").
                AccordionItems[2].Header.Should.Equal("Menu 3").
                AccordionItems[0].ATag.Click().
                AccordionItems[1].ATag.Click().
                AccordionItems[2].ATag.Click();

        }
    }
}
