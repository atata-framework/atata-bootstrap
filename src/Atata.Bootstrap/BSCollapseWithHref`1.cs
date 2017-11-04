using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    [ControlDefinition("a[@data-toggle='collapse']", ComponentTypeName = "collapse with href")]
    public class BSCollapseWithHref<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
