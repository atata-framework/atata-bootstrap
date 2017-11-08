namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents Bootstrap list group control.
    /// Default search finds the first occuring element with "list-group" class.
    /// </summary>
    /// <typeparam name="TItem">The type of the list item control.</typeparam>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    /// <seealso cref="BSListGroupItem{TOwner}" />
    [ControlDefinition(ContainingClass = BSClass.ListGroup, ComponentTypeName = "list group")]
    [FindSettings(OuterXPath = "./")]
    public class BSListGroup<TItem, TOwner> : ItemsControl<TItem, TOwner>
        where TItem : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
