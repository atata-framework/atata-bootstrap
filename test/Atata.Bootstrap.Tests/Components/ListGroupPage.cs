#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace Atata.Bootstrap.Tests;

using _ = ListGroupPage;

[Url("listgroup")]
public class ListGroupPage : Page<_>
{
    public ControlList<BSListGroup<_>, _> AllListGroups { get; private set; }

    public ControlList<BSListGroupItem<_>, _> AllListGroupItems { get; private set; }

    [FindById]
    public BSListGroup<_> RegularGroup { get; private set; }

    [FindById]
    public BSListGroup<BadgeListGroupItem, _> BadgeGroup { get; private set; }

    [FindById]
    public BSListGroup<_> LinkGroup { get; private set; }

    [FindById]
    public BSListGroup<_> ButtonGroup { get; private set; }

    [FindById]
    public BSListGroup<CustomContentListGroupItem, _> CustomContentGroup { get; private set; }

    [FindById("custom-content-group")]
    public CustomListGroup CustomGroup { get; private set; }

    public class BadgeListGroupItem : BSListGroupItem<_>
    {
        [FindByClass(BSClass.Badge)]
        public Number<_> Number { get; private set; }

        [UseParentScope]
        public Text<_> Text { get; private set; }
    }

    public class CustomContentListGroupItem : BSListGroupItem<_>
    {
        public H4<_> Heading { get; private set; }

        [FindByXPath("p")]
        public Text<_> Text { get; private set; }
    }

    public class CustomListGroup : BSListGroup<CustomContentListGroupItem, _>
    {
        [FindByIndex(0)]
        public CustomContentListGroupItem Item1 { get; private set; }

        [FindByIndex(1)]
        public CustomContentListGroupItem Item2 { get; private set; }

        [FindByIndex(2)]
        public CustomContentListGroupItem Item3 { get; private set; }
    }
}
