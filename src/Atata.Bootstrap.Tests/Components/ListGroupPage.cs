namespace Atata.Bootstrap.Tests
{
    using _ = ListGroupPage;

    [Url("ListGroups.html")]
    public class ListGroupPage : Page<_>
    {
        public H1<_> Header { get; set; }

        public OrderedList<ListItem<_>, _> OrderedList { get; private set; }
        public UnorderedList<ListItem<_>, _> UnorderedList { get; private set; }

        public BSListGroupItem<_> ListGroupItem { get; private set; }
        public BSListGroup<ListItem<_>, _> ListGroup { get; private set; }

        public ControlList<BSListGroupItem<_>, _> ListGroupItems { get; private set; }
        public ControlList<BSListGroup<ListItem<_>, _>, _> ListGroups { get; private set; }

        [FindByAttribute("href", new string[] { "#" })]
        public BSListGroupItem<_> ListGroupItemWithHref { get; private set; }

        [FindByClass("list-group-item active")]
        public BSListGroupItem<_> ListGroupItemWithActive { get; private set; }

        [FindById("badges")]
        public OrderedList<ListItem<_>, _> BadgesOrderedList { get; private set; }

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