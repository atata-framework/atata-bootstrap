using _ = Atata.Bootstrap.Tests.PillsPage;

namespace Atata.Bootstrap.Tests
{
    [Url("Pills.html")]
    [TermFindSettings(FindTermBy.Id, Case = TermCase.LowerMerged)]
    public class PillsPage : Page<_>
    {
        public PillPane1 Pane1 { get; private set; }

        public PillPane2 Pane2 { get; private set; }

        public PillPane3 Pane3 { get; private set; }

        public BSPill<_> Menu1 { get; private set; }

        public BSPill<_> Menu2 { get; private set; }

        public BSPill<_> Menu3 { get; private set; }

        [FindByClass("active")]
        public BSPill<_> ActiveMenu { get; private set; }

        public class PillPane1 : BSTabPane<_>
        {
            public H3<_> Header { get; private set; }

            [FindByXPath("p")]
            public Text<_> Text { get; private set; }

            [FindFirst]
            public TextInput<_> TextInput { get; private set; }
        }

        public class PillPane2 : BSTabPane<_>
        {
            public H3<_> Header { get; private set; }

            [FindByXPath("p")]
            public Text<_> Text { get; private set; }

            [FindFirst]
            public CheckBox<_> CheckBox { get; private set; }
        }

        public class PillPane3 : BSTabPane<_>
        {
            public H3<_> Header { get; private set; }

            [FindByXPath("p")]
            public Text<_> Text { get; private set; }
        }
    }
}
