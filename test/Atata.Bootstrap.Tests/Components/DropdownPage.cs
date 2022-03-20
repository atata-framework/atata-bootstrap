namespace Atata.Bootstrap.Tests
{
    using _ = DropdownPage;

    [Url("dropdown")]
    public class DropdownPage : Page<_>
    {
        public RegularDropdown Regular { get; private set; }

        public BSDropdown<_> Disabled { get; private set; }

        public class RegularDropdown : BSDropdown<_>
        {
            public Link<_> Item1 { get; private set; }

            public Link<_> Item2 { get; private set; }

            public Link<_> Item3 { get; private set; }
        }
    }
}
