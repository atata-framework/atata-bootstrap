using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents the collapse with href item control(Bootstrap <a data-toggle="collapse" />). Default search finds the first occuring data-toggle="collapse" element.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition("a[@data-toggle='collapse']", ComponentTypeName = "collapse with href")]
    public class BSCollapseWithHref<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
