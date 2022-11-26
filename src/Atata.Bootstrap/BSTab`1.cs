namespace Atata.Bootstrap
{
    [ControlDefinition("*[parent::*[contains(concat(' ', normalize-space(@class), ' '), ' nav-tabs ')]]", ComponentTypeName = "tab")]
    public class BSTab<TOwner> : BSNavItem<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
