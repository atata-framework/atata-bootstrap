using System.Linq;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents Bootstrap list group item control.
    /// Default search finds the first occurring element with "list-group-item" class.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition(ContainingClass = BSClass.ListGroupItem, ComponentTypeName = "list group item")]
    public class BSListGroupItem<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public ValueProvider<bool, TOwner> IsActive =>
            CreateValueProvider("active state", () => Attributes.Class.Value.Contains(BSClass.Active));

        protected override bool GetIsEnabled() =>
            !Attributes.Class.Value.Contains(BSClass.Disabled);
    }
}
