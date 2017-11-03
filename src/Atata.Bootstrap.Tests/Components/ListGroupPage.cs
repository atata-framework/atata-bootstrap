namespace Atata.Bootstrap.Tests
{
    using _ = ListGroupPage;

    [Url("ListGroups.html")]
    public class ListGroupPage : Page<_>
    {
        public H1<_> Header { get; set; }

        public OrderedList<BadgesListItems, _> BadgesListItemsInOL { get; set; }

        public BSListGroupItem<_> ListGroupItem { get; private set; }
        public BSListGroup<ListItem<_>, _> ListGroup { get; private set; }

        public ControlList<BSListGroupItem<_>, _> ListGroupItems { get; private set; }
        public ControlList<BSListGroup<ListItem<_>, _>, _> ListGroups { get; private set; }

        [FindByAttribute("href", new string[] { "#" })]
        public BSListGroupItem<_> ListGroupItemWithHref { get; private set; }

        [FindByClass("list-group-item active")]
        public BSListGroupItem<_> ListGroupItemWithActive { get; private set; }

        [FindByXPath("div[@class='panel-group']/div[@class='panel panel-default'][7]/div[@class='list-group'][1]/a[@class='list-group-item active']/h4[@class='list-group-item-heading']")]
        public H4<_> ListGroupItem2ndWithActive { get; private set; }

        [FindByXPath("div[@class='list-group']/a[@class='list-group-item disabled']")]
        public BSListGroupItem<_> IsDisabledItem { get; set; }

        [FindByXPath("div[@class='panel-group']/div[@class='panel panel-default'][7]/div[@class='list-group'][1]/a[@class='list-group-item active']")]
        public BSListGroupItem<_> IsActiveItem { get; set; }

        public class BadgesListItems : ListItem<_>
        {
            [FindByClass("badge")]
            public Number<_> Number { get; set; }

            public Text<_> InnerContent { get; set; }
        }

        public class UnOrderedListItem : Control<_>
        {
            public H5<_> Header { get; private set; }
        }

        public class BSListGroupItem : Control<_>
        {
        }

        public class BSListGroup : Control<_>
        {
        }
    }
}