namespace Atata.Bootstrap.Tests;

using _ = TabsPage;

[Url("tabs")]
[TermFindSettings(Case = TermCase.LowerMerged, TargetAttributeType = typeof(FindByIdAttribute), TargetAnyType = true)]
public class TabsPage : Page<_>
{
    public TabPane1 Pane1 { get; private set; }

    public TabPane2 Pane2 { get; private set; }

    public TabPane3 Pane3 { get; private set; }

    public BSTab<_> Menu1 { get; private set; }

    public BSTab<_> Menu2 { get; private set; }

    public BSTab<_> Menu3 { get; private set; }

    public BSTab<_> Menu4 { get; private set; }

    public ControlList<BSTab<_>, _> MenuItems { get; private set; }

    public BSTab<_> ActiveMenu => MenuItems[x => x.IsActive];

    public class TabPane1 : BSTabPane<_>
    {
        public H3<_> Header { get; private set; }

        [FindByXPath("p")]
        public Text<_> Text { get; private set; }

        [FindFirst]
        public TextInput<_> TextInput { get; private set; }
    }

    public class TabPane2 : BSTabPane<_>
    {
        public H3<_> Header { get; private set; }

        [FindByXPath("p")]
        public Text<_> Text { get; private set; }

        [FindFirst]
        public CheckBox<_> CheckBox { get; private set; }
    }

    public class TabPane3 : BSTabPane<_>
    {
        public H3<_> Header { get; private set; }

        [FindByXPath("p")]
        public Text<_> Text { get; private set; }
    }
}
