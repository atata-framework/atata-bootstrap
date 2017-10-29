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
                Content.Should.Contain("Ad vegan excepteur").

                AccordionItems.Count.Should.Equal(3).
                AccordionItems[0].Header.Should.Equal("Menu 1").
                AccordionItems[1].Header.Should.Equal("Menu 2").
                AccordionItems[2].Header.Should.Equal("Menu 3").

                // AccordionItems[0].ATag.Click().
                // AccordionItems[1].ATag.Click().
                // AccordionItems[2].ATag.Click().
                Menu1.RightClick().
                Menu2.RightClick().
                Menu3.RightClick();
        }
    }
}
