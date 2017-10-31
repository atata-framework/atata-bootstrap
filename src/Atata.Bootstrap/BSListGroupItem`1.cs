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
    }
}