#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace Atata.Bootstrap.Tests;

using _ = DropdownPage;

[Url("dropdown")]
public sealed class DropdownPage : Page<_>
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
