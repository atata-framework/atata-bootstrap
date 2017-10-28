using _ = Atata.Bootstrap.Tests.AccordionsPage;

namespace Atata.Bootstrap.Tests
{
    [Url("Accordions.html")]
    [TermFindSettings(FindTermBy.Id, Case = TermCase.LowerMerged)]
    public class AccordionsPage : Page<_>
    {
        public H1<_> Header { get; set; }

        public Text<_> Content { get; set; }

        public BSAccordion<_> Menu1 { get; private set; }

        public BSAccordion<_> Menu2 { get; private set; }

        public BSAccordion<_> Menu3 { get; private set; }

        public BSAccordion<_> Menu4 { get; private set; }


        public ControlList<AccordionItem, _> AccordionItems { get; private set; }

        [FindByClass("active")]
        public BSPill<_> ActiveMenu { get; private set; }

        [ControlDefinition("div", ContainingClass = "panel-heading", ComponentTypeName = "accordion item")]
        public class AccordionItem : Control<_>
        {
            public H4<_> Header { get; private set; }

            [ControlDefinition("a", ContainingClass = "collapsed", ComponentTypeName = "accordion item")]
            public Control<_> ATag { get; private set; }

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
