namespace Atata.Bootstrap
{
    [ControlDefinition("li", ComponentTypeName = "nav item")]
    public class BSNavItem<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public DataProvider<bool, TOwner> IsActive => GetOrCreateDataProvider(
            nameof(IsActive).ToString(TermCase.MidSentence),
            () => Scope.HasClass("active"));
    }
}
