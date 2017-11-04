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
                MyAccordions[0].Click().Wait(1).
                MyAccordions[1].Click().Wait(1).
                MyAccordions[2].Click().Wait(1).
                MyAccordions[2].Click().Wait(1);
        }
    }
}
