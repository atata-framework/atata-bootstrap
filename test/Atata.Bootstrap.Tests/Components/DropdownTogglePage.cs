#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace Atata.Bootstrap.Tests;

using _ = DropdownTogglePage;

[Url("dropdown")]
public sealed class DropdownTogglePage : Page<_>
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
