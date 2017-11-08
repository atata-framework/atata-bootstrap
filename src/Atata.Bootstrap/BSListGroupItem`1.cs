using System.Linq;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents Bootstrap list group item control.
    /// Default search finds the first occuring element with "list-group-item" class.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition(ContainingClass = BSClass.ListGroupItem, ComponentTypeName = "list group item")]
    public class BSListGroupItem<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public DataProvider<bool, TOwner> IsActive => GetOrCreateDataProvider(
            nameof(IsActive).ToString(TermCase.MidSentence),
            () => Attributes.Class.Value.Contains(BSClass.Active));

        protected override bool GetIsEnabled()
        {
            return !Scope.HasClass(BSClass.Disabled);
        }
    }
}
