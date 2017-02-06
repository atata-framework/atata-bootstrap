using _ = Atata.Bootstrap.Tests.TabsPage;

namespace Atata.Bootstrap.Tests
{
    [Url("Tabs.html")]
    [TermFindSettings(FindTermBy.Id, Case = TermCase.LowerMerged)]
    public class TabsPage : Page<_>
    {
        public TabPane1 Pane1 { get; private set; }

        public TabPane2 Pane2 { get; private set; }

        public TabPane3 Pane3 { get; private set; }

        public BSTab<_> Menu1 { get; private set; }

        public BSTab<_> Menu2 { get; private set; }

        public BSTab<_> Menu3 { get; private set; }

        [FindByClass("active")]
        public BSTab<_> ActiveMenu { get; private set; }

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
}
