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

            ListGroupItems.Count.Should.Equal(34).
            ListGroups.Count.Should.Equal(10).

            BadgesListItemsInOL.Items.Count.Should.Equal(3).
            BadgesListItemsInOL.Items[x => x.Number == 2].InnerContent.Should.Contain("Dapibus ac facilisis in").

            ListGroupItemWithHref.RightClick().

            ListGroupItemWithActive.Content.Should.Equal("Cras justo odio").
            ListGroupItem2ndWithActive.Content.Should.Equal("List group item heading").

            IsActiveItem.IsActive.Should.BeTrue().
            IsDisabledItem.IsEnabled.Should.BeFalse();
        }
    }
}