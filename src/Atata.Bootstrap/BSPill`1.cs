namespace Atata.Bootstrap
{
    [ControlDefinition("li[parent::ul[contains(concat(' ', normalize-space(@class), ' '), ' nav-pills ')]]", ComponentTypeName = "pill")]
    public class BSPill<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public DataProvider<bool, TOwner> IsActive => GetOrCreateDataProvider(
            nameof(IsActive).ToString(TermCase.MidSentence),
            () => Scope.HasClass("active"));
    }
}
