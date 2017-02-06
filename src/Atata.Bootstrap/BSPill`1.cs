namespace Atata.Bootstrap
{
    [ControlDefinition("li[parent::ul[contains(concat(' ', normalize-space(@class), ' '), ' nav-pills ')]]", ComponentTypeName = "pill")]
    [ControlFinding(FindTermBy.Content)]
    public class BSPill<TOwner> : BSNavItem<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
