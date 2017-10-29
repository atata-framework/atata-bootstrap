using _ = Atata.Bootstrap.Tests.AccordionsPage;

namespace Atata.Bootstrap.Tests
{
    [Url("Accordions.html")]
    [TermFindSettings(FindTermBy.Id, Case = TermCase.LowerMerged)]
    public class AccordionsPage : Page<_>
    {
        public H1<_> Header { get; set; }

        [FindById]
        public Text<_> Description { get; set; }

        public Link<_> Menu1 { get; set; }
        public Link<_> Menu2 { get; set; }
        public Link<_> Menu3 { get; set; }

        [FindById]
        public ControlList<AccordionItem, _> Accordion { get; private set; }

        [ControlDefinition("div", ContainingClass = "panel-default")]
        public class AccordionItem : Control<_>
        {
            public H4<_> Header { get; private set; }

            [ControlDefinition("a", ContainingClass = "collapsed")]
            public Control<_> ATag { get; private set; }
        }

    }
}
