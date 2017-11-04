using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    // [ControlDefinition("a[@data-toggle='collapse' AND @data-parent='#accordion']", ComponentTypeName = "collapse with accordion")]
    [ControlDefinition("a[@data-parent='#accordion']", ComponentTypeName = "collapse with accordion")]
    public class BSAccordion<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}