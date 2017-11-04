namespace Atata.Bootstrap.Tests
{
    using _ = AccordionsPage;

    [Url("Accordions.html")]
    public class AccordionsPage : Page<_>
    {
        public H1<_> Header { get; set; }

        public ControlList<BSAccordion<_>, _> MyAccordions { get; private set; }
    }
}
