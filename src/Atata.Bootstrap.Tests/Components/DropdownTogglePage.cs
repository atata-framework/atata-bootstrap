namespace Atata.Bootstrap.Tests
{
    using _ = DropdownTogglePage;

    [Url("dropdown")]
    public class DropdownTogglePage : Page<_>
    {
        public RegularDropdownToggle Regular { get; private set; }

        public BSDropdownToggle<_> Disabled { get; private set; }

        public class RegularDropdownToggle : BSDropdownToggle<_>
        {
            public Link<_> Item1 { get; private set; }

            public Link<_> Item2 { get; private set; }

            public Link<_> Item3 { get; private set; }
        }
    }
}
