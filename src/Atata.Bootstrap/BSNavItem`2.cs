namespace Atata.Bootstrap
{
    public class BSNavItem<TNavigateTo, TOwner> : BSNavItem<TOwner>, INavigable<TNavigateTo, TOwner>
        where TNavigateTo : PageObject<TNavigateTo>
        where TOwner : PageObject<TOwner>
    {
    }
}
