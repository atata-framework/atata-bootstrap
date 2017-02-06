namespace Atata.Bootstrap
{
    [ControlDefinition("li[parent::ul[contains(concat(' ', normalize-space(@class), ' '), ' nav-pills ')]]", ComponentTypeName = "pill")]
    public class BSPill<TOwner> : BSNavItem<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
