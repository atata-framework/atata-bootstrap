namespace Atata.Bootstrap
{
    [ControlDefinition(ComponentTypeName = "nav item")]
    [FindByContent]
    public class BSNavItem<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public DataProvider<bool, TOwner> IsActive => GetOrCreateDataProvider(
            "active state",
            GetIsActive);

        [FindByXPath("(self::* | child::*)[contains(concat(' ', normalize-space(@class), ' '), ' active ')]")]
        protected Control<TOwner> ActiveIdentifier { get; private set; }

        [FindByXPath("(self::* | child::*)[contains(concat(' ', normalize-space(@class), ' '), ' disabled ')]")]
        protected Control<TOwner> DisabledIdentifier { get; private set; }

        protected virtual bool GetIsActive()
        {
            return ActiveIdentifier.IsPresent;
        }

        protected override bool GetIsEnabled()
        {
            return !DisabledIdentifier.IsPresent;
        }
    }
}
