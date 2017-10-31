using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class BSListGroupTests : UITestFixture
    {
        [Test]
        public void BSListGroup()
        {
            Go.To<ListGroupPage>().
            PageTitle.Should.Equal("ListGroup").

            Header.Should.Equal("Verify a specific page that you need in List-group Bootstrap").

            // Count the number of unit of <li> item in the first <ul> of the page.
            UnorderedList.Items.Count.Should.Equal(5).
            OrderedList.Items.Count.Should.Equal(3).

            ControlList.Count.Should.Equal(3).
            ControlList[0].Header.Should.Equal("ul basic example item1").
            ControlList[1].Header.Should.Equal("ul basic example item2").
            ControlList[2].Header.Should.Equal("ul basic example item3").

            BadgesOrderedList.Items.Count.Should.Equal(3);


            //Description.Should.Contain("Ad vegan excepteur").

            //Accordion.Count.Should.Equal(3).
            //Accordion[0].Header.Should.Equal("Menu 1").
            //Accordion[1].Header.Should.Equal("Menu 2").
            //Accordion[2].Header.Should.Equal("Menu 3").

            //// AccordionItems[0].ATag.Click().
            //// AccordionItems[1].ATag.Click().
            //// AccordionItems[2].ATag.Click().
            //Menu1.RightClick().
            //Menu2.RightClick().
            //Menu3.RightClick();
        }
    }
}
