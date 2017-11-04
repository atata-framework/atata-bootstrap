namespace Atata.Bootstrap.Tests
{
    using _ = CollapseWithHref;

    [Url("CollapseWithHref.html")]
    public class CollapseWithHref : Page<_>
    {
        public H1<_> Header { get; set; }

        public BSCollapseWithHref<_> MyCollapseWithHref { get; set; }
    }
}