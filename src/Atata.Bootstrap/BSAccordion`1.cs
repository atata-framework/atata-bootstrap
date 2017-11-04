using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents the accordion item control(Bootstrap data-parent="#accordion"). Default search finds the first occuring data-parent="#accordion" element.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    // [ControlDefinition("a[@data-toggle='collapse' AND @data-parent='#accordion']", ComponentTypeName = "collapse with accordion")]
    [ControlDefinition("a[@data-parent='#accordion']", ComponentTypeName = "collapse with accordion")]
    public class BSAccordion<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}