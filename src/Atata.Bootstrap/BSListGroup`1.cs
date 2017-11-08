namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents Bootstrap list group control.
    /// Default search finds the first occuring element with "list-group" class.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    /// <seealso cref="BSListGroupItem{TOwner}" />
    public class BSListGroup<TOwner> : BSListGroup<BSListGroupItem<TOwner>, TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
