using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    [ControlDefinition(ContainingClass = "collapsed", ComponentTypeName = "collapse", Visibility = Visibility.Any)]
    public class BSAccordion<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
