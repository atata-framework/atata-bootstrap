namespace Atata.Bootstrap
{
    [ControlDefinition("ul[contains(concat(' ', normalize-space(@class), ' '), ' nav-tabs ')]/li", ComponentTypeName = "tab")]
    public class BSTab<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public DataProvider<bool, TOwner> IsActive => GetOrCreateDataProvider(
            nameof(IsActive).ToString(TermCase.MidSentence),
            () => Scope.HasClass("active"));
    }
}
