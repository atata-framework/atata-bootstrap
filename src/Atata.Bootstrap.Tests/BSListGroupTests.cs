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

            UnorderedList.Items.Count.Should.Equal(5).
            OrderedList.Items.Count.Should.Equal(3).

            BadgesOrderedList.Items.Count.Should.Equal(3).

            ListGroupItems.Count.Should.Equal(34).
            ListGroups.Count.Should.Equal(10).

            ListGroupItemWithHref.RightClick().
            ListGroupItemWithActive.Content.Should.Equal("Cras justo odio");
        }
    }
}