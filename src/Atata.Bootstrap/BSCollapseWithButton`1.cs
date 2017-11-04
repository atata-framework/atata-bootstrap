using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    [ControlDefinition("button[@data-toggle='collapse']", ComponentTypeName = "collapse with button")]
    public class BSCollapseWithButton<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
