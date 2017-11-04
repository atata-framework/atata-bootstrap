using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents the collapse with button item control(Bootstrap <button data-toggle="collapse" />). Default search finds the first occuring data-toggle="collapse" element.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition("button[@data-toggle='collapse']", ComponentTypeName = "collapse with button")]
    public class BSCollapseWithButton<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
