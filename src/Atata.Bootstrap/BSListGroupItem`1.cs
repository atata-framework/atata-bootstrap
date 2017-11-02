using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents the list group item control(Bootstrap class="list-group-item"). Default search finds the first occuring class="list-group-item" element.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition(ContainingClass = "list-group-item", ComponentTypeName = "list group item")]
    public class BSListGroupItem<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public DataProvider<bool, TOwner> IsActive => GetOrCreateDataProvider(nameof(IsActive).ToString(TermCase.MidSentence), () => Attributes.Class.Value.Contains(BSClass.Active));

        public new DataProvider<bool, TOwner> IsEnabled => GetOrCreateDataProvider("enabled", GetIsEnabled);

        // Overrides GetIsEnables() from Atata.Control<TOwner>.GetIsEnabled() to change the default behavior of this method.
        // If the class attribute has 'disabled' value, this method returns 'false' in inspecting this element.
        protected override bool GetIsEnabled()
        {
            return !Scope.HasClass(BSClass.Disabled);
        }
    }
}