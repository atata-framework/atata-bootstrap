using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class BSAccordionTests : UITestFixture
    {
        [Test]
        public void BSAccordion()
        {
            Go.To<AccordionsPage>().
                PageTitle.Should.Equal("Accordions").
                Header.Should.Equal("Verify a specific page that you need of Accordion Bootstrap").
                Description.Should.Contain("Ad vegan excepteur").

                Accordion.Count.Should.Equal(3).
                Accordion[0].Header.Should.Equal("Menu 1").
                Accordion[1].Header.Should.Equal("Menu 2").
                Accordion[2].Header.Should.Equal("Menu 3").

                // AccordionItems[0].ATag.Click().
                // AccordionItems[1].ATag.Click().
                // AccordionItems[2].ATag.Click().
                Menu1.RightClick().
                Menu2.RightClick().
                Menu3.RightClick();
        }
    }
}
