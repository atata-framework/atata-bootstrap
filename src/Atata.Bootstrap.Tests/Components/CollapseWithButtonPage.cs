namespace Atata.Bootstrap.Tests
{
    using _ = CollapseWithButton;

    [Url("CollapseWithButton.html")]
    public class CollapseWithButton : Page<_>
    {
        public H1<_> Header { get; set; }

        public BSCollapseWithButton<_> MyCollapseWithButton { get; private set; }
    }
}