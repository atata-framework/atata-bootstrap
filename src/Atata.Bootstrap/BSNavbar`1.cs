namespace Atata.Bootstrap
{
    [ControlDefinition(ContainingClass = "navbar", ComponentTypeName = "navbar", IgnoreNameEndings = "Menu,Navbar")]
    public class BSNavbar<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}



