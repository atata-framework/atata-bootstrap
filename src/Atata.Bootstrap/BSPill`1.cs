namespace Atata.Bootstrap
{
    [ControlDefinition("*[parent::*[contains(concat(' ', normalize-space(@class), ' '), ' nav-pills ')]]", ComponentTypeName = "pill")]
    public class BSPill<TOwner> : BSNavItem<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
