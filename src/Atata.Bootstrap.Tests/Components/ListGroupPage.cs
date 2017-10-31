namespace Atata.Bootstrap.Tests
{
    using _ = ListGroupPage;

    [Url("ListGroups.html")]
    public class ListGroupPage : Page<_>
    {
        public H1<_> Header { get; set; }

        public OrderedList<ListItem<_>, _> OrderedList { get; private set; }

        public UnorderedList<ListItem<_>, _> UnorderedList { get; private set; }

        [FindById]
        public ControlList<UnOrderedListItem, _> ControlList { get; private set; }

        [FindById("badges")]
        public OrderedList<ListItem<_>, _> BadgesOrderedList { get; private set; }

        [FindById("linked-items")]
        public OrderedList<ListItem<_>, _> LinkedItemsListGroup { get; private set; }

        [FindById]
        public Text<_> Description { get; set; }

        public Link<_> Menu1 { get; set; }
        public Link<_> Menu2 { get; set; }
        public Link<_> Menu3 { get; set; }

        [ControlDefinition("div", ContainingClass = "ulbasic")]
        public class UnOrderedListItem : Control<_>
        {
            public H5<_> Header { get; private set; }
        }
    }
}
